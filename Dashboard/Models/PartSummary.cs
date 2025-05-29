namespace Dashboard.Models
{
    public class PartSummary
    {
        public string Category { get; set; }
        public int TotalParts { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalOnHandQty { get; set; }
    }
}
