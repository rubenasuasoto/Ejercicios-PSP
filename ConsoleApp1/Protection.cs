namespace Ejercicio
{
    public abstract class Protection : IItem
    {
        public string Name { get; set; }
        public int Armor { get; set; }

        public Protection(string name, int armor)
        {
            Name = name;
            Armor = armor;
        }

        public virtual void Apply(Character character)
        {
            character.BaseArmor += Armor;
        }
    }
}