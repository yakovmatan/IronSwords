using System;
using System.Collections.Generic;
using IronSwords;

public class Terrorist : ITerrorist
{
    public string Name { get; }
    public int Rank { get; private set; } 
    public bool IsLife { get; set; } = true;
    public List<string> Weapons { get; private set; } = new List<string>();

    private static Random random = new Random();


    public Terrorist(string name)
    {
        this.Name = name;
        updateRank();
        updateWeapone();
        Hamas.AddTerrorist(this);
    }


    public void updateRank()
    {
        int therank = random.Next(1, 6);
        this.Rank = therank;
    }
    public void updateWeapone()
    {
        int sum = random.Next(1, 4);
        List<string>weaponType = new List<string>{ "knife", "gun", "M16", "AK47" };
        for (int i = 0; i < sum; i++)
        {
            this.Weapons.Add(weaponType[random.Next(weaponType.Count)]);

        }
    }
    public void KillTerrorist()
    {
        this.IsLife = false;
    }
    
}