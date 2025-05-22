using System.Collections.Generic;

public class Hermes460ZicDrone : IAttackTool
{
    public string Name { get; } = "ZIC";

    public int fuel { get; private set; } = 80;

    public int AmountAmmunition { get; private set; } = 3;

    public List<string> target { get; } = new List<string> { "people", "cars" };

    public Hermes460ZicDrone()
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

    public void attack()
    {
        this.AmountAmmunition--;
    }




}
    