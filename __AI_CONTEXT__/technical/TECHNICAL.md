# OddsAPI Technical Documentation

## Overview

OddsAPI fetches odds from the Betfair API and automatically runs scheduled jobs to fetch odds for the most popular fixtures at a selectable frequency. Users needing odds for obscure sports can leverage AI to determine the relevant markets, which are then fetched and stored. These odds are refreshed only at the user's request unless multiple users require the same information. All updates become redundant after the fixture concludes, at which point the data is deleted.

## Architecture

### Core Components

- **API Gateway**: Handles incoming requests, authentication, and authorization.  
- **Odds Fetcher Service**: Queries Betfair API for odds and manages scheduled fetching.  
- **AI Market Selector**: Determines relevant markets for obscure sports based on user preferences.  
- **Database Service**: Stores fetched odds and user-specific data.  
- **Job Scheduler**: Automates fetching jobs based on defined frequencies.  
- **Cache Layer**: Uses Redis to reduce API calls by caching frequently accessed odds.  
- **Event Processor**: Handles asynchronous processing using a **message-based architecture** (RabbitMQ) to decouple services and optimize workload distribution.  
- **Popular Markets & Fixture Interest Tracking**: Logs user interactions to identify trending markets and fixtures.  
- **Logging & Monitoring**: Tracks API usage, job execution, and system health.  
- **User Preferences Storage**: Allows users to configure which markets they want odds for.  
- **Background Processing**: Uses Hangfire or Quartz.NET for scheduling jobs.  
- **Tracking Fixture Interest**: Stores user interest trends to prioritize fetching odds for popular events.  
- **Event-Driven Data Processing**: Publishes odds updates as events for other services like **HistoryAPI**.

### Integration with HistoryAPI

- **Historical Data Retention** will be handled by a separate **HistoryAPI**, responsible for storing and aggregating long-term betting data.  
- **OddsAPI will publish event messages** to notify **HistoryAPI** when new odds are fetched or updated.  
- **HistoryAPI will store** user-specific betting interactions, AI prompts, manual notes, and trends over extended periods.

### Technology Stack

- **Backend:** Latest .NET Framework (ASP.NET Core)  
- **Database:**  
  - **SQL (PostgreSQL)** for structured and relational data  
  - **Redis** for caching frequently accessed data and ephemeral storage  
- **Authentication:** JWT (JSON Web Tokens)  
- **Messaging/Queue System:** RabbitMQ for **event-driven processing**, allowing asynchronous updates and better scalability.  
- **Background Processing:** Hangfire or Quartz.NET for job scheduling.

## Development Guidelines

### Code Organization

- **Clean Architecture** to separate concerns and enhance maintainability.  
- **Domain-Driven Design (DDD)** to model real-world betting interactions effectively.  
- **SOLID Principles** to improve code maintainability.  
- **Test-Driven Development (TDD)** to ensure reliability.

### Performance Considerations

- **Caching Strategies:** Redis for storing frequently accessed odds.  
- **Rate Limiting:** Prevent excessive API calls using middleware.  
- **Resource Optimization:** Offload heavy computations to background jobs.  
- **Scalability Patterns:** Use microservices and containerization to scale efficiently.  
- **Event-Driven Processing:** Reduces synchronous dependencies, increasing efficiency.

### Security

- **Authentication & Authorization:** Secure endpoints with JWT.  
- **Data Encryption:** Encrypt sensitive data in transit (TLS) and at rest.  
- **API Security:** Implement rate limiting, IP whitelisting, and OAuth 2.0 if needed.

## Testing Strategy

- **Unit Tests:** Validate core functionality.  
- **Integration Tests:** Ensure API interactions work as expected.  
- **Performance Tests:** Benchmark API response times under load.  
- **Security Tests:** Detect vulnerabilities (e.g., OWASP Top 10 testing).

## Deployment

- **Containerization:** Use Docker for consistent deployments.  
- **CI/CD Pipeline:** Automate builds, tests, and deployments with GitHub Actions or Azure DevOps.  
- **Environment Configuration:** Separate dev, staging, and production settings.  
- **Monitoring & Logging:** Use Prometheus, Grafana, or New Relic to track system health and failures.  
- **Job Monitoring:** Ensure background tasks are executing correctly.