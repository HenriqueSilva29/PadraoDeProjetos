namespace AbstractMethodPattern.Products
{
    internal class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de Mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate paulista";
            Ingredientes.Add("Queijo cheedar");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
