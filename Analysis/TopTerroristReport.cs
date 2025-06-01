using System;
using System.Collections.Generic;
using System.Linq;
using IronSwords;

public class TopTerroristReport
{
    private Dictionary<ITerrorist, int> DictOfTerrorists = new Dictionary<ITerrorist, int>();


    public TopTerroristReport()
    {
        DictTerroristReport(); // קריאה אוטומטית עם יצירת האובייקט
    }

    public void DictTerroristReport()
    {
        foreach (var i in Aman.ReadList())
        {
            if (i.Terrorist.IsLife && DictOfTerrorists.ContainsKey(i.Terrorist))
            {
                DictOfTerrorists[i.Terrorist] += 1;
            }
            else if(i.Terrorist.IsLife)
            {
                DictOfTerrorists[i.Terrorist] = 1;
            }
        }
    } 
    public void ShowTopTerroristReport()
    {
        int maxValue = 0;
        if (DictOfTerrorists.Any())
        {
            foreach (var kv in DictOfTerrorists)
            {
                if (kv.Key.IsLife && kv.Value > maxValue)
                {
                    maxValue = kv.Value;
                }
            }
            Console.WriteLine("Top Reported Living Terrorist(s):");
            Console.WriteLine(new string('-', 40));
            foreach (var kv in DictOfTerrorists)
            {
                if (kv.Value == maxValue && kv.Key.IsLife)
                {
                    Console.WriteLine($"Name     : {kv.Key.Name}");
                    Console.WriteLine($"ID       : {kv.Key.Id}");
                    Console.WriteLine($"Reports  : {kv.Value}");
                    Console.WriteLine(new string('-', 40));
                }
            }
        }
        else
        {
            Console.WriteLine("There is no information about living terrorists.");
        }
        
        
    }

}