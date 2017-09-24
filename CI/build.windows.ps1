#Cleans the local repo, then builds the native and CLI libraries.

#TODO:
#	* Check tools exist:
#		* dotnet
#		* dotnet is 2.0 or above so SLN to msbuild works
#		* NMake exists (Cl.exe will likely be there if NMake is too)
#	* If not, fail here
#	* Check that PDCurses is in ./pdcurses:
#		* pdcurses.lib
#		* curses.h
#		* panel.h
#		* term.h
#	* If not:
#		* Clone PDCurses Github
#		* Build pdcurses:
#			```
#			cd (PDCurses folder)\win32
#			nmake -f vcwin32.mak WIDE=Y
#			```
#		* Copy .lib and headers to ./pdcurses

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
