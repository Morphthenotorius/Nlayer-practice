using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
