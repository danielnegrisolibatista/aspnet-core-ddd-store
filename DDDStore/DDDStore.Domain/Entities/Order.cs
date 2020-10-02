using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDStore.Domain.Entities
{
    public class Order : EntityBase
    {
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalItems { get; private set; }
        public decimal Total { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalWithDiscount { get; private set; }

        public void CalculateTotal()
        {
            Total = OrderItems.Sum(s => s.Product.Price * s.Quantity);
        }
        public void CalculateTotalWithDiscont()
        {
            TotalWithDiscount = Total - Discount;
        }
        public void CalculateTotalItems()
        {
            TotalItems = OrderItems.Sum(s => s.Quantity);
        }
    }
}
