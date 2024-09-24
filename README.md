# MDR-NetCore-WebApi
This is a .NET Core Web API project built using GraphQL in combination with MediatR for handling domain events and queries. 
The solution is structured to demonstrate clean architecture principles and modular organization across several layers, 
including API, Application, Core, Infrastructure, and Presentation.

## Features
* GraphQL API: Built using HotChocolate for defining and executing GraphQL queries.
* MediatR: Implements CQRS pattern for handling requests and commands.
* Modular Architecture: Clear separation of concerns across layers.

## Project Structure
* BookWebApp.API: Hosts the GraphQL server.
* BookWebApp.Application: Handles business logic, including MediatR commands and queries.
* BookWebApp.Core: Contains domain models and interfaces.
* BookWebApp.Infrastructure: Manages database interactions (EF Core) and repository pattern.
* BookWebApp.Presentation: Contains GraphQL queries and mutations.

## Setup
Clone the repository:
```bash
$ git clone https://github.com/perasd9/MDR-NetCore-WebApi
```
Configure the connection string in appsettings.json.
Run migrations to set up the database:
```bash
$ dotnet ef database update
```
Run the application
```bash
$ dotnet run
```

## Usage
GraphQL Endpoints

Access the GraphQL playground at /graphql and explore queries like fetching books or managing records.
Example Query
```bash
{
  books {
    id
    title
    author
  }
}
```
