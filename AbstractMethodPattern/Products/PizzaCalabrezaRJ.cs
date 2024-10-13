namespace AbstractMethodPattern.Products
{
    internal class PizzaCalabrezaRJ : Pizza
    {
        public PizzaCalabrezaRJ()
        {
            Nome = "Pizza de Calabreza Carioca";
            massa = "Massa fina crocante carioca";
            molho = "Molho de tomate italiano";
            Ingredientes.Add("Fatia de calabreza");
            Ingredientes.Add("Queijo parmessão");
        }
    }
}
