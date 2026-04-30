# Cloud-Based ECG Management System
## This repository contains a sample/demo version of the project created for academic purposes. The actual project code is not included due to confidentiality. For any queries, please contact me at adityamaheshwari.0404@gmail.com .


## Project Structure

```
Cloud-Based-ECG-management-system/
├── frontend/          # React-based user interface
├── backend/           # ASP.NET Core REST API
├── database/          # SQL database schema
└── README.md          # This file
```

## Frontend (React)

Located in the `frontend/` directory.


### Setup
```bash
cd frontend
npm install
npm start
```

The application will run on `http://localhost:3000`

## Backend (ASP.NET Core)

Located in the `backend/` directory.

### Prerequisites
- .NET 6.0 or higher
- SQL Server (Local or Express)

### Setup
```bash
cd backend
dotnet restore
dotnet run
```

The API will run on `https://localhost:5001`

## Database

Located in the `database/` directory.

### Setup
1. Ensure SQL Server is running
2. Execute `schema.sql` to create the database and tables

```sql
-- In SQL Server Management Studio
USE master;
GO
-- Execute the script from database/schema.sql
```

## Features

- Patient management
- ECG record storage and retrieval
- Record analysis and notes

## Future Enhancements

- Advanced ECG analysis
- Reporting dashboard
- Mobile application

## License

MIT
