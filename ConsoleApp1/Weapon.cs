namespace Ejercicio
{
    public abstract class Weapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public virtual void Apply(Character character)
        {
            character.BaseDamage += Damage;
        }
    }
}