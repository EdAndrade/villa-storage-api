# MagicVilla API

This is .NET Core Web API for managing villa properties, created to refresh my memory about C# and .NET tools.
This RESTful API provides endpoints for creating, reading, updating, and deleting villa listings.

## Features
- CRUD operations for villa properties
- SQL Server database integration using Entity Framework Core
- Swagger/OpenAPI documentation
- JSON and XML response format support
- Proper HTTP status code responses
- Patch operations support for partial updates

## Technologies Used
- .NET Core
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI
- Newtonsoft.Json
- JsonPatch for partial updates
- Serilog for logs

## Setup
1. Clone the repository
2. Update the connection string in appsettings.json
3. Run Entity Framework migrations
4. Launch the application
5. Access Swagger UI at /swagger for API documentation

## Prerequisites
- .NET Core SDK (net8.0 is used)
- SQL Server
- Visual Studio or preferred IDE
