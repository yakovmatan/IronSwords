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
            if (string.Join(",",weapon.target).Contains(location)) 
            {
                if (weapon.AmountAmmunition > 0)
                {
                    weapon.Attack(target);
                    Console.WriteLine(">>> The strike on the terrorist was successfully executed <<<\n");
                    Console.WriteLine($"Target Name           : {target.Name}");
                    Console.WriteLine($"Target ID             : {target.Id}");
                    Console.WriteLine($"Time of Order         : {Time}");
                    Console.WriteLine($"Location              : {location}");
                    Console.WriteLine($"Weapon Used           : {weapon.Name}");
                    Console.WriteLine($"Ammunition Consumed   : 1");
                    Console.WriteLine($"Officer in Charge     : Yakov Matan");
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