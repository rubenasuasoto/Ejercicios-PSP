namespace ConsoleApp2.Ejercicio;

public class Minion
{
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }
    public int HitPoints { get; set; }
    public int Damage { get; set; }

    public Minion(string name, int maxHitPoints, int damage)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        HitPoints = MaxHitPoints;
        Damage = damage;
    }

    public int Attack()
    {
        return Damage;
    }

    public void ReceiveDamage(int amount)
    {
        HitPoints = Math.Max(0, HitPoints - amount);
    }

    public override string ToString()
    {
        return $"{Name} (HP: {HitPoints}/{MaxHitPoints}, Damage: {Damage})";
    }
}
