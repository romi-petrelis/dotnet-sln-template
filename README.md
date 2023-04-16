# Getting Started
Once you've cloned this repo:

* Rename the solution to whatever root namespace you like - ex: `{YourCompany}.{YourDivision}{...}.{DomainName}`
* Add some interfaces to `Domain.Abstractions/Infrastructure`
* Add `Infrastructure.{Provider}` libraries for each infrastructure provider (i.e. vendor/platform/strategy/library-specific implementation
of `Domain.Abstractions/Infrastructure` interfaces)
* Add `Domain.Extensions.{AnotherDomain}` libraries for each domain with which this one integrates - ex.: If this domain
handles events from `AnotherDomain`
* Delete `Domain.Abstractions.Contracts` if you don't need to publish any of your abstractions to nuget

# Enhancement Ideas
* Include default `GitVersion.yml` content
* Include a `Host.AzureFunctions` project
* Include boilerplate for an HTTP API, i.e. not just message handling
* Include an API client
* When an `Infrastructure` or `Extensions` project is created, they should include a `ServiceCollectionExtensions.cs` class
with a method called `Add{ModuleName}`
* When an `Infrastructure` or `Extensions` project is created, auto-add a dependent test project

# Resources
* [Design a DDD-oriented microservice](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice)
* [Infrastructure Ignorance](https://ayende.com/blog/3137/infrastructure-ignorance)
* [Guide for running C# Azure Functions in an isolated worker process](https://learn.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-process-guide)
* [FunctionApp samples](https://github.com/Azure/azure-functions-dotnet-worker/tree/main/samples/FunctionApp)
* [Differences between in-process and isolated worker process .NET Azure Functions](https://github.com/MicrosoftDocs/azure-docs/blob/main/articles/azure-functions/dotnet-isolated-in-process-differences.md)
* [In-process vs. Isolated Worker Process](https://markheath.net/post/azure-functions-isolated)
* [Solution for "Metadata generation failed. Exit code: '137' Error: 'Failed to Initialize CoreCLR'"](https://samestuffdifferentday.net/2023/02/01/things-i-learned-19/)
* [dotnet-sdk-check](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sdk-check)
* [dotnet-core-uninstall](https://learn.microsoft.com/en-us/dotnet/core/additional-tools/uninstall-tool?tabs=macos#step-3---uninstall-net-sdks-and-runtimes)