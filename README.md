# Bicycle Rental Tracking System

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![WinForms](https://img.shields.io/badge/Windows_Forms-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![SQL Server](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

A FullStack C# WinForms application for managing bicycle rental operations with a multi-layered architecture and client-server communication.

## Key Features

- **Comprehensive Rental Management**: Track Bicycles, Rental Locations, Business Partners, and Rental Transactions

- **Structured Architecture**: Clear separation of concerns with Domain, Repository, ApplicationLogic, Common, DatabaseBroker, UI, Server and ServerOperations layers
- **Client-Server Model**: Network communication between Client UI and Server components
- **CRUD Operations**: Full Create, Read, Update and Delete functionalities for all business entities
- **Transaction Support**: Database operations with Commit/Rollback capability

## Architecture Overview

The system follows a layered architecture with clear separation of concerns:

### Key Architectural Components

1. **Domain Layer**  
   - Entity classes (`Iznajmljivanje`, `PoslovniPartner`, `StavkaIznajmljivanja`...)  
   - Implements `IDomainObject` for consistent data access  

2. **Repository Layer**  
   - Generic `GenericDbRepository` handles all database operations  
   - Implements repository pattern for data access abstraction  

3. **System Operations**  
   - Business logic encapsulated in `SystemOperationBase` classes  
   - Transaction management with begin/commit/rollback  

4. **Client-Server Communication**  
   - Custom TCP protocol with JSON serialization  
   - `CommunicationHelper` class handles message passing  
   - Asynchronous operations with proper error handling  

5. **UI Layer**  
   - WinForms with controller pattern (`IznajmljivanjaController`...)  
   - Data binding with validation  
   - User control components for modular UI  

## Technical Highlights

- **Generic Repository Pattern**: Single repository class handles all entity types through `IDomainObject` interface  
- **Custom Communication Protocol**: Lightweight TCP-based protocol with JSON serialization  
- **Transaction Management**: Database operations wrapped in transactions with proper error handling  
- **Validation**: Client-side and Database-side validation with visual feedback  
- **Separation of Concerns**: Clear division between UI, business logic, and data access  



### Architecture Diagram

![Architecture Diagram](screenshots/architecture%20diagram.png)
*High-level system architecture showing layered components and interactions.*

### Database Schema Diagram

![Database Schema](screenshots/database%20schema.png)
*Diagram illustrating the database tables and their relationships.*

### User Interface

![User Interface](screenshots/user%20interface%201.png)

![User Interface](screenshots/user%20interface%202.png)

![User Interface](screenshots/user%20interface%203.png)

![User Interface](screenshots/user%20interface%204.png)
*Sample screenshots of the main client application interface.*


## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or later  
- Microsoft SQL Server  
- Visual Studio 2019+  

### Installation

1. Clone the repository  
2. Restore NuGet packages  
3. Configure database connection in `Broker.cs`  
4. Run database scripts to create schema  
5. Build and run both server and client projects  

## Usage

1. Start the server application  
2. Launch the client application  
3. Authenticate with valid credentials  
4. Use the menu to navigate between different management sections  
5. Perform CRUD operations as needed  


