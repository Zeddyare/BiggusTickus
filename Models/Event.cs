namespace BiggusTickus.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Venue { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public DateTime EventCreation { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
