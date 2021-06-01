#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/app/Acme.Sample.App/Acme.Sample.App.csproj", "src/app/Acme.Sample.App/"]
RUN dotnet restore "src/app/Acme.Sample.App/Acme.Sample.App.csproj"
COPY . .
WORKDIR "/src/src/app/Acme.Sample.App"
RUN dotnet build "Acme.Sample.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.Sample.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.Sample.App.dll"]