namespace EternaApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Client { get; set; }= null!;
        public List<ProductImage> ProductImages { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Url { get; set; } = null!;
        public int CategoryId { get; set; }
        public Categories Category { get; set; } = null!;
    }
}
