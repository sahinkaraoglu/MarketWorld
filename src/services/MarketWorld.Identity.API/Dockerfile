FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Services/MarketWorld.Identity.API/AuthenticationService.csproj", "src/Services/MarketWorld.Identity.API/"]
COPY ["src/MarketWorld.Core/MarketWorld.Core.csproj", "src/MarketWorld.Core/"]
COPY ["src/MarketWorld.Infrastructure/MarketWorld.Infrastructure.csproj", "src/MarketWorld.Infrastructure/"]
COPY ["src/MarketWorld.Application/MarketWorld.Application.csproj", "src/MarketWorld.Application/"]
RUN dotnet restore "src/Services/MarketWorld.Identity.API/AuthenticationService.csproj"
COPY . .
WORKDIR "/src/src/Services/MarketWorld.Identity.API"
RUN dotnet build "AuthenticationService.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/src/Services/MarketWorld.Identity.API"
RUN dotnet publish "AuthenticationService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthenticationService.dll"]
