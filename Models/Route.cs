using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public ICollection<ScheduledStop> StopSchedules { get; set; } = new HashSet<ScheduledStop>();
        //Changed from Queue to ICollection
    }
}
