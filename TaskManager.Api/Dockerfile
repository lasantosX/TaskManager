FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-noble AS build
WORKDIR /src

COPY ["TaskManager.Api/TaskManager.Api.csproj", "TaskManager.Api/"]
COPY ["TaskManager.Business/TaskManager.Business.csproj", "TaskManager.Business/"]
COPY ["TaskManager.Data/TaskManager.Data.csproj", "TaskManager.Data/"]
COPY ["TaskManager.Domain/TaskManager.Domain.csproj", "TaskManager.Domain/"]

RUN dotnet restore "TaskManager.Api/TaskManager.Api.csproj"

COPY . .

WORKDIR "/src/TaskManager.Api"
RUN dotnet publish "TaskManager.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskManager.Api.dll"]