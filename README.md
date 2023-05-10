# CSharp-CRUD

This is a simple CRUD application built using C# and Microsoft SQLServer. The application allows users to perform basic Create, Read, Update, and Delete operations on a SQLServer database.

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository:

``git clone https://github.com/your-username/CSharp-CRUD.git


2. Open the project in Visual Studio.

3. Modify the database connection string in `Form1.cs` to point to your SQLServer database:

``csharp
SqlConnection conn = new SqlConnection(@"Data Source=<your-server-name>;Initial Catalog=<your-database-name>;Integrated Security=True");
