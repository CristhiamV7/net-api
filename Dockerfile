# Use the official .NET 9 SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY ["WebApiCarBrands/WebApiCarBrands.csproj", "WebApiCarBrands/"]
WORKDIR /app/WebApiCarBrands
RUN dotnet restore

# Copy all files and build the application
COPY . .
RUN dotnet build -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Expose the port
EXPOSE 8080

# Run the application
ENTRYPOINT ["dotnet", "WebApiCarBrands.dll"]

