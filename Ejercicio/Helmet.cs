
namespace ConsoleApp2.Ejercicio;

   
    public class Helmet: Protection
    {
        public Helmet(int armor = DefaultArmor) : base(armor)
        {
            Name = "Helmet";
        }
    }