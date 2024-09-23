namespace Ejercicio
{
    public class Axe : Weapon
    {
        public Axe(string name, int damage) : base(name, damage)
        {
        }

        public override void Apply(Character character)
        {
            character.BaseDamage += Damage;
        }
    }
}