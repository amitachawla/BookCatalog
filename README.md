# BookCatalog

1) Open the solution file in Visual Studio.
2) Change connection string in the appsettings.json file (if needed)
3) Choose Catalog.Data project in package manager console and run the following command for migration and create database.
Tools –> NuGet Package Manager –> Package Manager Console
PM> Add-Migration MyFirstMigration
PM> Update-Database
4) Run the application.