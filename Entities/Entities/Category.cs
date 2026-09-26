using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.Entities
{
    public class Category: IEntity
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
