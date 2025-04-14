# 🛍️ MarketWorld

<div align="center">
    <h3>Modern eCommerce Platform</h3>
    <p>Built with .NET Core 8.0 following Clean Architecture and Domain-Driven Design principles</p>
</div>

<div align="center">
    <table>
        <tr>
            <td>
                <img src="https://github.com/user-attachments/assets/ff5890f0-068a-4258-9928-09dbb6ffddb1" alt="mainpage" width="400"/>
            </td>
            <td>
                <img src="https://github.com/user-attachments/assets/33b88057-a7bb-446e-b169-a4cd886b73f0" alt="product-list" width="400"/>
            </td>
        </tr>
        <tr>
            <td>
                <img src="https://github.com/user-attachments/assets/95c63d4c-8ad4-4ea0-9636-1df5e5fc0142" alt="category" width="400"/>
            </td>
            <td>
                <img src="https://github.com/user-attachments/assets/ec25bcd9-e68e-402e-8d91-21dd709e398b" alt="panel" width="400"/>
            </td>
        </tr>
    </table>
</div>

## ✨ Key Features

- **User Management**
  - Secure authentication and session management
  - User roles and permissions (Admin/User)
  - Profile management with personal information
  
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

### Frontend
- **Framework**: ASP.NET MVC
- **UI Framework**: Bootstrap
- **JavaScript**: jQuery
- **Styling**: Custom CSS with responsive design

### Security
- Session-based authentication
- Password security
- Role-based access control
- Secure payment processing

## 🏗️ Architecture

The solution follows Clean Architecture principles with the following layers:

```plaintext
MarketWorld/
├── MarketWorld.Domain/         # Core business logic and entities
├── MarketWorld.Application/    # Application business rules and interfaces
├── MarketWorld.Infrastructure/ # External concerns implementation
└── MarketWorld.Web/           # User interface and web application
```

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

## 📈 Current Status

The project is in active development with planned completion in Spring 2024. Current implementation status:

✅ User authentication and authorization  
✅ Product catalog management  
✅ Shopping cart functionality  
✅ Category and subcategory management  
✅ Basic order processing  
🔄 Payment integration (In Progress)  
🔄 Admin dashboard (In Progress)  
📅 Advanced analytics (Planned)  
📅 Customer reviews system (Planned)
