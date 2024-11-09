namespace YoutubeTutorial.Models
{
    public class Room
    {
        public int Id   { get; set; }
        public required string Category  { get; set; }
        public int Capacity { get; set; }

        public int Price    { get; set; }

        public Room()
        {
            
        }
    }
}
