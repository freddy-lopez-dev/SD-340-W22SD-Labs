using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace SD_340_W22SD_Lab_3.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction? Direction { get; set; }
        public bool? RampAccessible { get; set; }
        public bool? BicycleAccessible { get; set; }
        public Queue<ScheduledStop> ScheduledStops { get; set; } = new Queue<ScheduledStop>();
    }
}
