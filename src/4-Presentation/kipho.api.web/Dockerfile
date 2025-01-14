#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/4-Presentation/kipho.api.web/kipho.api.web.csproj", "src/4-Presentation/kipho.api.web/"]
COPY ["src/1-Aplication/kipho.api.services/kipho.api.services.csproj", "src/1-Aplication/kipho.api.services/"]
COPY ["src/2-Domain/kipho.api.domain/kipho.api.domain.csproj", "src/2-Domain/kipho.api.domain/"]
COPY ["src/3-Data/kipho.api.data/kipho.api.data.csproj", "src/3-Data/kipho.api.data/"]
COPY ["src/5-CrossCutting/kipho.api.dependencyinjection/kipho.api.dependencyinjection.csproj", "src/5-CrossCutting/kipho.api.dependencyinjection/"]
RUN dotnet restore "src/4-Presentation/kipho.api.web/kipho.api.web.csproj"
COPY . .
WORKDIR "/src/src/4-Presentation/kipho.api.web"
RUN dotnet build "kipho.api.web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kipho.api.web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kipho.api.web.dll"]