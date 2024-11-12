# Etapa 1: Construcción de la imagen (build stage)
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos de solución y proyecto
COPY *.sln ./
COPY EntregableAndres/*.csproj ./EntregableAndres/

# Restaurar dependencias del proyecto
RUN dotnet restore

# Copiar el resto de los archivos del proyecto
COPY EntregableAndres/. ./EntregableAndres/

# Publicar la aplicación
RUN dotnet publish EntregableAndres/EntregableAndres.csproj -c Release -o /app/publish

# Etapa 2: Crear la imagen de ejecución (runtime stage)
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos publicados desde la etapa de construcción
COPY --from=build /app/publish .

# Exponer el puerto 5001
EXPOSE 5001

# Establecer el punto de entrada de la aplicación
ENTRYPOINT ["dotnet", "EntregableAndres.dll"]
