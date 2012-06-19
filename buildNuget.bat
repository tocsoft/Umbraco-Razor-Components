@echo off

msbuild /t:Clean /p:Configuration=Release

del build /Q
mkdir build

.nuget\nuget.exe pack -Build Tocsoft.Umbraco.RazorComponents\Tocsoft.Umbraco.RazorComponents.csproj -Prop Configuration=Release -OutputDirectory build


if %1 == push (

.nuget\nuget push build\*.nupkg

)