# OddsAPI Technical Documentation

## Overview

OddsAPI fetches odds from the Betfair API and automatically runs scheduled jobs to fetch odds for the most popular fixtures at a selectable frequency. Users needing odds for obscure sports can leverage AI to determine the relevant markets, which are then fetched and stored. These odds are refreshed only at the user's request unless multiple users require the same information. The system maintains a comprehensive history of odds changes, user interactions, and betting trends, providing rich historical data for analysis and insights. Users can register interest in various entities (teams, players, sports, etc.) to receive notifications and track odds changes for their preferred entities.

## Architecture

### Core Components

- **API Gateway**: Handles incoming requests, authentication, and authorization.  
- **Odds Fetcher Service**: Queries Betfair API for odds and manages scheduled fetching.  
- **AI Market Selector**: Determines relevant markets for obscure sports based on user preferences.  
- **Database Service**: Stores fetched odds, historical data, and user-specific information.  
- **Job Scheduler**: Automates fetching jobs based on defined frequencies.  
- **Cache Layer**: Uses Redis to reduce API calls by caching frequently accessed odds.  
- **Event Processor**: Handles asynchronous processing using a **message-based architecture** (RabbitMQ) to decouple services and optimize workload distribution.  
- **Popular Markets & Fixture Interest Tracking**: Logs user interactions to identify trending markets and fixtures.  
- **Logging & Monitoring**: Tracks API usage, job execution, and system health.  
- **User Preferences Storage**: Allows users to configure which markets they want odds for.  
- **Background Processing**: Uses Hangfire or Quartz.NET for scheduling jobs.  
- **Tracking Fixture Interest**: Stores user interest trends to prioritize fetching odds for popular events.  
- **Historical Data Management**: Maintains comprehensive history of odds changes, user interactions, and betting trends.
- **Entity Interest Management**: Handles user subscriptions to various entities (teams, players, sports, etc.).

### Data Management

- **Historical Data Storage**: 
  - Maintains complete history of odds changes with timestamps
  - Stores user interactions, AI prompts, and manual notes
  - Tracks betting trends and market movements
  - Preserves fixture metadata and outcomes
  - Records odds history with timestamps for each change
- **Data Retention**:
  - Active odds data is stored in Redis for fast access
  - Historical data is persisted in PostgreSQL
  - Data is automatically archived after fixture completion
  - Long-term storage for analysis and trend identification
- **Entity Interest System**:
  - Users can register interest in multiple entity types:
    - Sports
    - Teams
    - Players
    - Tournaments
    - Leagues
    - Venues
  - Interest registration includes:
    - User preferences
    - Notification settings
    - Priority levels
    - Custom tags and notes
  - System tracks:
    - User's interested entities
    - Related fixtures and markets
    - Historical odds changes for interested entities

### Database Schema

- **Odds Table**:
  - Current odds data (cached in Redis)
  - Basic odds information
  - Last update timestamp
  - Market and selection details
- **OddsHistory Table**:
  - Historical odds changes
  - Timestamp of each change
  - Previous and new odds values
  - Market context
  - Change reason (scheduled update, user request, etc.)
- **EntityInterest Table**:
  - User's interested entities
  - Entity type (sport, team, player, etc.)
  - Entity identifier
  - User preferences
  - Notification settings
- **Entity Table**:
  - Master list of all trackable entities
  - Entity type
  - Entity metadata
  - Relationships between entities

### Technology Stack

- **Backend:** Latest .NET Framework (ASP.NET Core)  
- **Database:**  
  - **SQL (PostgreSQL)** for structured data and historical records
  - **Redis** for caching frequently accessed data and ephemeral storage  
- **Authentication:** JWT (JSON Web Tokens)  
- **Messaging/Queue System:** RabbitMQ for **event-driven processing**, allowing asynchronous updates and better scalability.  
- **Background Processing:** Quartz.NET for job scheduling.

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
- **Historical Data Management:** Efficient storage and retrieval of historical data.
- **Entity Interest Processing:** Optimized queries for user's interested entities.

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