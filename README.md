# 🚗 WebApiCarBrands

WebApiCarBrands is a .NET 9 API designed using **Clean Architecture** and **Domain-Driven Design (DDD)**. It provides CRUD operations for managing car brands, using **PostgreSQL** as the database and **Docker Compose** for containerized deployment.

---

## 🛠️ Technologies Used
- **.NET 9**
- **C#**
- **Entity Framework Core**
- **PostgreSQL**
- **Docker & Docker Compose**
- **Clean Architecture**
- **Unit Testing with xUnit**

---

## 📦 Setup & Installation

### 1️⃣ Clone the repository:
```sh
git clone https://github.com/CristhiamV7/net-api.git
cd WebApiCarBrands
```

### 2️⃣ Configure environment variables:
Create a `.env` file in the project root and add:
```sh
POSTGRES_USER=postgres
POSTGRES_PASSWORD=mysecretpassword
POSTGRES_DB=CarBrandsDB
DB_HOST=db
DB_PORT=5432
```

### 3️⃣ Set the connection string in `appsettings.json`:
Ensure the connection string in `appsettings.json` matches the values set in the `.env` file:
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=db;Port=5432;Database=carbrands_db;Username=your_username;Password=your_password"
}
```
> **Note:** Replace `your_username` and `your_password` with the credentials from the `.env` file.

### 4️⃣ Build and run with Docker:
```sh
docker-compose up --build
```

### 5️⃣ Apply Migrations
Before running the application, apply the Entity Framework Core migrations in Package Manager console:
```sh
Update-Database
```
Or use cmd
```sh
dotnet ef database update
```
This ensures the database schema is correctly set up.

The API will be available at:  
👉 `http://localhost:8080`

---

## 🏗️ Project Structure
```
📂 WebApiCarBrands
 ┣ 📂 WebApiCarBrands.Application   # Application layer (Use Cases, DTOs)
 ┣ 📂 WebApiCarBrands.Domain        # Entities & Business Rules
 ┣ 📂 WebApiCarBrands.Infrastructure # EF Core & Repositories
 ┣ 📂 WebApiCarBrands.Tests          # Unit Tests
 ┣ 📂 WebApiCarBrands                # API (Controllers, Middleware)
 ┣ 📜 Dockerfile                     # Docker build configuration
 ┣ 📜 docker-compose.yml              # Docker Compose configuration
 ┣ 📜 README.md                      # Project documentation
```

---

## ⚙️ Running Migrations
If you update the database schema, apply migrations manually:

```sh
docker exec -it webapicarbrands-api dotnet ef database update
```

---

## 📌 API Endpoints

| Method | Endpoint          | Description                     |
|--------|------------------|---------------------------------|
| GET    | `/api/carbrand`  | Get all car brands             |
| GET    | `/api/carbrand/{id}` | Get a specific car brand  |
| POST   | `/api/carbrand`  | Add a new car brand            |
| PUT    | `/api/carbrand/{id}` | Update a car brand      |
| DELETE | `/api/carbrand/{id}` | Delete a car brand      |

---

## 🧪 Running Unit Tests
Run the following command to execute unit tests:
```sh
dotnet test
```

---

## 🚀 Deployment
For production deployment, update the `docker-compose.override.yml` file and run:
```sh
docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build -d
```

---

## 🙌 Contributors
- **Cristhiam Valle**

