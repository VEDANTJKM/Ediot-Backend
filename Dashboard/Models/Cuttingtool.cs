namespace Dashboard.Models
{
    public class Cuttingtool
    {
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string Type { get; set; }
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public decimal OnHandQty { get; set; }
        public decimal UnitPrice { get; set; }
        public string UOM { get; set; }
    }
}
