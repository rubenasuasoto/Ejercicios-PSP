namespace Ejercicio
{
    public class Shield : Protection
    {
        public Shield(string name, int armor) : base(name, armor)
        {
        }

        public override void Apply(Character character)
        {
            character.BaseArmor += Armor;
        }
    }
}
