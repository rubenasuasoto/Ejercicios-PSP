namespace Ejercicio
{
    public class Helmet : IItem
    {
        public string Name { get; set; }
        public int Armor { get; set; }

        public Helmet(string name, int armor)
        {
            Name = name;
            Armor = armor;
        }

        public void Apply(Character character)
        {
            character.BaseArmor += Armor;
        }
    }
}