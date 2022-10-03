using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SD_340_W22SD_Lab_3.Data;
using SD_340_W22SD_Lab_3.Models;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SD_340_W22SD_Lab_3Context>(options =>
    options.UseSqlServer(connectionString));
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    await SeedData.Initialize(services);
}

#region Route 

app.MapGet("/route/{number}", async (int? number, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.Routes.Where(r => r.Number == number).ToListAsync();
});

#endregion

#region Stop 

app.MapGet("/stop/{number}", async (int? number, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.Stop.Where(s => s.Number == number).ToListAsync();
});

#endregion

#region StopSchedule 

app.MapGet("/stopschedule/{Number}/{top}", async (int? Number, int top, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.ScheduledStops.Where(ss => ss.Stop.Number == Number).Take(top).ToListAsync();
});

#endregion

app.Run();
