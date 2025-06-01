using System;
using System.Collections.Generic;
using IronSwords;

public class EliminatedTerrorist
{

    public void PrintDeadTerrorist()
    {
        HashSet<ITerrorist> printedTerrorists = new HashSet<ITerrorist>();
        bool ThereIs = false;
        foreach (var message in Aman.ReadList())
        {
            if (!message.Terrorist.IsLife && !printedTerrorists.Contains(message.Terrorist))
            {
                ThereIs = true;
                printedTerrorists.Add(message.Terrorist);
                Console.WriteLine("==========================================");
                Console.WriteLine("         ELIMINATED TERRORIST");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Name     : {message.Terrorist.Name}");
                Console.WriteLine($"ID       : {message.Terrorist.Id}");
                Console.WriteLine($"Location : {message.Location}");
                Console.WriteLine("==========================================\n");
            }
        }
        if (!ThereIs)
        {
            Console.WriteLine(" No eliminated terrorists found.");
        }
    }
}