# MyCleanArchitecture
This project is made with C#.Net Core 9 and WebApi and Swagger.

Prerequisites:

.NET SDK: Make sure you have the .NET SDK installed. You can download it from the official Microsoft website.
IDE (Optional): While you can use a text editor and the command line, an IDE like Visual Studio or Visual Studio Code will make the process much easier.
Steps:

Create the Solution and Projects:

1.	Create new sln -n MyCleanArchitecture
2.	Create classlibrary Project with Name Core
3.	Create classlibrary Project with Name Infrastructure
4.	Create the WebApi project with name WebApi
   
Add project references:
1.	WebApi/WebApi.csproj reference Core/Core.csproj
2.	Infrastructure/Infrastructure.csproj reference Core/Core.csproj
3.	WebApi/WebApi.csproj reference Infrastructure/Infrastructure.csproj
Install Required NuGet Packages:

Navigate to the Infrastructure project directory: cd Infrastructure
Install Entity Framework Core and the in-memory provider:
1.	Package Microsoft.EntityFrameworkCore
2.	Package Microsoft.EntityFrameworkCore.InMemory

Install Entity framework core.
1.	dotnet add package Microsoft.EntityFrameworkCore
2.	Create the files and folders.
Run the application: dotnet run

Test the API:
1.	The console output will show the URL where the API is running (e.g., https://localhost:xxxx).
2.	You can use a tool like Postman, curl, or a web browser to test the API endpoints.
For example:

Create a product (POST):

URL: https://localhost:xxxx/api/products
Method: POST
Body (JSON):
JSON
{
    "name": "Test Product",
    "price": 19.99
}

Get all products (GET):
1.	URL: https://localhost:xxxx/api/products
2.	Method: GET

Database: 
The example uses an in-memory database for simplicity. For a real-world application, you would replace it with a persistent database like SQL Server, PostgreSQL, or MySQL. 

You would also need to change the connection string and add the appropriate database provider package.

Error Handling: The provided code is a basic example and lacks comprehensive error handling. You should add proper error handling and validation for production applications.

Dependency Injection:
 The Program.cs file configures dependency injection. You can expand on this to manage more complex dependencies.

Swagger/OpenAPI: The WebApi project includes Swagger/OpenAPI, which provides a UI for testing the API endpoints. You can access it by navigating to https://localhost:xxxx/swagger in your browser.

Project structure: The project structure is a good starting point, but you can adjust it to fit the specific needs of your application.
Security: The code doesn't implement any security measures. For production applications, you should add authentication and authorization


# Example usage:
structure_text = """
MyCleanArchitecture.sln
├── Core/
│   ├── Entities/
│   │   └── Product.cs
│   ├── UseCases/
│   │   ├── CreateProduct/
│   │   │   ├── CreateProductRequest.cs
│   │   │   ├── CreateProductResponse.cs
│   │   │   ├── ICreateProductUseCase.cs
│   │   │   └── CreateProductUseCase.cs
│   │   ├── GetProducts/
│   │   │   ├── GetProductsResponse.cs
│   │   │   ├── IGetProductsUseCase.cs
│   │   │   └── GetProductsUseCase.cs
│   │   └── Repositories/
│   │       └── IProductRepository.cs
├── Infrastructure/
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   └── SqlProductRepository.cs
├── WebApi/
│   ├── Controllers/
│   │   └── ProductsController.cs
│   ├── Models/
│   │   └── ProductDto.cs
│   ├── Program.cs
│   └── Startup.cs
└── MyCleanArchitecture.sln
