﻿namespace SD_340_W22SD_Lab_3.Models
{
    public class Route
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public ScheduledStops Queue { get; set; }
    }
}
