## Docker file config
``` dockerFile
FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
WORKDIR /src
COPY ["ImageCompress.API.csproj", "./"]
RUN dotnet restore "./ImageCompress.API.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ImageCompress.API.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "ImageCompress.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ImageCompress.API.dll"]

```
build docker container from image
```
docker build -t imagecompress -f Dockerfile .
```

run docker container : 
```
docker run -ti --rm -p 8080:80 imagecompress
```

stop docker container : 
```
docker stop CONTAINER_NAME
```
