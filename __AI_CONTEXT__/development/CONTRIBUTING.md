# Contributing to OddsAPI

Thank you for your interest in contributing to OddsAPI! This document provides guidelines and instructions for contributing to the project.

## Code of Conduct

By participating in this project, you agree to abide by our [Code of Conduct](CODE_OF_CONDUCT.md).

## How to Contribute

### Reporting Bugs
1. Check if the bug has already been reported in the issues
2. If not, create a new issue with:
   - Clear description of the problem
   - Steps to reproduce
   - Expected behavior
   - Actual behavior
   - Environment details
   - Screenshots if applicable

### Suggesting Enhancements
1. Check if the enhancement has been suggested
2. Create a new issue with:
   - Clear description of the feature
   - Use cases and benefits
   - Implementation suggestions
   - Screenshots/mockups if applicable

### Pull Requests
1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Write/update tests
5. Update documentation
6. Submit a pull request

## Development Setup

### Prerequisites
- .NET 7.0 SDK or later
- PostgreSQL 14+
- Redis 6+
- RabbitMQ 3.8+
- Docker and Docker Compose

### Local Setup
1. Fork and clone the repository
2. Set up development environment:
   ```bash
   dotnet restore
   dotnet build
   ```
3. Configure local settings:
   ```bash
   cp appsettings.Development.json.example appsettings.Development.json
   ```
4. Start required services:
   ```bash
   docker-compose up -d
   ```
5. Run migrations:
   ```bash
   dotnet ef database update
   ```

## Code Style

### C# Style Guide
- Follow Microsoft C# coding conventions
- Use meaningful variable names
- Keep methods focused and small
- Add XML documentation for public APIs
- Use async/await for I/O operations

### Commit Messages
Follow the conventional commits format:
```
<type>(<scope>): <description>

[optional body]

[optional footer]
```

Types:
- feat: New feature
- fix: Bug fix
- docs: Documentation
- style: Formatting
- refactor: Code restructuring
- test: Adding tests
- chore: Maintenance

## Testing

### Unit Tests
- Write tests for new features
- Maintain existing tests
- Use xUnit
- Mock external dependencies
- Test edge cases

### Integration Tests
- Test API endpoints
- Test database operations
- Test external service integration
- Test background jobs

## Documentation

### Code Documentation
- Document public APIs
- Include usage examples
- Document complex algorithms
- Keep documentation up to date

### API Documentation
- Update OpenAPI specs
- Include request/response examples
- Document error scenarios
- Update integration guides

## Review Process

### Pull Request Review
1. Ensure all checks pass
2. Address review comments
3. Update documentation
4. Add tests if needed
5. Squash commits if requested

### Code Review Guidelines
- Check code style
- Verify test coverage
- Review documentation
- Test functionality
- Check performance impact

## Release Process

### Versioning
- Follow semantic versioning
- Update changelog
- Tag releases
- Update documentation

### Deployment
- Test in staging
- Monitor deployment
- Verify functionality
- Update documentation

## Getting Help

### Questions
- Check documentation
- Search issues
- Ask in discussions
- Contact maintainers

### Support
- Create detailed issues
- Provide reproduction steps
- Include environment details
- Share error messages

## Recognition

### Contributors
- Listed in CONTRIBUTORS.md
- Mentioned in release notes
- Invited to maintainer meetings
- Given commit access (if appropriate)

## License

By contributing, you agree that your contributions will be licensed under the project's [LICENSE](LICENSE) file. 