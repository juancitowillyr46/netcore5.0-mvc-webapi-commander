Desarrollo de una WEB API

GET - https://localhost:5001/api/commands/

GET - https://localhost:5001/api/commands/{id}

POST - https://localhost:5001/api/commands/
{
    "howTo": "Test",
    "line": "Test",
    "platform": "Test"
}

PUT - https://localhost:5001/api/commands/{id}
{
    "howTo": "Test update",
    "line": "Test update",
    "platform": "Test update"
}

PATCH - https://localhost:5001/api/commands/{id}
[
    {
        "op": "replace",
        "path": "/howto",
        "value": "Hello patch"
    }
]