﻿namespace OnlineStoreServer.Models
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }  
        public List<byte[]> Images { get; set; } = new List<byte[]>();
    }
}
