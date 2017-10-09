#Cleans the local repo, then builds the native and CLI libraries.

#TODO: perform clean step

#Check tools exist:
#	* dotnet
#	* dotnet is 2.0 or above so SLN to msbuild works
#	* vcvarsall.bat exists (NMake and Cl.exe will likely be there if the vars batch is too)
#		* It's most likely in "$env:programfiles\Microsoft Visual Studio\2017\Community\VC\Auxiliary\Build\vcvarsall.bat".
#		* Check for terminal instead - "$env:programfiles\Microsoft Visual Studio\2017\(EDITION)\Common7\Tools\VsDevCmd.bat",
#		  where (EDITION) can be "Community", "BuildTools", or "Enterprise"
$canContinue = $true
$scriptPath = Split-Path -parent $PSCommandPath
$dotNetPath = "dotnet"
$vsVarsAllCommunityPathFmt = "{0}\Microsoft Visual Studio\2017\Community\VC\Auxiliary\Build\vcvarsall.bat"
$vsVarsAllBuildToolsPathFmt = "{0}\Microsoft Visual Studio\2017\BuildTools\VC\Auxiliary\Build\vcvarsall.bat"
$vsVarsAllPath = ""
$vsVarsAllFlags = "x86_amd64"
$programFilesLocations = $env:programfiles, ${env:ProgramFiles(x86)}
$vsVarsAllPathFmts = $vsVarsAllCommunityPathFmt, $vsVarsAllBuildToolsPathFmt

$allPaths = $dotNetPath, $vsVarsAllPath

Write-Output "Searching for dev tools"
foreach($programFilesPath in $programFilesLocations) {
	foreach($vsVarsPathFmt in $vsVarsAllPathFmts) {
		$path = $vsVarsPathFmt -f $programFilesPath
		if(Test-Path $path) {
			$vsVarsAllPath = $path
		}
	}
}
if(-not ($vsVarsAllPath)) {
	Write-Output ("Couldn't find Visual C++ build tools or a Visual Studio installation")
	$canContinue = $false
}
foreach($path in $allPaths) {
	$command = "where `"$path`""
	$foundPath = Invoke-Expression $command
	if(-not ($?)) {
		Write-Output ("Couldn't find $path!")
		$canContinue = $false
	}
	else {
		Write-Output ("Found $path at $foundPath")
	}
}
#If not, fail here
if(-not ($canContinue)) {
	Write-Output "Needed tools are missing; can't continue CI run"
	return 1
}
#Check that PDCurses is in ./pdcurses:
#	* pdcurses.lib
#	* curses.h
#	* panel.h
#	* term.h
Write-Output "Checking that PDCurses is built"
$pdCursesFiles = "pdcurses.lib", "curses.h", "panel.h", "term.h"
$needToBuildPdCurses = $false
foreach($f in $pdCursesFiles) {
	$filePath = "$scriptPath\..\pdcurses\$f"
	if(-not (Test-Path $f)) {
		Write-Output ("Missing PDCurses file $filePath, will need to rebuild")
		$needToBuildPdCurses = $true
		break
	}
}
#If not:
if($needToBuildPdCurses) {
	#Clone PDCurses from Github
	Write-Output "Cloning PDCurses..."
	$pdCursesRepoPath = "$scriptPath\..\..\PDCurses"
	if(-not(Test-Path $pdCursesRepoPath)) {
		Invoke-Expression "git clone https://github.com/wmcbrine/PDCurses.git `"$pdCursesRepoPath`""
		if(-not($?)) {
			Write-Output "Failed to clone PDCurses repo, can't continue run"
			return 1
		}
	}
	#Build pdcurses:
	$prevPwd = "$pwd"

	Write-Output "Building PDCurses"
	Set-Location "$pdCursesRepoPath\win32"
	cmd /C `"`"$vsVarsAllPath`" $vsVarsAllFlags "&" nmake -f vcwin32.mak WIDE=Y`"
	$buildError = $?
	Set-Location $prevPwd
	if(-not($buildError)) {
		Write-Output "Failed to build PDCurses, can't continue run"
		return 1
	}
	# Copy .lib (.../win32/pdcurses.lib) and headers to ./pdcurses
	$pdCursesResourcePath = "`"$scriptPath\..\pdcurses`""
	if(-not(Test-Path $pdCursesResourcePath)) {
		mkdir $pdCursesResourcePath
	}
	Copy-Item "$pdCursesRepoPath\win32\pdCurses.lib", "$pdCursesRepoPath\curses.h", "$pdCursesRepoPath\panel.h", "$pdCursesRepoPath\term.h" -Destination $pdCursesResourcePath
	if(-not($?)) {
		Write-Output "Failed to copy PDCurses libraries, can't continue run"
		return 1
	}
}

foreach($f in $pdCursesFiles) {
	$filePath = "$scriptPath\..\pdcurses\$f"
	if(-not (Test-Path $f)) {
		Write-Output ("Attempted build of PDCurses, but still missing PDCurses file '$filePath'! Can't continue")
		return 1
	}
}

Write-Output "Building CursesSharp assemblies"
function invoke-build-project($invocation) {
	Invoke-Expression $invocation
	if(-not($?)) {
		Write-Output "Build request '$invocation' failed, can't continue"
		return 1
	}
}

function build-project-native($taskString, $configString) {
	$invocation = "dotnet msbuild `"$scriptPath\..\CursesSharp.Native.sln`" /t:$taskString /p:Configuration=$configString"
	return invoke-build-project($invocation)
}

function build-project-cli($taskString, $configString) {
	$invocation = "dotnet msbuild `"$scriptPath\..\CursesSharp.sln`" /t:$taskString /p:Configuration=$configString"
	return invoke-build-project($invocation)
}

# Clean native assemblies
build-project-native("Clean", "Release")
build-project-native("Clean", "Debug")
# Build native assemblies
build-project-native("Build", "Release")
build-project-native("Build", "Debug")
# Clean CLI assemblies
build-project-cli("Clean", "Release")
build-project-cli("Clean", "Debug")
# Build CLI assemblies
build-project-cli("Build", "Release")
build-project-cli("Build", "Debug")
