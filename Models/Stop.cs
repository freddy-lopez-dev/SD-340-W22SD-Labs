using System.ComponentModel.DataAnnotations;

namespace SD_340_W22SD_Lab_3.Models
{
    public class Stop
    {
        [Key]
        [Required]
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction? Direction { get; set; }
        public List<ScheduledStop>? StopSchedules { get; set; }
    }
}
