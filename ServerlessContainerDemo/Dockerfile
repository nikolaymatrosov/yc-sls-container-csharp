FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ServerlessContainerDemo/ServerlessContainerDemo.csproj", "ServerlessContainerDemo/"]
RUN dotnet restore "ServerlessContainerDemo/ServerlessContainerDemo.csproj"
COPY . .
WORKDIR "/src/ServerlessContainerDemo"
RUN dotnet build "ServerlessContainerDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServerlessContainerDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServerlessContainerDemo.dll"]
