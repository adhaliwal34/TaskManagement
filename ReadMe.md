# Clean architecture example using .NET 10

```
TaskManagement/
├── src/
│   ├── TaskStream.Domain/                  # Innermost - Pure business
│   ├── TaskStream.Application/             # Use cases, DTOs, interfaces
│   ├── TaskStream.Infrastructure/          # Concrete implementations (EF, etc.)
│   └── TaskStream.Web/                     # MVC Project (Controllers, Views, wwwroot)
├── tests/
└── TaskManagement.slnx
```