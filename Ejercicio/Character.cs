
namespace ConsoleApp2.Ejercicio
{
    public class Character
    {
        public const int DefaultMaxHp = 10;
        public const int DefaultBaseDamage = 1;
        public const int DefaultBaseArmor = 0;

        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int HitPoints { get; set; }
        public int BaseDamage { get; set; }
        public int Damage { get; set; }
        public int BaseArmor { get; set; }
        public int Armor { get; set; }

        private List<IItem> _inventory;
        private List<Minion> _minions;

        public Character(string name, int maxHitPoints = DefaultMaxHp, int baseDamage = DefaultBaseDamage,
            int baseArmor = DefaultBaseArmor)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            HitPoints = MaxHitPoints;
            BaseDamage = baseDamage;
            BaseArmor = baseArmor;
            _inventory = new List<IItem>();
            _minions = new List<Minion>();
        }

        public void AddItem(IItem item) => _inventory.Add(item);
        public bool RemoveItem(IItem item) => _inventory.Remove(item);
        public int InventoryCount() => _inventory.Count;

        public void AddMinion(Minion minion) => _minions.Add(minion);
        public bool RemoveMinion(Minion minion) => _minions.Remove(minion);

        public int Attack()
        {
            ApplyInventory();

            // Sumar el daño de los minions
            int totalDamage = Damage;
            foreach (var minion in _minions)
            {
                totalDamage += minion.Attack();
            }

            return totalDamage;
        }

        public int Defense()
        {
            ApplyInventory();
            return Armor;
        }

        private void ApplyInventory()
        {
            Damage = BaseDamage;
            Armor = BaseArmor;
            foreach (var item in _inventory)
            {
                item.Apply(this);
            }
        }

        public void Heal(int amount)
        {
            HitPoints = Math.Min(MaxHitPoints, HitPoints + amount);
        }

        public void ReceiveDamage(int amount)
        {
            HitPoints = Math.Max(0, HitPoints - amount);
        }

        public override string ToString()
        {
            string result = $"Character: {Name} | HP: {HitPoints}/{MaxHitPoints}\n";
            result += "  Inventory:\n";
            foreach (var item in _inventory)
            {
                result += $"    {item}\n";
            }

            result += $"  Minions:\n";
            foreach (var minion in _minions)
            {
                result += $"    {minion}\n";
            }

            result += $"  Attack: {Attack()}\n";
            result += $"  Defense: {Defense()}\n";
            return result;
        }
    }
}
