#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Linker.Api/Linker.Api.csproj", "Linker.Api/"]
RUN dotnet restore "Linker.Api/Linker.Api.csproj"
COPY . .
WORKDIR "/src/Linker.Api"
RUN dotnet build "Linker.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Linker.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Linker.Api.dll"]