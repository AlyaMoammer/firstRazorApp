FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build-env

WORKDIR /pizzaApp

COPY ["pizzaApp.csproj", "."]

# # Restore as distinct layers
RUN dotnet restore "pizzaApp.csproj"
COPY . .

# Build and publish a release
RUN dotnet build "pizzaApp.csproj" -c Release -o out
RUN dotnet publish "pizzaApp.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /pizzaApp
COPY --from=build-env /pizzaApp/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "pizzaApp.dll"]