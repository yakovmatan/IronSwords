using System;
using System.Collections.Generic;

public class StrikeAvailability
{
    public void ShowStrikeAvailabilty()
    {
        Console.WriteLine("IDF Strike Tools Availability");
        Console.WriteLine(new string('=', 35));
        Console.WriteLine("{0,-20} {1,10}", "Tool Name", "Strikes Left");
        Console.WriteLine(new string('-', 35));
        foreach (var attackTool in IDF.ReadList())
        {
            Console.WriteLine("{0,-20} {1,10}", attackTool.Name, attackTool.AmountAmmunition);

        }
        Console.WriteLine(new string('=', 35));
            

    }
}
