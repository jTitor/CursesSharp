#Cleans the local repo, then builds the native and CLI libraries.

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
