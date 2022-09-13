namespace SD_340_W22SD_Lab_3.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public enum Directions
        {
            North,
            South,
            West,
            East,
            NorthWest,
            SouthEast,
            SouthWest
        }

    }
}
