# BasicPingApp

A basic .NET Core ping console application use for simple deployments in Kubernetes.

## dotnet CLI

dotnet CLI used to create this project:

```ps1: In C:\src\github.com\ongzhixian\BasicPingApp
dotnet new sln -n BasicPingApp
dotnet new console -n BasicPingApp.ConsoleApp
dotnet sln .\BasicPingApp.sln add .\BasicPingApp.ConsoleApp\
```

Other packages that we may want to include to expand on configuration options:
dotnet add .\BasicPingApp.ConsoleApp\ package Microsoft.Extensions.Configuration
dotnet add .\BasicPingApp.ConsoleApp\ package Microsoft.Extensions.Configuration.Json
Microsoft.Extensions.Configuration.CommandLine
Microsoft.Extensions.Configuration.Binder
Microsoft.Extensions.Configuration.EnvironmentVariables 