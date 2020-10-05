using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Core.Interfaces.Services;
using DDDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Services.Services
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
