using System.Collections.Generic;
using IronSwords;

public abstract class AttackTool
{
    public string Name { get; }
    public abstract List<string> target { get; }

    public int Fuel { get; protected set; } = 80;

    public int AmountAmmunition { get; protected set; }

    public AttackTool(int amountAmmunition, string name)
    {
        this.AmountAmmunition = amountAmmunition;
        this.Name = name;
    }

    public virtual void Refuel(int amount)
    {
        if (amount > 0)
        {
            this.Fuel += amount;
        }
    }

    public virtual void Attack(ITerrorist terrorist)
    {
        this.AmountAmmunition--;
        terrorist.KillTerrorist();
    }

}