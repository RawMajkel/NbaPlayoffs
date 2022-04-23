# NBA Playoffs

Full stack project using ASP.NET Core, Svelte, Docker etc.

## Docker compose

    docker compose -f docker-compose.dev.yml up

## Migrations

    dotnet ef migrations add init -s PlayoffsApi.API -p PlayoffsApi.Infrastructure

    dotnet ef database update -s PlayoffsApi.API -p PlayoffsApi.Infrastructure
