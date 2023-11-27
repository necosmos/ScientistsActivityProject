# ASP.NET with React Starter

This repository provides a starting point for building a web application using ASP.NET as the backend and React as the frontend.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [npm](https://www.npmjs.com/get-npm)

## Getting Started

```bash
git clone https://github.com/your-username/ScientistsActivity.git
cd ScientistsActivity
dotnet restore
cd ClientApp
npm install
dotnet build
dotnet run
```

## MSSQL Server Setup

If your application requires a MSSQL Server database, follow these steps to set it up:

1. **Install MSSQL Server:**

   Download and install [MSSQL Server](https://www.microsoft.com/sql-server/).

2. **Create a Database:**

   Open MSSQL Server Management Studio and create a new database for your application.

3. **Update Connection String:**

   In your ASP.NET project, locate the `appsettings.json` file and update the connection string with the appropriate details:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=<your-server>;Database=<your-database>;User=<your-username>;Password=<your-password>;"
     },
     // other settings...
   }

## Running Migrations

If you've made changes to your database models or if it's the first time setting up the database, follow these steps to run migrations:

1. **Open a Terminal:**

   Open a terminal or command prompt in the root directory of your ASP.NET project.

2. **Run Migrations:**

   Use the following commands to run migrations:

   ```bash
   dotnet ef database update

## Development

To run the frontend and backend separately for development:

1. **In the `ClientApp` directory:**

    ```bash
    npm start
    ```

    This will start the React development server at `http://localhost:3000`.

2. **In the project root directory:**

    ```bash
    dotnet run
    ```

    The backend will be accessible at `https://localhost:5001`.
