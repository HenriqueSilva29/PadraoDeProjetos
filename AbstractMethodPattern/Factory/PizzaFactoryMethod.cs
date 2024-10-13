using AbstractMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Factory
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
