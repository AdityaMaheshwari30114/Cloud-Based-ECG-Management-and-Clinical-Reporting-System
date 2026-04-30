# ECG Management System - Project Structure

## Overview
This is a full-stack ECG (Electrocardiogram) Management System with React frontend and ASP.NET Core backend, connected to a PostgreSQL database.

## Architecture

### Frontend (React)
- **Location:** `/frontend`
- **Port:** 3000
- **Tech Stack:** React 18, React Router, Axios
- **Key Features:**
  - User Login/Dashboard
  - Patient Management
  - Report Viewing
  - Device Management
  - Navigation Bar

### Backend (ASP.NET Core)
- **Location:** `/backend`
- **Port:** 5000
- **Tech Stack:** ASP.NET Core 7, C#
- **Key Features:**
  - Authentication API
  - Patient API
  - Report API
  - Device API
  - Service Layer Pattern

### Database (PostgreSQL)
- **Port:** 5432
- **Database:** ecg_db
- **Schema:**
  - ROLE: User roles
  - USERS: User accounts
  - PATIENT: Patient records
  - DEVICE: ECG devices
  - ECG_REPORT: Test reports
  - AUDIT_LOG: Activity logs

## File Structure

```
ecg-management-system/
├── frontend/
│   ├── public/
│   │   └── index.html
│   ├── src/
│   │   ├── components/
│   │   │   ├── Navigation.js
│   │   │   └── PatientList.js
│   │   ├── pages/
│   │   │   ├── Login.js
│   │   │   ├── Dashboard.js
│   │   │   ├── Patients.js
│   │   │   ├── Reports.js
│   │   │   └── Devices.js
│   │   ├── services/
│   │   │   └── api.js
│   │   ├── App.js
│   │   ├── index.js
│   │   └── index.css
│   ├── package.json
│   ├── Dockerfile
│   └── .gitignore
│
├── backend/
│   ├── Controllers/
│   │   ├── AuthController.cs
│   │   ├── PatientController.cs
│   │   ├── ReportController.cs
│   │   └── DeviceController.cs
│   ├── Models/
│   │   ├── User.cs
│   │   ├── Patient.cs
│   │   ├── Device.cs
│   │   ├── Report.cs
│   │   └── Role.cs
│   ├── Services/
│   │   ├── AuthService.cs
│   │   └── PatientService.cs
│   ├── Program.cs
│   ├── appsettings.json
│   ├── Dockerfile
│   └── .gitignore
│
├── database/
│   └── schema.sql
│
├── .env
├── docker-compose.yml
├── README.md
└── PROJECT_STRUCTURE.md
```

## Setup Instructions

### Prerequisites
- Docker and Docker Compose
- Node.js 18+ (for local frontend development)
- .NET SDK 7.0 (for local backend development)
- PostgreSQL (if running without Docker)

### Quick Start with Docker
```bash
# Start all services
docker-compose up -d

# Access the application
# Frontend: http://localhost:3000
# Backend API: http://localhost:5000
# Database: localhost:5432
```

### Local Development

#### Frontend
```bash
cd frontend
npm install
REACT_APP_API_URL=http://localhost:5000/api npm start
```

#### Backend
```bash
cd backend
dotnet restore
dotnet run
```

#### Database
```bash
# Using PostgreSQL locally
psql -U postgres -d ecg_db -f database/schema.sql
```

## API Endpoints

### Authentication
- `POST /api/auth/login` - User login

### Patients
- `GET /api/patient` - Get all patients
- `GET /api/patient/{id}` - Get specific patient
- `POST /api/patient` - Create patient
- `PUT /api/patient/{id}` - Update patient
- `DELETE /api/patient/{id}` - Delete patient

### Reports
- `GET /api/report` - Get all reports
- `GET /api/report/{id}` - Get specific report
- `POST /api/report` - Create report

### Devices
- `GET /api/device` - Get all devices
- `POST /api/device` - Create device
- `PUT /api/device/{id}` - Update device
- `DELETE /api/device/{id}` - Delete device

## Database Schema

### ROLE
```sql
role_id (Primary Key)
role_name VARCHAR(50)
```

### USERS
```sql
user_id (Primary Key)
name VARCHAR(100)
email VARCHAR(100)
role_id (Foreign Key)
```

### PATIENT
```sql
patient_id (Primary Key)
patient_name VARCHAR(100)
age INT
managed_by (Foreign Key - USERS)
```

### DEVICE
```sql
device_id (Primary Key)
device_name VARCHAR(100)
```

### ECG_REPORT
```sql
report_id (Primary Key)
patient_id (Foreign Key)
device_id (Foreign Key)
status VARCHAR(50)
report_date DATE
```

### AUDIT_LOG
```sql
log_id (Primary Key)
user_id (Foreign Key)
activity TEXT
```

## Development Guidelines

### Frontend
- Use functional components with hooks
- Centralize API calls in `/services`
- Component-based architecture
- Use React Router for navigation

### Backend
- Use dependency injection
- Implement service layer pattern
- Add proper error handling
- Use DTOs for data transfer

### Database
- Use transactions for critical operations
- Implement proper indexes
- Use foreign keys for referential integrity
- Keep audit logs for compliance

## Future Enhancements

- [ ] JWT Authentication
- [ ] Role-based Access Control (RBAC)
- [ ] Real-time ECG monitoring
- [ ] Report generation (PDF)
- [ ] Email notifications
- [ ] Unit and integration tests
- [ ] CI/CD pipeline
- [ ] Data encryption
- [ ] Admin dashboard
- [ ] Analytics and dashboards

## Contributing
Please follow the existing code style and create feature branches for new development.

## License
MIT License
