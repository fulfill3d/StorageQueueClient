
# StorageQueueClient

StorageQueueClient is a library for interacting with Azure Storage Queues. It provides functionalities to send messages to storage queues and ensures reliable communication between distributed services.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

StorageQueueClient offers a straightforward way to work with Azure Storage Queues, allowing for easy message enqueueing. It's designed to simplify communication between distributed services, making it a valuable tool for decoupling and scaling applications.

## Features

- **Send Messages:** Send messages to Azure Storage Queues reliably.
- **Create Queues:** Automatically create queues if they do not exist.
- **Queue Management:** Manage Azure Storage Queues with ease.

## Tech Stack

- **Backend:** .NET 8
- **Queue Service:** Azure Storage Queues
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the StorageQueueClient:** Use the `RegisterStorageQueueClient` extension method to register the client in the dependency injection container.
2. **Configure the options:** Set up `StorageQueueClientOptions` with the necessary configuration, including the connection string.
3. **Use the Client:** Use the `IStorageQueueClient` interface to send messages to Azure Storage Queues.

## Configuration

### StorageQueueClientOptions

- **ConnectionString:** The connection string to the Azure Storage account.

```csharp
public class StorageQueueClientOptions
{
    public string ConnectionString { get; set; }
}
```

### Dependency Injection Registration

To use the `StorageQueueClient` in your application, register it in the service container as shown below:

```csharp
services.RegisterStorageQueueClient(options =>
{
    options.ConnectionString = "<your-connection-string>";
});
```
