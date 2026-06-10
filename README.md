# Calculator (.NET 8)

A minimal .NET 8 class library with xUnit tests. Demonstrates .NET restore, build, and test on [Forgejo Actions](https://forgejo.org/docs/latest/user/actions/).

## CI workflow

Runs on every push and pull request ([`.forgejo/workflows/ci.yml`](.forgejo/workflows/ci.yml)):

1. Sets up .NET 8 SDK
2. Restores NuGet dependencies
3. Builds the solution
4. Runs xUnit tests

## Run locally

```
dotnet restore
dotnet build
dotnet test
```
