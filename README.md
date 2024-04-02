# Simple .NET 8 gRPC Service Demo

## Overview

This project is a demonstration of a simple gRPC service written in .NET 8. 

It serves as a practical guide, demonstrating the minimal configuration necessary to run a .NET application capable of handling both RESTful HTTP requests and gRPC requests within the same codebase, utilizing transcoding techniques

## Features

- Demonstrates how to configure a gRPC server in a .NET 8 application.
- Illustrates the minimal setup required to serve RESTful HTTP endpoints alongside gRPC endpoints.
- Provides examples of defining and implementing gRPC service contracts using Protocol Buffers.
- Includes an OpenAPI/Swagger interface for visualizing and interacting with the API endpoints.
- Offers gRPC reflection for dynamic discovery and exploration of the gRPC contract.

## Resources Used

Below are the resources used to create this project:

1. [High-performance services with gRPC: What's new in .NET 7 | .NET Conf 2022](https://www.youtube.com/watch?v=et_2NBk4N4Y) - Youtube
2. [gRPC JSON transcoding in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/grpc/json-transcoding?view=aspnetcore-8.0) - Microsoft Learn
3. [gRPC JSON transcoding documentation with Swagger / OpenAPI](https://learn.microsoft.com/en-us/aspnet/core/grpc/json-transcoding-openapi?view=aspnetcore-8.0) - Microsoft Learn

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred .NET development environment.
3. Build and run the project.

## Usage

Once the project is running, you can interact with the server using the provided endpoints:

- **gRPC Endpoints**: Access gRPC endpoints using compatible gRPC clients.
- **RESTful Endpoints**: Interact with RESTful HTTP endpoints using standard HTTP client libraries or tools like cURL.
- **OpenAPI/Swagger Interface**: Visualize and interact with the API endpoints using the provided OpenAPI/Swagger interface.
- **gRPC Reflection**: Utilize gRPC reflection for dynamic discovery and exploration of the gRPC contract.

## License

This project is dedicated to the public domain under the [Creative Commons Zero v1.0 Universal (CC0 1.0) License](LICENSE). You are free to use, modify, and distribute the code for any purpose, without any restrictions.
