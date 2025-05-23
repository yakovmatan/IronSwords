using System.Collections.Generic;

public abstract class AttackTool
{
    public string Name { get; }
    public abstract List<string> target { get; }

    public int fuel { get; protected set; } = 80;

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
            this.fuel += amount;
        }
    }

    public virtual void Attack()
    {
        this.AmountAmmunition--;
    }

}