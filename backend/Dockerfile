# Etapa 1: SDK de .NET para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copia y restaura las dependencias
COPY backend/backend.csproj backend/
COPY Modelo/Modelo.csproj Modelo/
COPY ADO/ADO.csproj ADO/
RUN dotnet restore backend/backend.csproj

# Copia el resto del código fuente y compila
COPY . .
RUN dotnet build backend/backend.csproj -c Release -o /app/build

# Etapa 2: Imagen ASP.NET para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS publish
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Copia el resultado de la etapa anterior
COPY --from=build /app/build .

ENTRYPOINT ["dotnet", "backend.dll"]
