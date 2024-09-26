# API Versioning Demo Project - .NET Core Web API

This project demonstrates how to implement API versioning in a .NET Core Web API. API versioning is essential for managing changes in APIs over time without breaking existing clients. In this project, we explore three common ways to specify API versions:

- **Via URL** 
- **Via HTTP Header**
- **Via Content-Type**
---
## Features

- **API Versioning**: You can specify API versions in the URL, request headers, or content type.
- **Multiple Versions**: Support for v1, v2, etc.
- **Extensibility**: Easily scalable for additional versions and versioning strategies.
---
## How to Use

### 1. Via URL Versioning
Clients can specify the API version as part of the URL.

Example:
 > https://localhost:5209/api/`v1`/WeatherForecast

 > https://localhost:5209/api/`v2`/WeatherForecast

### 2. Via HTTP Header Versioning
Clients can specify the API version in the request headers.

Example:
**`GET /api/WeatherForecast HTTP/1.1
Host: localhost:5209
x-api-version: 1.0`**

### 3. Via Content-Type Versioning (Media Type Versioning)
Clients can specify the API version using the Accept header with a custom content type.

Example:

---
## Installation
**Clone the repository:**

> **git clone https://github.com/Eslamshaban176/APIVersioningDemo.git**
---
**Navigate to the project directory:**
> **cd apiversioning-demo**
---
## Install dependencies:

>`dotnet restore`
---
## Run the project

>`dotnet run`

---
## How to Test
You can test the API versioning using tools like Postman, Curl, or simply by using a web browser for URL-based versioning. Follow the usage examples provided above to test different versioning methods.

---
## Technologies Used
- **.NET Core 8.0 Web API**
- **ASP.NET Core API Versioning NuGet Package**