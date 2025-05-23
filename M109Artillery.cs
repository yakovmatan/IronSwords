using System.Collections.Generic;

public class  M109Artillery : IAttackTool
{
    public string Name { get; } = "M109";

    public int fuel { get; private set; } = 80;

    public int AmountAmmunition { get; private set; } = 3;

    public List<string> target { get; } = new List<string> { "open area" };


    public M109Artillery()
    {
        IDF.AddAttackTool(this);
    }

    public void Refuel(int amount)
    {
        if (amount > 0)
        {
            this.fuel += amount;
        }
    }

    public void Attack()
    {
        this.AmountAmmunition--;
    }


}