FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MarketWorld.Comment.API.csproj", "./"]
COPY ["../../MarketWorld.Core/MarketWorld.Core.csproj", "../../MarketWorld.Core/"]
COPY ["../../MarketWorld.Infrastructure/MarketWorld.Infrastructure.csproj", "../../MarketWorld.Infrastructure/"]
COPY ["../../MarketWorld.Application/MarketWorld.Application.csproj", "../../MarketWorld.Application/"]
RUN dotnet restore "MarketWorld.Comment.API.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MarketWorld.Comment.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MarketWorld.Comment.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketWorld.Comment.API.dll"]
