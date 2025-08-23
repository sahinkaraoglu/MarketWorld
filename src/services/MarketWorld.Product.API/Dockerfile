FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/services/MarketWorld.Product.API/MarketWorld.Product.API.csproj", "src/services/MarketWorld.Product.API/"]
COPY ["src/MarketWorld.Core/MarketWorld.Core.csproj", "src/MarketWorld.Core/"]
COPY ["src/MarketWorld.Infrastructure/MarketWorld.Infrastructure.csproj", "src/MarketWorld.Infrastructure/"]
COPY ["src/MarketWorld.Application/MarketWorld.Application.csproj", "src/MarketWorld.Application/"]
RUN dotnet restore "src/services/MarketWorld.Product.API/MarketWorld.Product.API.csproj"
COPY . .
WORKDIR "/src/src/services/MarketWorld.Product.API"
RUN dotnet build "MarketWorld.Product.API.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/src/services/MarketWorld.Product.API"
RUN dotnet publish "MarketWorld.Product.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketWorld.Product.API.dll"]
