using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Factory
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local) 
        {
            PizzaFactoryMethod pizzaria;
            switch(local)
            {
                case "SP":
                    pizzaria = new PizzaFactorySP(); 
                    break;
                case "RJ":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default: 
                    throw new ApplicationException($"A pizarria {local} não está disponível");
            }
            return pizzaria;
        }
    }
}
