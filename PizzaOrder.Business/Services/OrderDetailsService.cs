using PizzaOrder.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Business.Services
{
    public interface IOrderDetailsService
    {

    }
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly PizzaDBContext _dbContext;

        public OrderDetailsService(PizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
