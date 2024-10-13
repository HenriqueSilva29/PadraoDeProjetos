namespace AbstractMethodPattern.Products
{
    internal class PizzaCalabrezaSP : Pizza
    {
        public PizzaCalabrezaSP()
        {
            Nome = "Pizza de Calabreza Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano";
            Ingredientes.Add("Fatia de calabreza");
            Ingredientes.Add("Queijo parmessão");
        }
    }
}
