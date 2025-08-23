FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MarketWorld.Gateway.csproj", "./"]
RUN dotnet restore "MarketWorld.Gateway.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MarketWorld.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MarketWorld.Gateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketWorld.Gateway.dll"]
