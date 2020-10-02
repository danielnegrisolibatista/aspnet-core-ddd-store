using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
    }
}
