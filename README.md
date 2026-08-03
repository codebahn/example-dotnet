# Calculator (.NET 10)

A minimal .NET 10 class library with xUnit tests.

## CI workflow

The workflow lives at [`.github/workflows/ci.yml`](.github/workflows/ci.yml) and declares `runs-on: ubuntu-latest`. Both are GitHub defaults, unchanged. Nothing in this repository was renamed or rewritten to run here:

- `.github/workflows/` is read directly. There is no `.forgejo/` directory.
- `ubuntu-latest` routes to a Codebahn runner in Paris.
- `actions/checkout` and `actions/setup-dotnet` resolve from GitHub automatically.

On every push and pull request:

1. Sets up the .NET 10 SDK
2. Restores NuGet dependencies
3. Builds the solution
4. Runs xUnit tests

`TreatWarningsAsErrors` is on, so a build warning fails CI.

Need more than the 3 GB default? Set `runs-on: codebahn-medium` for 7 GB. See [CI runners](https://codebahn.net/docs/features/ci-runners/).

## Run locally

```
dotnet restore
dotnet build
dotnet test
```
