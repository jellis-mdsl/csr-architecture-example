# csr-architecture-example

## Overview
Just a simple project adapting the Visual Studio 2019 ASP.NET Core Web API template to a Controllers-Services-Repositories software architecture.

The project makes use of controllers to serve API requests, offloads the meaningful programming to services, which get data from repositories.

The project makes use of .NET Core depedency injection, where the services and repositories are injected as depedencies by the interfaces they implement.

## Notes
The solution makes use of the .Net 5.0 framework.

## Further reading
A decent article to introduce the design pattern:
https://exceptionnotfound.net/the-repository-service-pattern-with-dependency-injection-and-asp-net-core/
