namespace Ejercicio
{
    public class Sword : Weapon
    {
        public Sword(string name, int damage) : base(name, damage)
        {
        }

        public override void Apply(Character character)
        {
            character.BaseDamage += Damage;
        }
    }
}