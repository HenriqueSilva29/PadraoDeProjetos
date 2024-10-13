using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new MediaSocialFactory();
            var media = factory.CreateMediaSocial();
            media.Post("Título do post","Minha primeira publicação");
            media.Like();

        }
    }
} 


