FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/services/MarketWorld.Order.API/MarketWorld.Order.API.csproj", "src/services/MarketWorld.Order.API/"]
COPY ["src/MarketWorld.Core/MarketWorld.Core.csproj", "src/MarketWorld.Core/"]
COPY ["src/MarketWorld.Infrastructure/MarketWorld.Infrastructure.csproj", "src/MarketWorld.Infrastructure/"]
COPY ["src/MarketWorld.Application/MarketWorld.Application.csproj", "src/MarketWorld.Application/"]
RUN dotnet restore "src/services/MarketWorld.Order.API/MarketWorld.Order.API.csproj"
COPY . .
WORKDIR "/src/src/services/MarketWorld.Order.API"
RUN dotnet build "MarketWorld.Order.API.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/src/services/MarketWorld.Order.API"
RUN dotnet publish "MarketWorld.Order.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketWorld.Order.API.dll"]
