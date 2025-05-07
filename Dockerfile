# Use the official .NET 8 SDK image for build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything and build
COPY . . 

# Publish the app
RUN dotnet publish myApp/myApp.csproj -c Release -o /app/out

# Use the NET 8 runtime for finall image FROM
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/out .

# Entrypoint
ENTRYPOINT ["dotnet", "myApp.dll"]
