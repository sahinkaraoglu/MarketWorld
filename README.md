# 🛍️ MarketWorld

<div align="center">
    <h3>Modern eCommerce Platform</h3>
    <p>Built with .NET Core 8.0 following Clean Architecture and Domain-Driven Design principles</p>
</div>

<div align="center">
    <table>
        <tr>
            <td>
                <img src="https://github.com/user-attachments/assets/0c445bc6-6521-4861-a064-8a4fe02acfb6" alt="mainpage" width="400"/>
            </td>
            <td>
                <img src="https://github.com/user-attachments/assets/33b88057-a7bb-446e-b169-a4cd886b73f0" alt="product-list" width="400"/>
            </td>
        </tr>
        <tr>
            <td>
                <img src="https://github.com/user-attachments/assets/689b161c-c80a-452d-986d-5a25e718a61c" alt="category" width="400"/>
            </td>
            <td>
                <img src="https://github.com/user-attachments/assets/b7f0c94e-b6a4-4b08-bd97-1d18b9a9ac2a" alt="panel" width="400"/>
            </td>
        </tr>
    </table>
</div>

## ✨ Key Features

- **Advanced User Management**
  - OAuth2 and JWT-based authentication
  - Role-based access control (RBAC)
  - Comprehensive user profiles with preferences
  
- **Product Management**
  - Rich product catalog with categories and subcategories
  - Advanced product filtering and search
  - Product ratings and reviews
  - Dynamic pricing with discount support
  - Multiple product images support
  - Brand management
  
- **Shopping Experience**
  - Intuitive shopping cart functionality
  - Multiple shipping address support
  - Order tracking and history
  - Secure payment processing
  - Free shipping eligibility
  
- **Admin Dashboard**
  - Comprehensive product management
  - Category and subcategory management
  - Order processing and tracking
  - User management
  - Sales analytics and reporting

## ��️ Architecture

### Monolithic Application (Legacy)
The solution follows Clean Architecture principles with the following layers:

```plaintext
MarketWorld/
├── MarketWorld.Core/            # Core business logic and entities
├── MarketWorld.Application/     # Application business rules and interfaces
├── MarketWorld.Infrastructure/  # External concerns implementation
├── MarketWorld.API/             # RESTful API endpoints
└── MarketWorld.Web/             # MVC Web Application
```

### Microservices Architecture (Current)
Modern microservices-based architecture with API Gateway:

```plaintext
MarketWorld/
├── MarketWorld.Core/                    # Shared domain entities
├── MarketWorld.Application/             # Shared business logic
├── MarketWorld.Infrastructure/          # Shared infrastructure
├── MarketWorld.Web/                     # MVC Web Application
└── src/services/                        # Microservices
    ├── MarketWorld.Gateway/             # API Gateway (Ocelot)
    ├── MarketWorld.Identity.API/        # User Management Service
    ├── MarketWorld.Product.API/         # Product Catalog Service
    ├── MarketWorld.Order.API/           # Order Management Service
    ├── MarketWorld.Comment.API/         # Review & Rating Service
    └── MarketWorld.API/                 # Legacy API (Monolithic)
```

## 🚀 Microservices Overview

### 1. **MarketWorld.Identity.API** (Port: 7001)
**Purpose**: User authentication, authorization, and profile management
- **Endpoints**: `/identity/api/auth/*`
- **Features**:
  - User registration and login
  - JWT token generation
  - Role-based access control
  - User profile management
  - Address management

### 2. **MarketWorld.Product.API** (Port: 7005)
**Purpose**: Product catalog, categories, and brand management
- **Endpoints**: `/product/api/*`
- **Features**:
  - Product CRUD operations
  - Category and subcategory management
  - Brand management
  - Product search and filtering
  - Featured products and best sellers

### 3. **MarketWorld.Order.API** (Port: 7003)
**Purpose**: Order processing, cart management, and checkout
- **Endpoints**: `/order/api/*`
- **Features**:
  - Shopping cart operations
  - Order creation and management
  - Order status tracking
  - Checkout process
  - Order history

### 4. **MarketWorld.Comment.API** (Port: 7004)
**Purpose**: Product reviews, ratings, and comment system
- **Endpoints**: `/comment/api/*`
- **Features**:
  - Product reviews and ratings
  - Comment moderation
  - Review approval system
  - User feedback management

### 5. **MarketWorld.Gateway** (Port: 7000)
**Purpose**: API Gateway using Ocelot for routing and aggregation
- **Features**:
  - Centralized routing to microservices
  - Load balancing
  - Request aggregation
  - Single entry point for clients

## ��️ Technical Stack

### Backend
- **Framework**: .NET 8.0
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core 8.0
- **Architecture**: Clean Architecture + Microservices
- **API**: RESTful API endpoints
- **Authentication**: JWT with OAuth2
- **Object Mapping**: AutoMapper for DTO transformations
- **Caching**: Memory Cache for in-memory caching
- **API Gateway**: Ocelot
- **Containerization**: Docker & Docker Compose

### Frontend
- **Framework**: ASP.NET MVC
- **UI Framework**: Bootstrap
- **JavaScript**: jQuery
- **Styling**: Custom CSS with responsive design

### Security Features
- JWT-based authentication
- OAuth2 integration
- SQL injection prevention
- Secure payment processing (PCI compliant)
- Custom JWT Token Validation Middleware
- Role-based authorization across microservices

## �� API Endpoints

### API Gateway Routes
- **Identity Service**: `https://localhost:7000/identity/api/*`
- **Product Service**: `https://localhost:7000/product/api/*`
- **Order Service**: `https://localhost:7000/order/api/*`
- **Comment Service**: `https://localhost:7000/comment/api/*`

### Direct Service Access
- **Gateway**: `https://localhost:7000`
- **Identity**: `https://localhost:7001/swagger`
- **Product**: `https://localhost:7005/swagger`
- **Order**: `https://localhost:7003/swagger`
- **Comment**: `https://localhost:7004/swagger`

<div align="center">
    <img src="https://github.com/user-attachments/assets/a2ea920b-b166-4f4f-b2ef-c14ddbd3ee73" alt="api-endpoints" width="800"/>
</div>

## �� Docker & Containerization

### Docker Compose Services
```yaml
services:
  sqlserver:     # SQL Server Database
  gateway:       # API Gateway (Port 7000)
  identity:      # Identity Service (Port 7001)
  product:       # Product Service (Port 7005)
  order:         # Order Service (Port 7003)
  comment:       # Comment Service (Port 7004)
```

### Database Per Service Pattern
- **MarketWorld_Identity**: User and authentication data
- **MarketWorld_Product**: Product catalog and inventory
- **MarketWorld_Order**: Orders and cart data
- **MarketWorld_Comment**: Reviews and ratings

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server 2019 or later
- Docker Desktop
- Visual Studio 2022 or later

### Environment Setup

#### Option 1: Docker (Recommended)
```bash
# Clone the repository
git clone https://github.com/yourusername/MarketWorld.git
cd MarketWorld

# Start all services with Docker Compose
docker-compose up -d

# Access services
# Gateway: http://localhost:7000
# Identity: http://localhost:7001
# Product: http://localhost:7005
# Order: http://localhost:7003
# Comment: http://localhost:7004
```

#### Option 2: Local Development
```bash
# Clone the repository
git clone https://github.com/yourusername/MarketWorld.git
cd MarketWorld

# Update connection strings in appsettings.json files
# Run Entity Framework migrations for each service
# Start services individually
```

### Environment URLs

#### Microservices
- **API Gateway**: `https://localhost:7000`
- **Identity Service**: `https://localhost:7001/swagger`
- **Product Service**: `https://localhost:7005/swagger`
- **Order Service**: `https://localhost:7003/swagger`
- **Comment Service**: `https://localhost:7004/swagger`

#### Legacy Application
- **Web Application**: `https://localhost:7154`
- **Legacy API**: `https://localhost:7154/swagger`
- **Admin Dashboard**: `https://localhost:7154/admin`

## 📈 Project Status

### ✅ Completed Features
- **Monolithic Application**
  - User Authentication and Authorization
  - Product Catalog Management
  - Shopping Cart Functionality
  - Category and Subcategory Management
  - Basic Order Processing
  - Payment Integration
  - Admin Dashboard
  - Advanced Analytics
  - Customer Reviews System
  - Memory Cache Implementation

### ✅ Microservices Implementation
- **Identity Service**: Complete with JWT authentication
- **Product Service**: Full product management capabilities
- **Order Service**: Order processing and cart management
- **Comment Service**: Review and rating system
- **API Gateway**: Ocelot-based routing and aggregation
- **Docker Containerization**: All services containerized
- **Database Separation**: Independent databases per service

### 🔄 In Progress
- **Service Discovery**: Integration with Consul or Eureka
- **Message Queuing**: RabbitMQ or Azure Service Bus
- **Monitoring**: Health checks and metrics
- **Logging**: Centralized logging with Serilog
- **Testing**: Unit and integration tests for microservices

### 📋 Future Enhancements
- **Event Sourcing**: CQRS pattern implementation
- **Distributed Caching**: Redis integration
- **API Versioning**: Semantic versioning support
- **Rate Limiting**: API throttling and protection
- **Circuit Breaker**: Resilience patterns implementation

## 🧪 Testing

### Test Projects
- **MarketWorld.Tests**: Unit tests for core functionality
- **Integration Tests**: Service-to-service communication tests
- **API Tests**: Endpoint validation and performance tests

## 📚 Documentation

- **API Documentation**: Swagger/OpenAPI for all services
- **Architecture Diagrams**: System design and flow documentation
- **Deployment Guide**: Docker and production deployment
- **Development Guidelines**: Coding standards and best practices

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🆘 Support

For support and questions:
- Create an issue in the GitHub repository
- Contact the development team
- Check the documentation and wiki

---

<div align="center">
    <p><strong>MarketWorld</strong> - Modern eCommerce Platform with Microservices Architecture</p>
    <p>Built with ❤️ using .NET 8.0 and Clean Architecture principles</p>
</div>
