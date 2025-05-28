using System;
using IronSwords;

public class Strike
{
    private ITerrorist target;
    private string location;
    private DateTime Time;


    public Strike()
    {
        TargetPrioritization prioritization = new TargetPrioritization();
        this.target = prioritization.dangerTerrorist;
        this.location = prioritization.location;
        this.Time = prioritization.TimeStamp;
    }

    public void StrikeExecution()
    {
        TargetPrioritization prioritization = new TargetPrioritization();
        this.target = prioritization.dangerTerrorist;
        this.location = prioritization.location;
        
        bool execution = false;
        foreach (var weapon in IDF.ReadList())
        {
            if (string.Join(",",weapon.target).Contains(location)) // בודק האם הכלי מתאים לבדוק את המטרה
            {
                if (weapon.AmountAmmunition > 0)
                {
                    weapon.Attack(target);
                    Console.WriteLine("The strike on the terrorist was successfully executed");
                    Console.WriteLine($"Target: {target.Name}\nTime of ordering the attack: {Time} \nplace of attack: {location}\nThe attack tool: {weapon.Name}\nAmmunition used: 1\nOfficer's name: yakov matan");
                    execution = true;
                break; 
                }
               
            }

        }
        if (!execution)
        {
            Console.WriteLine("The appropriate attack tool is not available for the attack.");
        }
    }
}