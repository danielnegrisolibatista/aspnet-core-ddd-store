using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Core.Interfaces.Services;
using DDDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Services.Services
{
    public class OrderItemService : BaseService<OrderItem>, IOrderItemService
    {
        public readonly IOrderItemRepository _orderItemRepository;
        public OrderItemService(IOrderItemRepository orderItemRepository) : base(orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
    }
}
