# OddsAPI

OddsAPI is an event-driven microservice that fetches and manages betting odds data. It provides real-time odds updates through a RESTful API and supports automated scheduling of odds updates.

## Features

- Event-driven architecture using RabbitMQ
- Real-time odds updates
- Redis caching for frequently accessed data
- PostgreSQL for persistent storage
- Prometheus metrics and Grafana dashboards
- Automated scheduling of odds updates using Quartz.NET
- Swagger API documentation

## Architecture

The application follows Clean Architecture principles and is divided into four main projects:

1. **OddsAPI.Core**: Contains domain entities, interfaces, and events
2. **OddsAPI.Infrastructure**: Implements data access and external service integrations
3. **OddsAPI.Application**: Contains business logic and services
4. **OddsAPI.Api**: Provides the REST API endpoints

## Prerequisites

- .NET 8.0 SDK
- Docker and Docker Compose (for support services)

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/rhyswdev/OddsAPI.git
   cd OddsAPI
   ```

2. Start the support services (PostgreSQL, Redis, RabbitMQ, Prometheus, Grafana):
   ```bash
   docker compose up -d
   ```

3. Build and run the API locally:
   ```bash
   cd src/OddsAPI.Api
   dotnet run
   ```

4. Access the services:
   - API: http://localhost:5000
   - Swagger UI: http://localhost:5000/swagger
   - RabbitMQ Management: http://localhost:15672 (username: oddsapi, password: oddsapi)
   - Prometheus: http://localhost:9090
   - Grafana: http://localhost:3000 (username: admin, password: admin)
   - pgAdmin: http://localhost:5050 (email: admin@admin.com, password: admin)

## API Endpoints

### Odds Management

- `POST /api/odds`: Create new odds
- `GET /api/odds/{id}`: Get odds by ID
- `GET /api/odds/event/{eventId}`: Get odds by event ID
- `PUT /api/odds/{id}`: Update odds
- `DELETE /api/odds/{id}`: Delete odds
- `GET /api/odds/active`: Get all active odds
- `POST /api/odds/schedule`: Schedule odds updates

## Event-Driven Architecture

The application uses RabbitMQ for event-driven communication. When odds are created or updated, an `OddsUpdatedEvent` is published, allowing other services (like HistoryAPI) to react to these changes.

## Monitoring

The application exposes Prometheus metrics at `/metrics`. Key metrics include:
- Total number of odds requests
- Request latencies
- Cache hit/miss ratios

## Development

### Building

```bash
dotnet build
```

### Running Tests

```bash
dotnet test
```

### Database Migrations

Migrations are automatically applied when the application starts. To create a new migration:

```bash
cd src/OddsAPI.Api
dotnet ef migrations add <MigrationName> --project ../OddsAPI.Infrastructure
```

## Configuration

Configuration is managed through `appsettings.json` and environment variables. Key settings include:

- Database connection string (default: Host=localhost;Database=oddsapi;Username=oddsapi;Password=oddsapi)
- Redis configuration (default: localhost:6379)
- RabbitMQ settings (default: localhost:5672)
- Prometheus metrics path

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is licensed under the MIT License. 