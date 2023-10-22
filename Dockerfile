FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build-env

WORKDIR /pizzaapp

COPY ["pizzaApp.csproj", "."]

# # Restore as distinct layers
RUN dotnet restore "pizzaApp.csproj"
COPY . .

# Build and publish a release
RUN dotnet build "pizzaApp.csproj" -c Release -o out
RUN dotnet publish "pizzaApp.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /pizzaapp
COPY --from=build-env /pizzaapp/out .

EXPOSE 80

ENTRYPOINT ["pizza", "pizzaapp.dll"]