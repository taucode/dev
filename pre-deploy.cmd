dotnet restore

dotnet clean --configuration Debug
dotnet clean --configuration Release

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\test\TauCode.Dev.Tests\TauCode.Dev.Tests.csproj
dotnet test -c Release .\test\TauCode.Dev.Tests\TauCode.Dev.Tests.csproj

nuget pack nuget\TauCode.Dev.nuspec