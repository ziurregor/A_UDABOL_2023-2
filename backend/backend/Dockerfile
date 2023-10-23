# Usar la imagen de SDK de .NET para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copiar los archivos del proyecto "backend" (y otros archivos necesarios)
COPY backend/backend.csproj backend/
COPY Modelo/Modelo.csproj Modelo/
COPY ADO/ADO.csproj ADO/

# Restaurar las dependencias y compilar la aplicación
RUN dotnet restore backend/backend.csproj

# Copiar el resto del código fuente
COPY . .

# Compilar la aplicación
RUN dotnet build backend/backend.csproj -c Release -o /app/build

# ...

# El resto del Dockerfile para empaquetar y ejecutar la aplicación
WORKDIR /app