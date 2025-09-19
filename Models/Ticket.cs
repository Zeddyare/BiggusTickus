namespace BiggusTickus.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string EventName { get; set; } = string.Empty;

        public DateTime EventDate { get; set; }

        public string Venue { get; set; } = string.Empty;

        public string SeatNumber { get; set; } = string.Empty;

        public string TicketHolder { get; set; } = string.Empty;
        
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
