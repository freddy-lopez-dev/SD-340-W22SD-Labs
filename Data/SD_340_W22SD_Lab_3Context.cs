using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab_3.Models;

namespace SD_340_W22SD_Lab_3.Data
{
    public class SD_340_W22SD_Lab_3Context : DbContext
    {
        public SD_340_W22SD_Lab_3Context (DbContextOptions<SD_340_W22SD_Lab_3Context> options)
            : base(options)
        {
        }

        public DbSet<SD_340_W22SD_Lab_3.Models.Stop> Stop { get; set; } = default!;
        public DbSet<SD_340_W22SD_Lab_3.Models.Route> Routes { get; set; } = default!;
        public DbSet<SD_340_W22SD_Lab_3.Models.ScheduledStop> ScheduledStops { get; set; } = default!;
        public DbSet<SD_340_W22SD_Lab_3.Models.Direction> Directions { get; set; } = default!;
    }
}
