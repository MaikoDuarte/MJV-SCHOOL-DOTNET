FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["mjv-aula-14/mjv-aula-14.csproj", "mjv-aula-14/"]
RUN dotnet restore "mjv-aula-14/mjv-aula-14.csproj"
COPY . .
WORKDIR "/src/mjv-aula-14"
RUN dotnet build "mjv-aula-14.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "mjv-aula-14.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mjv-aula-14.dll"]
