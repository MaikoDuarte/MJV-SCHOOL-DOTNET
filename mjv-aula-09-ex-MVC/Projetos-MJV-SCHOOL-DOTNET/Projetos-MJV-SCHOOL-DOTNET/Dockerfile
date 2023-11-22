FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Projetos-MJV-SCHOOL-DOTNET/Projetos-MJV-SCHOOL-DOTNET.csproj", "Projetos-MJV-SCHOOL-DOTNET/"]
RUN dotnet restore "Projetos-MJV-SCHOOL-DOTNET/Projetos-MJV-SCHOOL-DOTNET.csproj"
COPY . .
WORKDIR "/src/Projetos-MJV-SCHOOL-DOTNET"
RUN dotnet build "Projetos-MJV-SCHOOL-DOTNET.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Projetos-MJV-SCHOOL-DOTNET.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Projetos-MJV-SCHOOL-DOTNET.dll"]
