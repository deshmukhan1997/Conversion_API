# ConversionAPI – Unit Converter

A RESTful Web API built using ASP.NET Core 8 to convert numerical values between different units of measurement.

## 🚀 Features

- Convert length units: Meters, Feet, Kilometers, and Miles.
- Convert temperature units: Celsius and Fahrenheit.
- Convert weight units: Kilograms and Pounds.
- RESTful API using HTTP POST.
- Clean Architecture with separate layers.
- Dependency Injection for services and conversion providers.
- Input validation and error handling.
- Swagger UI for API testing.
- Extensible design for adding new conversion types.

Technologies Used

- C#
- ASP.NET Core Web API
- .NET 8
- Clean Architecture
- Dependency Injection
- Swagger / OpenAPI
- Visual Studio


Supported Conversions

| Category | From | To |
|---|---|---|
| Length | Meters | Feet |
| Length | Kilometers | Miles |
| Temperature | Celsius | Fahrenheit |
| Temperature | Fahrenheit | Celsius |
| Weight | Kilograms | Pounds |
| Weight | Pounds | Kilograms |

Conversions within the same unit are also supported.



### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/YOUR_USERNAME/ConversionAPI.git
   ```

2. Navigate to the project directory:

   ```bash
   cd ConversionAPI
   ```

3. Restore NuGet packages:

   ```bash
   dotnet restore
   ```

4. Build the solution:

   ```bash
   dotnet build
   ```

5. Run the API project:

   ```bash
   dotnet run --project ConversionAPI.API
   ```

6. Open the Swagger UI using the HTTPS or HTTP URL displayed in the terminal, followed by `/swagger`.

## 🔗 API Endpoint

**HTTP Method:** `POST`

**Endpoint:** `/api/UnitConversion`

** Sample Request – Meters to Feet

```json
{
  "value": 10,
  "fromUnit": "meters",
  "toUnit": "feet"
}
```

** Sample Response

```json
{
  "originalValue": 10,
  "fromUnit": "meters",
  "convertedValue": 32.808399,
  "toUnit": "feet"
}
```

** Sample Request – Celsius to Fahrenheit

```json
{
  "value": 37,
  "fromUnit": "C",
  "toUnit": "F"
}
```

** Sample Response

```json
{
  "originalValue": 37,
  "fromUnit": "C",
  "convertedValue": 98.6,
  "toUnit": "F"
}
```

** Error Handling

Unsupported conversions return HTTP `400 Bad Request`.

Example:

```json
{
  "error": "Conversion from 'meters' to 'kg' is not supported."
}
```

** 🧩 Design Principles

- Separation of concerns
- Dependency Inversion through interfaces
- Dependency Injection
- Provider-based extensibility
- Reusable application services

** 🔮 Future Enhancements

- Add volume, area, and speed conversions.
- Add unit tests using xUnit.
- Add centralized exception handling.
- Add structured logging.
- Add CI/CD using GitHub Actions.
- Add API versioning and request validation.

## 👨‍💻 Author

**Aniket Deshmukh**

.NET Developer | C# | ASP.NET Core Web API | SQL Server | Azure

