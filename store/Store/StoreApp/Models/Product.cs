namespace StoreApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }  
        public string? ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
    }
}