using AbstractMethodPattern.Factory;
using System;
using System.Net.Sockets;

namespace AbstractMethodPattern
{
     internal class Program
    {
        static void Main(string[] args)
        {
            try {
                
                PizzaFactoryMethod factory = PizzaSimpleFactory.CriarPizzaria("RJ");
                var pizza = factory.MontaPizza("M");
                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("Pizza pronta");
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }

}