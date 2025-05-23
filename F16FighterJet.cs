using System.Collections.Generic;

public class F16FighterJet : IAttackTool
{
    public string Name { get; } = "F16";

    public int fuel { get; private set; } = 80;


    public string OpearatedBy = "pilot";

    public int AmountAmmunition { get; private set; } = 8;

    public List<string> target { get; } = new List<string> { "buildings" };

    public F16FighterJet()
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