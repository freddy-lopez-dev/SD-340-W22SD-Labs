using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab_3.Data;

namespace SD_340_W22SD_Lab_3.Models
{
    public static class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            SD_340_W22SD_Lab_3Context context
                = new SD_340_W22SD_Lab_3Context(serviceProvider
                .GetRequiredService<DbContextOptions<SD_340_W22SD_Lab_3Context>>());


            if(!context.Routes.Any())
            {
                Stop stop1 = new Stop();
                stop1.Street = "Taylor Ave";
                stop1.Name = "Taylor North Stop";
                Stop stop2 = new Stop();
                stop2.Street = "Ebby Ave";
                stop2.Name = "Ebby North Stop";
                Stop stop3 = new Stop();
                stop3.Street = "Harrow Ave";
                stop3.Name = "Harrow North Stop";
                context.Stop.Add(stop1);
                context.Stop.Add(stop2);
                context.Stop.Add(stop3);

                ScheduledStop scheduledStop1 = new ScheduledStop();
                scheduledStop1.ScheduledArrival = DateTime.Now;
                scheduledStop1.Stop = stop1;
                ScheduledStop scheduledStop2 = new ScheduledStop();
                scheduledStop2.ScheduledArrival = DateTime.Now;
                scheduledStop2.Stop = stop2;
                ScheduledStop scheduledStop3 = new ScheduledStop();
                scheduledStop3.ScheduledArrival = DateTime.Now;
                scheduledStop3.Stop = stop3;
                ScheduledStop scheduledStop4 = new ScheduledStop();
                scheduledStop4.ScheduledArrival = DateTime.Now;
                scheduledStop4.Stop = stop1;
                ScheduledStop scheduledStop5 = new ScheduledStop();
                scheduledStop5.ScheduledArrival = DateTime.Now;
                scheduledStop5.Stop = stop2;
                context.ScheduledStops.Add(scheduledStop1);
                context.ScheduledStops.Add(scheduledStop2);
                context.ScheduledStops.Add(scheduledStop3);
                context.ScheduledStops.Add(scheduledStop4);
                context.ScheduledStops.Add(scheduledStop5);

                Route route = new Route();
                route.Name = "Stafford";
                route.BicycleAccessible = true;
                route.RampAccessible = true;
                route.StopSchedules.Add(scheduledStop1);
                route.StopSchedules.Add(scheduledStop2);
                route.StopSchedules.Add(scheduledStop3);
                route.StopSchedules.Add(scheduledStop4);
                route.StopSchedules.Add(scheduledStop5);
                context.Routes.Add(route);

                Route route2 = new Route();
                route2.Name = "Pembina";
                route2.BicycleAccessible = true;
                route2.RampAccessible = true;
                route2.StopSchedules.Add(scheduledStop3);
                route2.StopSchedules.Add(scheduledStop4);
                route2.StopSchedules.Add(scheduledStop1);
                route2.StopSchedules.Add(scheduledStop2);
                route2.StopSchedules.Add(scheduledStop5);
                context.Routes.Add(route2);
                await context.SaveChangesAsync();
            }
        }
    }
}
