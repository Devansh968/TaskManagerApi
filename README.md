# TaskManagerApi

This is a simple Task Manager API built with ASP.NET Core and Entity Framework Core. It allows users to perform CRUD operations on tasks.

---

##  Setup Instructions

###  Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download) (or replace with your target version)
- SQL Server (localdb or full instance)

###  Installation Steps

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/TaskManagerApi.git
   cd TaskManagerApi
Restore dependencies:

bash
Copy
Edit
dotnet restore
Update the database:
Make sure the connection string in appsettings.json is correct, then run:

bash
Copy
Edit
dotnet ef database update
Run the API:

bash
Copy
Edit
dotnet run
The API should be available at: https://localhost:5001 or http://localhost:5000

 API Usage Examples
Get all tasks
http
Copy
Edit
GET /api/tasks
Get task by ID
http
Copy
Edit
GET /api/tasks/{id}
Create a new task
http
Copy
Edit
POST /api/tasks
Content-Type: application/json

{
  "title": "Buy groceries",
  "description": "Milk, Eggs, Bread",
  "dueDate": "2024-08-01T00:00:00",
  "isCompleted": false
}
Update an existing task
http
Copy
Edit
PUT /api/tasks/{id}
Content-Type: application/json

{
  "title": "Buy groceries and snacks",
  "description": "Milk, Eggs, Bread, Chips",
  "dueDate": "2024-08-02T00:00:00",
  "isCompleted": false
}
Delete a task
http
Copy
Edit
DELETE /api/tasks/{id}
 Known Limitations & Future Improvements
 No authentication or user roles (could be added with ASP.NET Identity or JWT).

 No input validation or error handling middleware.

 No front-end UI (a simple Razor or React frontend could be added).

⚙ Performance optimizations like pagination, filtering, and sorting not yet implemented.

 Tests are minimal; would benefit from full unit and integration test coverage.
