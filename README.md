# User Management System with MediatR and ASP.NET Core

This is a **User Management System** built with **ASP.NET Core** and the **MediatR** library. The project demonstrates how to implement the **Mediator pattern** in an API application, separating the business logic from the controllers and providing cleaner, more maintainable code.

## Features

- **Create a User**: Adds a new user to the system.
- **Get User by ID**: Retrieves a user by their unique identifier.
- **Update User**: Updates the details of an existing user.
- **Delete User**: Removes a user from the system.
- **MediatR Implementation**: Uses the Mediator pattern to handle requests and responses in a decoupled way.

## Technologies

- **ASP.NET Core**: A modern framework for building web applications.
- **MediatR**: A library that implements the Mediator pattern to handle requests and responses in a decoupled way.
- **Entity Framework Core (EF Core)**: ORM for accessing and manipulating the database.
- **SQL Server**: Database for persisting user data.

## Project Structure

The project follows a clean architecture pattern and uses MediatR to decouple the controllers from business logic.

1. **Controllers**: Handle HTTP requests and responses.
2. **Commands**: Represent different actions in the system (e.g., Add, Update, Delete).
3. **Command Handlers**: Contain the business logic for each action.
4. **Repositories**: Interface to the database for performing CRUD operations.

## Endpoints

### 1. **POST /api/users**

Creates a new user.

**Request Body**:
```json
{
  "name": "John Doe",
  "email": "john.doe@example.com"
}
