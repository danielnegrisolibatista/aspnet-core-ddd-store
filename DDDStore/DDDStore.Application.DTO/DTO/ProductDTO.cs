using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
    }
}
