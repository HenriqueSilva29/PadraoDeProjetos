using AbstractMethodPattern.Products;

namespace AbstractMethodPattern.Factory
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
                return new PizzaMussarelaSP();
            else if (tipo.Equals("C"))
                return new PizzaCalabrezaSP();
            else return null;
        }
    }
}
