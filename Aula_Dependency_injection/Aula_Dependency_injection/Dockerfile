FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Aula_Dependency_injection/Aula_Dependency_injection.csproj", "Aula_Dependency_injection/"]
RUN dotnet restore "Aula_Dependency_injection/Aula_Dependency_injection.csproj"
COPY . .
WORKDIR "/src/Aula_Dependency_injection"
RUN dotnet build "Aula_Dependency_injection.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aula_Dependency_injection.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aula_Dependency_injection.dll"]
