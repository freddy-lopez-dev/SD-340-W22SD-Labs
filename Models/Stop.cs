namespace SD_340_W22SD_Lab_3.Models
{
    public class Stop
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public List<ScheduledStops> ScheduledStops { get; set; }
    }
}
