namespace ConsoleApp2.Ejercicio;

public class MinionItem : IItem
{
    private Minion _minion;

    public MinionItem(string minionName, int minionHp, int minionDamage)
    {
        _minion = new Minion(minionName, minionHp, minionDamage);
    }

    public void Apply(Character character)
    {
        // Añadir la mascota al personaje cuando el objeto es aplicado
        character.AddMinion(_minion);
    }

    public override string ToString()
    {
        return $"Minion Generator (Generates: {_minion})";
    }
}
