using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Products
{
    public class Pizza
    {
        protected string Nome { get; set; }
        protected string massa;
        protected string molho;
        protected List<string> Ingredientes = new List<string>();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Preparando" + Nome);
            sb.Append(massa + "\n");
            sb.Append(molho + "\n");
            sb.Append("Ingredientes : " + "\n");
            foreach (string ingrediente in Ingredientes)
            {
                sb.Append("\t" + $"{ingrediente}" + "\n");
            };
            sb.Append(Cozinhar());
            sb.Append(Fatiar());

            return sb.ToString();
        }

        public virtual string Cozinhar()
        {
            return "Cozinhar pizza por 25 minutos a 340 graus";
        }

        public virtual string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços";
        }
    }
}
