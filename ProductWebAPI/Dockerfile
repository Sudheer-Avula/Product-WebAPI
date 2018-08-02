FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY ProductWebAPI/ProductWebAPI.csproj ProductWebAPI/
RUN dotnet restore ProductWebAPI/ProductWebAPI.csproj
COPY . .
WORKDIR /src/ProductWebAPI
RUN dotnet build ProductWebAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProductWebAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProductWebAPI.dll"]
