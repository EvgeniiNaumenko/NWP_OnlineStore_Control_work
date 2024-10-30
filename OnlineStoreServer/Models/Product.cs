namespace OnlineStoreServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description {  get; set; }
        public decimal Price { get; set; }

        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();


        public int UserId { get; set; }
        public User User { get; set; }
    }

}
