
namespace Ejercicio
{
    public class Character : IItem  
    {
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int BaseDamage { get; set; }
        public int BaseArmor { get; set; }
        private List<IItem> _inventory; 

        public Character()
        {
            _inventory = new List<IItem>();
            CurrentHitPoints = MaxHitPoints;
        }

        public int Attack(int damage)
        {
            damage += BaseDamage;
            return damage;
        }

        public int Defense(int armor)
        {
            armor += BaseArmor;
            return armor;
        }

        public void Heal(int heal)
        {
            CurrentHitPoints += heal;
            if (CurrentHitPoints > MaxHitPoints)
            {
                CurrentHitPoints = MaxHitPoints;
            }
        }

        public void ReceiveDamage(int damage)
        {
            int effectiveDamage = damage - BaseArmor;
            if (effectiveDamage > 0)
            {
                CurrentHitPoints -= effectiveDamage;
            }
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0;
            }
        }

        public void Apply(Character character)
        {
            
        }
    }
}

