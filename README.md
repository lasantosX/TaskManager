# TaskManager API

Container-ready ASP.NET Core Web API built with layered architecture, EF Core, SQL Server, Swagger, and Docker Compose.

## Features

- Task CRUD foundation
- Layered architecture
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI
- Dockerfile
- Docker Compose
- SQL Server container
- Environment-based connection string

## Tech Stack

- ASP.NET Core 8
- C#
- Entity Framework Core
- SQL Server
- Docker
- Docker Compose
- Swagger

## Run with Docker

Build and run the API + SQL Server:

```bash
docker compose up --build

Open Swagger:

http://localhost:8080/swagger
Database

SQL Server runs in Docker on:

localhost,14333

Default database:

TaskManagerDb
Apply EF Migrations
dotnet ef database update --project TaskManager.Data --startup-project TaskManager.Api
API Endpoints
GET    /api/Tasks
GET    /api/Tasks/{id}
POST   /api/Tasks
Sample POST Body
{
  "title": "Create Docker setup",
  "description": "Containerize the API and SQL Server using Docker Compose."
}
Project Goal

This project demonstrates how to containerize an ASP.NET Core Web API with SQL Server using Docker and Docker Compose.
