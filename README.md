# HNG Stage 1: Minimal API

This project is a minimal API built with C# and .NET 9.0 for HNG Stage 1 DevOps task.

## Description
A simple REST API that provides basic information about the API status, health, and developer details. It is designed to be lightweight and fast, responding within 500ms.

## Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## How to Run Locally

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/HngStageOne.git
   cd HngStageOne
   ```

2. **Run the project:**
   ```bash
   dotnet run
   ```
   The API will be available at `http://localhost:5000` (depending on your local configuration).

## API Endpoints

### 1. Root Endpoint
- **URL:** `/`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "message": "API is running"
  }
  ```

### 2. Health Check
- **URL:** `/health`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "message": "healthy"
  }
  ```

### 3. Developer Info
- **URL:** `/me`
- **Method:** `GET`
- **Response:**
  ```json
  {
    "name": "Kehinde Jejelaye",
    "email": "kehindejejelaye@gmail.com",
    "github": "https://github.com/kehindejejelaye"
  }
  ```

