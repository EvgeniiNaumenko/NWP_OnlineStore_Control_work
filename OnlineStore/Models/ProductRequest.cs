using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int UserId { get; set; }
    }
}
