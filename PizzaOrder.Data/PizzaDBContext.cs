using Microsoft.EntityFrameworkCore;
using PizzaOrder.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Data
{
    public class PizzaDBContext : DbContext
    {
        public PizzaDBContext()
        {
        }

        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaDetails> PizzaDetails { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
