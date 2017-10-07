#~/bin/bash
echo TODO

#Note to self: this is not a provisioning script,
#if any dependencies are missing it should fail
#rather than try to install them
#TODO:
#	* Check dependencies exist
#		* dotnet
#			* dotnet >= 2.0
#			* If missing, fail here
#		* curses available (how?)
#			* If not, fail here
#	* Native
#		* Clean: dotnet msbuild?
#		* Build: dotnet msbuild?
#	* CLI
#		* Clean: dotnet msbuild?
#		* Build: dotnet msbuild?
invoke_build_project () {
	eval $1
	if [ $? -ne 0 ]
	then
		echo "Build request '$1' failed, can't continue"
		return 1
	fi
	return 0
}

build_project_native () {
	$invocation = "dotnet msbuild CursesSharp.Native.Linux.sln /t:$1 /p:Configuration=$2"
	invoke_build_project $invocation
}

build_project_cli () {
	$invocation = "dotnet msbuild CursesSharp.sln /t:$1 /p:Configuration=$2"
	invoke_build_project $invocation
}

# Clean native assemblies
build_project_native "Clean" "Release"
build_project_native "Clean" "Debug"
# Build native assemblies
build_project_native "Build" "Release"
build_project_native "Build" "Debug"
# Clean CLI assemblies
build_project_cli "Clean" "Release"
build_project_cli "Clean" "Debug"
# Build CLI assemblies
build_project_cli "Build" "Release"
build_project_cli "Build" "Debug"