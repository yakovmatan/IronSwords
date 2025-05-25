using System;
using System.Collections.Generic;
using System.Linq;

public class TopTerroristReport
{
    private Dictionary<string, int> DictOfTerrorists = new Dictionary<string, int>();


    public TopTerroristReport()
    {
        DictTerroristReport(); // קריאה אוטומטית עם יצירת האובייקט
    }

    public void DictTerroristReport()
    {
        foreach (var i in Aman.ReadList())
        {
            if (i.Terrorist.isLife && DictOfTerrorists.ContainsKey(i.Terrorist.name))
            {
                DictOfTerrorists[i.Terrorist.name] += 1;
            }
            else if(i.Terrorist.isLife)
            {
                DictOfTerrorists[i.Terrorist.name] = 1;
            }
        }
    } 
    public void ShowTopTerroristReport()
    {
        DictOfTerrorists.Clear();
        DictTerroristReport();
        int maxValue;
        if (DictOfTerrorists.Any())
        {
            maxValue = DictOfTerrorists.Values.Max();
            foreach (var kv in DictOfTerrorists)
            {
                if (kv.Value == maxValue)
                {
                    Console.WriteLine(kv.Key);
                }
            }
        }
        else
        {
            Console.WriteLine("There is no information about living terrorists.");
        }
        
        
    }
}