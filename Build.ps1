$artifacts = ".\artifacts"

if(Test-Path $artifacts) { Remove-Item $artifacts -Force -Recurse }

dotnet clean .\src\HeboTech.TimeService\HeboTech.TimeService.csproj -c Release
dotnet build .\src\HeboTech.TimeService\HeboTech.TimeService.csproj -c Release
dotnet pack .\src\HeboTech.TimeService\HeboTech.TimeService.csproj -c Release -o $artifacts --no-build