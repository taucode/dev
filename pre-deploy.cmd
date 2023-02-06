dotnet restore

dotnet build TauCode.Dev.sln -c Debug
dotnet build TauCode.Dev.sln -c Release

dotnet test TauCode.Dev.sln -c Debug
dotnet test TauCode.Dev.sln -c Release

nuget pack nuget\TauCode.Dev.nuspec