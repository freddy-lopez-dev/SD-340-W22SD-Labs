using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SD_340_W22SD_Lab_3.Data;
using SD_340_W22SD_Lab_3.Models;

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

app.MapGet("/route", async (int? Number, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.Routes.Include(r => r.StopSchedules).ToListAsync();
});

#endregion

#region Stop 

app.MapGet("/stop", async (int? Number, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.Stop.Include(r => r.StopSchedules).ToListAsync();
});

#endregion

#region StopSchedule 

app.MapGet("/stopschedule", async (int? Number, int top, SD_340_W22SD_Lab_3Context db) =>
{
    return await db.ScheduledStops.ToListAsync();
});

#endregion

app.Run();
