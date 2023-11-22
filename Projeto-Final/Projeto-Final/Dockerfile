FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Projeto-Final/Projeto-Final.csproj", "Projeto-Final/"]
RUN dotnet restore "Projeto-Final/Projeto-Final.csproj"
COPY . .
WORKDIR "/src/Projeto-Final"
RUN dotnet build "Projeto-Final.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Projeto-Final.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Projeto-Final.dll"]
