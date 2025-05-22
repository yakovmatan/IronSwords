using System;
using System.Collections.Generic;
using System.Linq;

public class TopTerroristReport
{
    private Dictionary<string, int> DictOfTerrorists;

    public void DictTerroristReport()
    {
        foreach (var i in Aman.ReadList())
        {
            if (DictOfTerrorists.ContainsKey(i.Terrorist.name))
            {
                DictOfTerrorists[i.Terrorist.name] += 1;
            }
            else
            {
                DictOfTerrorists[i.Terrorist.name] = 1;
            }
        }
    } 
    public void ShowTopTerroristReport()
    {
        int maxValue = DictOfTerrorists.Values.Max();
        foreach(var kv in DictOfTerrorists)
        {
            if(kv.Value == maxValue)
            {
                Console.WriteLine(kv.Key);
            }
        }
    }
}