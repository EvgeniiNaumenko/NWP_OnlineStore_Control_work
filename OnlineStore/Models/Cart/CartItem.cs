using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Cart
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }  // Ссылка на продукт
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
