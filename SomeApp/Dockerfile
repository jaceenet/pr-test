FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SomeApp.csproj", "./"]
RUN dotnet restore "SomeApp.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "SomeApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SomeApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SomeApp.dll"]
