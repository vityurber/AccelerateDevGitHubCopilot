# Library App

## Description
The Library App is a console-based application for managing a library system. It allows users to search for patrons, view their details, manage book loans, and perform other library-related operations. The application is built using .NET 8.0 and follows a modular architecture with separate layers for application logic, data access, and infrastructure.

## Project Structure
- `AccelerateDevGitHubCopilot.sln` - Solution file for the project.
- `README.md` - Documentation for the project.
- `src/`
  - `Library.ApplicationCore/`
    - `Entities/` - Core domain entities such as `Patron`, `Loan`, `Book`, etc.
    - `Enums/` - Enumerations used across the application.
    - `Interfaces/` - Interfaces for repositories and services.
    - `Services/` - Business logic services like `ILoanService` and `IPatronService`.
    - `Library.ApplicationCore.csproj` - Project file for the core application logic.
  - `Library.Console/`
    - `appSettings.json` - Configuration file for the console application.
    - `CommonActions.cs` - Defines common user actions in the console app.
    - `ConsoleApp.cs` - Main application class for managing the console interface.
    - `ConsoleState.cs` - Enum for tracking the state of the console application.
    - `Library.Console.csproj` - Project file for the console application.
    - `Json/` - Directory for storing JSON data files.
    - `Program.cs` - Entry point for the console application.
  - `Library.Infrastructure/`
    - `Data/` - Data access classes like `JsonPatronRepository` and `JsonLoanRepository`.
    - `Library.Infrastructure.csproj` - Project file for the infrastructure layer.
- `tests/`
  - `UnitTests/` - Unit tests for the application.

## Key Classes and Interfaces
### Core Entities
- `Patron` - Represents a library patron.
- `Loan` - Represents a book loan.
- `Book` - Represents a book in the library.
- `BookItem` - Represents a specific copy of a book.

### Interfaces
- `IPatronRepository` - Interface for patron data access.
- `ILoanRepository` - Interface for loan data access.
- `ILoanService` - Interface for loan-related business logic.
- `IPatronService` - Interface for patron-related business logic.

### Key Classes
- `ConsoleApp` - Main class for managing the console application.
- `JsonPatronRepository` - Implementation of `IPatronRepository` using JSON storage.
- `JsonLoanRepository` - Implementation of `ILoanRepository` using JSON storage.
- `JsonData` - Handles loading and saving JSON data files.

## Usage
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```bash
   cd AccelerateDevGitHubCopilot
   ```
3. Build the solution:
   ```bash
   dotnet build
   ```
4. Run the console application:
   ```bash
   dotnet run --project src/Library.Console/Library.Console.csproj
   ```

## License
This project is licensed under the MIT License. See the LICENSE file for details.

