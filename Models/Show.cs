namespace BiggusTickus.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime ShowDate { get; set; }
        public string Venue { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public DateTime ShowCreation { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
