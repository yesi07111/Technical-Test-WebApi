# Weather Forecast API

A sophisticated Web API that integrates with an external weather service to provide current weather forecasts for global locations. Built using Domain-Driven Design (DDD) principles and Clean Architecture patterns.

## 🚀 Features

- **Real-time Weather Data**: Fetch current weather information for any global location
- **Historical Data**: Query and filter past weather forecasts
- **Robust Data Persistence**: Store weather forecasts using PostgreSQL
- **Clean Architecture**: Implemented using DDD principles
- **Modern Framework**: Built with .NET and Entity Framework
- **API Documentation**: Swagger integration for easy API testing and documentation

## 🏗️ Architecture

The project follows Clean Architecture and DDD principles, organized into the following layers:

### Domain Layer
- Contains enterprise business rules and entities
- Location of core business logic
- Includes base entities and weather-related domain models

### Application Layer
- Contains business rules specific to the application
- Implements CQRS pattern with Commands and Queries
- Defines interfaces for external services and repositories
- Houses DTOs and configuration models

### Infrastructure Layer
- Implements persistence using PostgreSQL
- Contains concrete implementations of repositories
- Manages external API communications
- Handles database contexts and migrations

### WebAPI Layer
- Exposes REST endpoints using FastEndpoints
- Manages API configuration and setup
- Handles HTTP requests and responses

## 🔧 Setup

1. Ensure you have .NET SDK installed
2. Configure your PostgreSQL connection string in appsettings.json
3. Configure your Weather API credentials in appsettings.json
4. Run database migrations:
```bash
dotnet ef database update
```

## 🚦 API Endpoints

### GET /api/get_forecast
Retrieves current weather forecast for a specified location.

**Query Parameters:**
- `location`: Name of the location (required)

### GET /api/get_requests
Retrieves historical weather forecasts with optional filters.

**Query Parameters:**
- `minDate`: Minimum date filter
- `maxDate`: Maximum date filter
- `minTempC`: Minimum temperature in Celsius
- `maxTempC`: Maximum temperature in Celsius
- `minHumidity`: Minimum humidity percentage
- `maxHumidity`: Maximum humidity percentage
- `regionName`: Filter by region name
- `conditionName`: Filter by weather condition

## 🛠️ Technologies

- **.NET**: Core framework
- **PostgreSQL**: Database
- **Entity Framework Core**: ORM
- **FastEndpoints**: Endpoint handling
- **FluentValidation**: Request validation
- **Swagger**: API documentation

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details
