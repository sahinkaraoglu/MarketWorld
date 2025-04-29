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
  - Multi-factor authentication (MFA)
  - Role-based access control (RBAC)
  - Comprehensive user profiles with preferences
  - Social media integration
  
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

## 🛠️ Technical Stack

### Backend
- **Framework**: .NET 8.0
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core 8.0
- **Architecture**: Clean Architecture with Domain-Driven Design
- **API**: RESTful API endpoints
- **Authentication**: JWT with OAuth2

### Frontend
- **Framework**: ASP.NET MVC
- **UI Framework**: Bootstrap
- **JavaScript**: jQuery
- **Styling**: Custom CSS with responsive design

### Security Features
- JWT-based authentication
- OAuth2 integration
- SQL injection prevention
- Rate limiting
- Data encryption at rest
- Secure payment processing (PCI compliant)

## 🏗️ Architecture

The solution follows Clean Architecture principles with the following layers:

```plaintext
MarketWorld/
├── MarketWorld.Domain/         # Core business logic and entities
├── MarketWorld.Application/    # Application business rules and interfaces
├── MarketWorld.Infrastructure/ # External concerns implementation
├── MarketWorld.API/             # RESTful API endpoints
└── MarketWorld.Web/             # MVC Web Application
```

## 🔌 API Endpoints

<div align="center">
    <img src="https://github.com/user-attachments/assets/7fb9b272-3408-4657-9469-2d00dc82304a" alt="api-endpoints" width="800"/>
</div>

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server 2019 or later
- Visual Studio 2022 or later

### Environment Setup
1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Run Entity Framework migrations
4. Start the application

### Environment URLs
- Web Application: `https://localhost:7154`
- API Documentation: `https://localhost:7154/swagger`
- Admin Dashboard: `https://localhost:7154/admin`

## 📈 Project Status

✅ User Authentication and Authorization  
✅ Product Catalog Management  
✅ Shopping Cart Functionality  
✅ Category and Subcategory Management  
✅ Basic Order Processing  
✅ Payment Integration  
✅ Admin Dashboard  
✅ Advanced Analytics  
✅ Customer Reviews System  
