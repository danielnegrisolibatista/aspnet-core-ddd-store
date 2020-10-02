using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
