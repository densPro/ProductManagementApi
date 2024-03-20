# Product Management API

This project is a RESTful API built using ASP.NET Core 8.0 and Entity Framework Core 6.0. It provides a service to manage products. Here are the main features:

- Create, Read, Update and Delete (CRUD) operations for products.
- Swagger UI for API documentation.
- CORS policy to allow requests from any origin.
- Seed data for testing purposes.

## Getting Started

To run the API locally, follow these steps:

1. Install .NET 8.0 SDK from [here](https://dotnet.microsoft.com/download/dotnet/8.0).
2. Open the terminal and navigate to the project directory.
3. Run `dotnet restore` to restore the project dependencies.
4. Update the `appsettings.json` file with your SQL Server connection string.
5. Run `dotnet ef database update` to create the database.
6. Run `dotnet run` to start the API.
7. Open a browser and navigate to `http://localhost:5187/swagger` to see the Swagger UI.

## Usage

The API is self-documented using Swagger UI. You can explore the available endpoints, models, and make requests.

## Contributing

Contributions are welcome. Please open an issue or create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

