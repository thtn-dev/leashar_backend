## Cách chạy migration database

```
 dotnet ef migrations add InitialAppMigration -c AppDbContext --project .\Leashar.Infrastructure\Leashar.Infrastructure.csproj --startup-project .\Leashar.WebApi\Leashar.WebApi.csproj -o Data/Migrations/App
 dotnet ef database update  -c AppDbContext --project .\Leashar.Infrastructure\Leashar.Infrastructure.csproj --startup-project .\Leashar.WebApi\Leashar.WebApi.csproj
 dotnet ef migrations remove -c AppDbContext --project .\Leashar.Infrastructure\Leashar.Infrastructure.csproj --startup-project .\Leashar.WebApi\Leashar.WebApi.csproj
```
