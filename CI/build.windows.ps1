#Cleans the local repo, then builds the native and CLI libraries.

#TODO: perform clean step

#Check tools exist:
#	* dotnet
#	* dotnet is 2.0 or above so SLN to msbuild works
#	* vcvarsall.bat exists (NMake and Cl.exe will likely be there if the vars batch is too)
#		* It's most likely in "$env:programfiles\Microsoft Visual Studio\2017\Community\VC\Auxiliary\Build\vcvarsall.bat".
$canContinue = $true
$dotNetPath = "dotnet"
$vsVarsAllPath = "'$env:programfiles\Microsoft Visual Studio\2017\Community\VC\Auxiliary\Build\vcvarsall.bat'"
$allPaths = $dotNetPath, $vsVarsAllPath
foreach($path in $allPaths) {
	$command = "where {0}" -f $path
	$foundPath = Invoke-Expression $command
	if(-not ($?)) {
		Write-Error "Couldn't find {0}!" -f $path
		$canContinue = $false
	}
	else {
		Write-Debug "Found {0} at {1}" -f $path, $foundPath
	}
}
#If not, fail here
if(-not ($canContinue)) {
	Write-Error "Needed tools are missing; can't continue CI run"
	return 1
}
#Check that PDCurses is in ./pdcurses:
#	* pdcurses.lib
#	* curses.h
#	* panel.h
#	* term.h
$pdCursesFiles = "pdcurses.lib", "curses.h", "panel.h", "term.h"
$needToBuildPdCurses = $false
foreach($f in $pdCursesFile) {
	$filePath = "../pdcurses/{0}" -f $f
	if(-not (Test-Path $f)) {
		Write-Output "Missing PDCurses file {0}, will need to rebuild" -f $filePath
		$needToBuildPdCurses = $true
		break
	}
}
#If not:
if(-not ($needToBuildPdCurses)) {
	#Clone PDCurses from Github
	$pdCursesRepoPath = "..\..\PDCurses"
	if(-not(Test-Path $pdCursesRepoPath)) {
		Invoke-Expression "git clone https://github.com/wmcbrine/PDCurses.git ../../PDCurses"
		if(-not($?)) {
			Write-Error "Failed to clone PDCurses repo, can't continue run"
			return 1
		}
	}
	#Build pdcurses:
	Invoke-Expression $vsVarsAllPath

	$prevPwd = "$pwd"
	Set-Location "$pdCursesRepoPath\win32"
	Invoke-Expression "nmake -f vcwin32.mak WIDE=Y"
	if(-not($?)) {
		Write-Error "Failed to build PDCurses, can't continue run"
		return 1
	}
	Set-Location $prevPwd
	# Copy .lib (.../win32/pdcurses.lib) and headers to ./pdcurses
	$pdCursesResourcePath = "../PDCurses"
	if(-not(Test-Path $pdCursesResourcePath)) {
		mkdir $pdCursesRepoPath
	}
	Copy-Item "$pdCursesRepoPath\win32\pdCurses.lib", "$pdCursesRepoPath\curses.h", "$pdCursesRepoPath\panel.h", "$pdCursesRepoPath\term.h" -Destination $pdCursesResourcePath
	if(-not($?)) {
		Write-Error "Failed to copy PDCurses libraries, can't continue run"
		return 1
	}
}

# Clean native assemblies
&dotnet msbuild CursesSharp.Native.sln /t:Clean /p:Configuration=Release
&dotnet msbuild CursesSharp.Native.sln /t:Clean /p:Configuration=Debug
# Build native assemblies
&dotnet msbuild CursesSharp.Native.sln /t:Build /p:Configuration=Release
&dotnet msbuild CursesSharp.Native.sln /t:Build /p:Configuration=Debug
# Clean CLI assemblies
&dotnet msbuild CursesSharp.sln /t:Clean /p:Configuration=Release
&dotnet msbuild CursesSharp.sln /t:Clean /p:Configuration=Debug
# Build CLI assemblies
&dotnet msbuild CursesSharp.sln /t:Build /p:Configuration=Release
&dotnet msbuild CursesSharp.sln /t:Build /p:Configuration=Debug
