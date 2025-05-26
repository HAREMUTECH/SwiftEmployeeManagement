# Employee Management System

A modular and maintainable .NET 9 Web API built using **Clean Architecture**, **Domain-Driven Design (DDD)**, and **Test-Driven Development (TDD)** principles.

---

## Architecture Overview

This solution follows **Clean Architecture** (a.k.a. Onion Architecture) to ensure **separation of concerns**, **testability**, and **scalability**.

### Architectural Layers

┌────────────────────────┐
│ Presentation │ ← SwiftEmployeeManagement.Api
└────────────────────────┘
↓
┌────────────────────────┐
│ Application │ ← SwiftEmployeeManagement.Application
└────────────────────────┘
↓
┌────────────────────────┐
│ Domain │ ← SwiftEmployeeManagement.Domain
└────────────────────────┘
↑
┌────────────────────────┐
│ Infrastructure │ ← SwiftEmployeeManagement.Infrastructure
│ Persistence (EF) │ ← SwiftEmployeeManagement.Infrastructure.Persistence
└────────────────────────┘

markdown
Copy
Edit

---

## 📁 Project Structure

### `/src`

| Project                             | Description                                                                 |
|-------------------------------------|-----------------------------------------------------------------------------|
| `SwiftEmployeeManagement.Api`              | ASP.NET Core Web API project (Presentation layer)                          |
| `SwiftEmployeeManagement.Application`      | Application layer (CQRS, interfaces, DTOs, business logic)                 |
| `SwiftEmployeeManagement.Domain`           | Domain models, value objects, entities, aggregates, and domain events      |
| `SwiftEmployeeManagement.Infrastructure`   | Infrastructure services (e.g., email, logging, authentication)             |

### `/tests`

| Project                             | Description                                                                 |
|-------------------------------------|-----------------------------------------------------------------------------|
| `SwiftEmployeeManagement.Tests.Unit`       | Unit tests using xUnit and Shouldly                                        |
| `SwiftEmployeeManagement.Tests.Integration`| Integration tests using Testcontainers for PostgreSQL                      |

---

## 🔧 Tech Stack

- **.NET 9**
- **PostgreSQL**
- **EF Core (Npgsql provider)**
- **Testcontainers** for integration testing
- **xUnit + Shouldly** for testing
- **Swagger / OpenAPI** for API docs
- **Docker & Docker Compose**
- **GitHub Actions** for CI

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com)
- [Docker](https://www.docker.com/)
- PostgreSQL (or use Docker)

### Run with Docker

```bash
docker-compose up --build
API will be available at: https://localhost:7094

Swagger UI: https://localhost:7094/swagger/index.html
