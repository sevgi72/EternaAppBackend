# EternaApp

EternaApp is an ASP.NET Core MVC application targeting .NET 8.

## Technology Stack
- **Framework:** ASP.NET Core (.NET 8)
- **Architecture:** Model-View-Controller (MVC)
- **Database Access:** Entity Framework Core
- **Database:** SQL Server

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (or SQL Server Express / LocalDB for local development)

## Getting Started

1. **Clone the repository (if you haven't already):**
   ```bash
   git clone https://github.com/sevgi72/EternaAppBackend.git
   ```

2. **Navigate to the project directory:**
   ```bash
   cd EternaApp
   ```

3. **Database Configuration:**
   Open `EternaApp/appsettings.json` and ensure the `DefaultConnection` connection string points to your SQL Server instance.

4. **Apply Database Migrations:**
   Run the following command to create the database schema:
   ```bash
   dotnet ef database update --project EternaApp
   ```

5. **Run the Application:**
   ```bash
   dotnet run --project EternaApp
   ```

6. **Access the App:**
   Open your browser and navigate to the application URL provided in the console output (usually `http://localhost:5000` or `https://localhost:5001`).

## Project Structure
- `Controllers/` - Handles incoming HTTP requests and connects models to views.
- `Models/` & `Data/` - Contains domain models and the Entity Framework data context (`EternaAppDbContext`).
- `Views/` - Contains Razor views (`.cshtml` files) that render the user interface.
- `wwwroot/` - Stores static files (CSS, JavaScript, images).
