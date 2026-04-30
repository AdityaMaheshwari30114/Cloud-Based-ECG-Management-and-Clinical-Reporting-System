# ECG Management System - Setup Guide

## Prerequisites

Before you begin, ensure you have the following installed:

- **Docker Desktop** (includes Docker and Docker Compose)
  - Download: https://www.docker.com/products/docker-desktop
  - Or Docker + Docker Compose separately
  
- **Git** (for version control)
  - Download: https://git-scm.com/

- **For Local Development:**
  - **Node.js 18+** (Frontend)
  - **.NET SDK 7.0** (Backend)
  - **PostgreSQL 15** (Database)

## Installation Steps

### Option 1: Docker Compose (Recommended for Quick Start)

1. **Clone or navigate to the project directory**
   ```bash
   cd ecg-management-system
   ```

2. **Start all services**
   ```bash
   docker-compose up -d
   ```

3. **Wait for services to start** (30-60 seconds)
   - PostgreSQL: localhost:5432
   - Backend API: http://localhost:5000
   - Frontend: http://localhost:3000

4. **Access the application**
   - Open browser: http://localhost:3000
   - Login page should appear

5. **Stop services**
   ```bash
   docker-compose down
   ```

### Option 2: Local Development Setup

#### Frontend Setup

1. **Navigate to frontend directory**
   ```bash
   cd frontend
   ```

2. **Install dependencies**
   ```bash
   npm install
   ```

3. **Create .env file**
   ```bash
   echo "REACT_APP_API_URL=http://localhost:5000/api" > .env
   ```

4. **Start development server**
   ```bash
   npm start
   ```
   - Frontend will open at http://localhost:3000

#### Backend Setup

1. **Navigate to backend directory**
   ```bash
   cd backend
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Run migrations (if using Entity Framework)**
   ```bash
   dotnet ef database update
   ```

4. **Start the server**
   ```bash
   dotnet run
   ```
   - Backend API will be available at http://localhost:5000

#### Database Setup

1. **Create PostgreSQL database**
   ```sql
   CREATE DATABASE ecg_db;
   ```

2. **Run schema script**
   ```bash
   psql -U postgres -d ecg_db -f database/schema.sql
   ```

## Configuration

### Environment Variables

Create `.env` file in project root:
```
REACT_APP_API_URL=http://localhost:5000/api
DB_HOST=localhost
DB_USER=postgres
DB_PASSWORD=1234
DB_NAME=ecg_db
DB_PORT=5432
```

### Backend Configuration

Edit `backend/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=ecg_db;Username=postgres;Password=1234"
  }
}
```

## Troubleshooting

### Port Already in Use
- **Port 3000 (Frontend):** Kill process or change frontend port
- **Port 5000 (Backend):** Kill process or change backend port
- **Port 5432 (Database):** Change PostgreSQL port in docker-compose.yml

### Database Connection Issues
1. Verify PostgreSQL is running
2. Check connection string in appsettings.json
3. Ensure database exists: `psql -U postgres -l`
4. Verify credentials are correct

### CORS Errors
- Ensure backend CORS is configured
- Check that API URL in frontend matches backend URL

### Docker Issues
```bash
# Check container status
docker-compose ps

# View logs
docker-compose logs -f backend

# Force rebuild
docker-compose up --build -d
```

## API Testing

### Using Postman

1. **Import API endpoints**
   - Base URL: http://localhost:5000/api

2. **Test Login**
   - POST: http://localhost:5000/api/auth/login
   - Body (JSON):
   ```json
   {
     "email": "test@example.com",
     "password": "password123"
   }
   ```

3. **Test Get Patients**
   - GET: http://localhost:5000/api/patient

### Using cURL

```bash
# Login
curl -X POST http://localhost:5000/api/auth/login \
  -H "Content-Type: application/json" \
  -d '{"email":"test@example.com","password":"password123"}'

# Get Patients
curl http://localhost:5000/api/patient
```

## Development Workflow

1. **Create feature branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make changes** in frontend or backend

3. **Test locally**
   ```bash
   # Frontend
   npm test
   
   # Backend
   dotnet test
   ```

4. **Commit changes**
   ```bash
   git add .
   git commit -m "Add feature description"
   ```

5. **Push to repository**
   ```bash
   git push origin feature/your-feature-name
   ```

## Deployment

### Build Docker Images
```bash
docker-compose build
```

### Deploy to Production
```bash
docker-compose -f docker-compose.yml -f docker-compose.prod.yml up -d
```

## Performance Tips

- Use Docker for consistent development environment
- Implement database indexes for queries
- Cache API responses on frontend
- Use lazy loading for components
- Monitor database query performance

## Security Considerations

- [ ] Implement JWT authentication
- [ ] Use environment variables for secrets
- [ ] Enable HTTPS in production
- [ ] Validate all user inputs
- [ ] Implement rate limiting
- [ ] Use parameterized queries
- [ ] Keep dependencies updated

## Support

For issues or questions:
1. Check the troubleshooting section
2. Review logs: `docker-compose logs`
3. Open an issue on GitHub
4. Contact development team

## Additional Resources

- [React Documentation](https://react.dev)
- [ASP.NET Core Documentation](https://learn.microsoft.com/aspnet/core/)
- [PostgreSQL Documentation](https://www.postgresql.org/docs/)
- [Docker Documentation](https://docs.docker.com/)
- [Docker Compose Documentation](https://docs.docker.com/compose/)
