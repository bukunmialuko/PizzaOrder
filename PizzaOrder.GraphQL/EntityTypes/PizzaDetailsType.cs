﻿using GraphQL.Types;
using PizzaOrder.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.GraphQL.Types
{
    public class PizzaDetailsType : ObjectGraphType<PizzaDetails>
    {
        public PizzaDetailsType()
        {
            Name = nameof(PizzaDetailsType);

            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.OrderDetailsId);
            Field(x => x.Price);
            Field(x => x.Size);

            Field<StringGraphType>(
                name: "toppings",
                resolve: context => context.Source.Toppings.ToString());
        }
    }
}
