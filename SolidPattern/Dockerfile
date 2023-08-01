FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SolidPattern/SolidPattern.csproj", "SolidPattern/"]
RUN dotnet restore "SolidPattern/SolidPattern.csproj"
COPY . .
WORKDIR "/src/SolidPattern"
RUN dotnet build "SolidPattern.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SolidPattern.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolidPattern.dll"]
