namespace BiggusTickus.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Venue { get; set; } = string.Empty;
        public List<Ticket>? Tickets { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
