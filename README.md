# MarketWorld 🛍️

.NET Core 8.0-based eCommerce platform.

<div align="center">
    <table>
        <tr>
            <td>
                <img src="https://github.com/user-attachments/assets/fe423e47-9134-44cf-bac5-6ebf7c5586fe" alt="mainpage" width="400"/>
            </td>
            <td>
                <img src="https://github.com/user-attachments/assets/b860ac86-d166-4e03-85dc-af936baa2bff" alt="product-list" width="400"/>
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

## Features

- **Clean Architecture**: Organized into Domain, Application, Infrastructure, and Web layers
- **Modern Tech Stack**: Built with .NET 8.0 and Entity Framework Core  
- **Secure Payments**: 256-bit SSL encryption for all transactions
- **User-Friendly Interface**: Responsive design with Bootstrap

## Technical Stack

- **Backend**: .NET 8.0
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core 8.0
- **Frontend**: 
  - ASP.NET MVC
  - Bootstrap
  - jQuery
  - Custom CSS

##  Architecture

The solution follows Clean Architecture principles with the following projects:
- `MarketWorld.Domain`: Core business logic and entities
- `MarketWorld.Application`: Application business rules and interfaces
- `MarketWorld.Infrastructure`: External concerns implementation
- `MarketWorld.Web`: User interface and web application

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 or later

## Environment URLs

- Web Application: `https://localhost:7154`

## Current Status

The project is in active development and scheduled for completion in Spring 2024. Key features being implemented:
- User authentication and authorization
- Product catalog management
- Shopping cart functionality
- Order processing
- Payment integration
- Admin dashboard
