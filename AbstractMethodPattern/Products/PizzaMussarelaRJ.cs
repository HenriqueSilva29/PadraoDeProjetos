namespace AbstractMethodPattern.Products
{
    internal class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de Mussarela Carioca";
            massa = "Massa fina crocante carioca";
            molho = "Molho de tomate carioca";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
