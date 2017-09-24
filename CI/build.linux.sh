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