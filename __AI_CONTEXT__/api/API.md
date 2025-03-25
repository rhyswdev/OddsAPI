# OddsAPI Documentation

## Overview
OddsAPI provides a comprehensive set of endpoints for accessing betting odds data from Betfair. The API is designed to be efficient, scalable, and easy to integrate with other BetFriend services.

## Authentication
All API requests require JWT authentication. Include the token in the Authorization header:
```
Authorization: Bearer <your_jwt_token>
```

## Base URL
```
https://api.betfriend.com/odds/v1
```

## Endpoints

### Odds Management

#### Get Odds for Fixture
```http
GET /fixtures/{fixtureId}/odds
```
Returns current odds for a specific fixture.

**Parameters:**
- `fixtureId` (path): Unique identifier for the fixture
- `markets` (query): Comma-separated list of market types to fetch
- `refresh` (query): Force refresh from Betfair API (optional)

**Response:**
```json
{
  "fixtureId": "string",
  "timestamp": "ISO8601",
  "markets": [
    {
      "marketId": "string",
      "marketType": "string",
      "selections": [
        {
          "selectionId": "string",
          "name": "string",
          "odds": "decimal"
        }
      ]
    }
  ]
}
```

#### Get Popular Fixtures
```http
GET /fixtures/popular
```
Returns list of currently popular fixtures.

**Parameters:**
- `limit` (query): Maximum number of fixtures to return (default: 20)
- `sport` (query): Filter by sport type

**Response:**
```json
{
  "fixtures": [
    {
      "fixtureId": "string",
      "sport": "string",
      "event": "string",
      "startTime": "ISO8601",
      "popularityScore": "number"
    }
  ]
}
```

### Market Management

#### Request Custom Market
```http
POST /markets/request
```
Request odds for a specific market using AI to determine relevance.

**Request Body:**
```json
{
  "fixtureId": "string",
  "sport": "string",
  "description": "string",
  "preferences": {
    "marketTypes": ["string"],
    "priority": "number"
  }
}
```

**Response:**
```json
{
  "requestId": "string",
  "status": "string",
  "estimatedCompletion": "ISO8601"
}
```

### Webhooks

#### Register Webhook
```http
POST /webhooks
```
Register a webhook to receive odds updates.

**Request Body:**
```json
{
  "url": "string",
  "events": ["string"],
  "fixtureIds": ["string"],
  "secret": "string"
}
```

## Rate Limiting
- 100 requests per minute per API key
- 1000 requests per hour per API key
- Rate limit headers included in responses:
  ```
  X-RateLimit-Limit: 100
  X-RateLimit-Remaining: 95
  X-RateLimit-Reset: 1623456789
  ```

## Error Handling
All errors follow this format:
```json
{
  "error": {
    "code": "string",
    "message": "string",
    "details": {}
  }
}
```

Common error codes:
- `400`: Bad Request
- `401`: Unauthorized
- `403`: Forbidden
- `404`: Not Found
- `429`: Too Many Requests
- `500`: Internal Server Error

## Best Practices
1. Use caching headers appropriately
2. Implement exponential backoff for retries
3. Monitor rate limits
4. Use webhooks for real-time updates
5. Validate all responses
6. Handle errors gracefully

## Integration Examples
See the [integration guide](integration/INTEGRATION.md) for detailed examples and best practices. 