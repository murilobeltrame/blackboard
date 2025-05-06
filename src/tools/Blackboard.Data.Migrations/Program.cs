using Blackboard.Data.Migrations;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration.GetConnectionString("SqlServer");
        services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connectionString));
    })
    .Build();

using var scope = host.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
context.Database.Migrate();

host.Run();