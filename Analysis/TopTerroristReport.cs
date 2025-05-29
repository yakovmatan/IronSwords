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
                    Console.WriteLine(kv.Key.Name);
                }
            }
        }
        else
        {
            Console.WriteLine("There is no information about living terrorists.");
        }
        
        
    }
}