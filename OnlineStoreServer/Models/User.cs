
using OnlineStoreServer.Models.Cart;

namespace OnlineStoreServer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }

}
