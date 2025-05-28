using System;
using System.Collections.Generic;

public class StrikeAvailability
{
    public void ShowStrikeAvailabilty()
    {
        foreach (var atteckTool in IDF.ReadList())
        {
            Console.WriteLine($"Attack tool: {atteckTool.Name}");
            Console.WriteLine($"Available strikes left: {atteckTool.AmountAmmunition}");
            Console.WriteLine();

        }
            

    }
}
