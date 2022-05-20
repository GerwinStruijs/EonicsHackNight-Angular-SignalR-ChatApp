# Angular + Serverless SignalR using Azure Functions

Simple chat app using an angular app with azure ``signalr`` service and azure functions.

## Azure Functions

Contains 2 functions

- Negotiate (initiates the ``signalr`` connection)
- Send Message (sends message to an user)

Create ``local.settings.json`` file with the below settings and start the function.

```JSON
{
  "IsEncrypted": false,
  "Values": {
    "AzureSignalRConnectionString": "CONN-STRING-HERE;",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet"
  },
  "Host": {
    "CORS": "http://localhost:4200",
    "CORSCredentials": true
  }
}
```

- Start functions in Visual Studio.

## Angular App

The client used to initiate the chat.

Update environment.ts file with the chatHubBaseUri.

```TS
export const environment =
 {
  production: false,
  chatHubBaseUri: "http://localhost:7071"
};
```

- Run ```npm i | ng serve``` in VS Code
- Open browser and test