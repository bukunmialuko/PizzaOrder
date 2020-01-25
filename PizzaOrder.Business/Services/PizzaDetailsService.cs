using PizzaOrder.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Business.Services
{
    public interface IPizzaDetailsService
    {

    }
    public class PizzaDetailsService : IPizzaDetailsService
    {
        private readonly PizzaDBContext _dbContext;

        public PizzaDetailsService(PizzaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
