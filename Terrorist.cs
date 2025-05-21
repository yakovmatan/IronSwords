using System;
using System.Collections.Generic;
using IronSwords;

public class Terrorist : ITerrorist
{
    public string name { get; }
    public int rank { get; private set; }
    public bool isLife { get; set; } = true;
    public List<string> weapone { get; private set; } = new List<string>();

    public Terrorist(string name)
    {
        this.name = name;
        this.rank = updateRank();
        updateWeapone();
        Hamas.AddTerrorist(this);
    }


    public int updateRank()
    {
        Random random = new Random();
        int therank = random.Next(1, 6);
        return therank;
    }
    public void updateWeapone()
    {
        Random random = new Random();
        int sum = random.Next(1, 4);
        List<string>weaponType = new List<string>{ "knife", "gun", "M16", "AK47" };
        for (int i = 0; i < sum; i++)
        {
            this.weapone.Add(weaponType[random.Next(weaponType.Count)]);

        }
    }
    public void updateIsLife()
    {
        this.isLife = false;
    }
    
}