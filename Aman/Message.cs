using System;
using IronSwords;

public class Message : IMessage
{
    private static Random rand = new Random();
    public ITerrorist Terrorist { get; private set; }

    public string Location { get; private set; }

    public DateTime Timestamp { get; private set; }

    public Message()
    {
        ChooseTerrorist();
        TheLocation();
        TheTimestemp();
        Aman.AddMessage(this);
    }


    private void TheLocation()
    {
        string[] locations = { "buildings", "people", "cars", "open area" };
        this.Location =  locations[rand.Next(locations.Length)];

    }

    private void TheTimestemp()
    {
        DateTime now = DateTime.Now;
        this.Timestamp = now;

    }

    private void ChooseTerrorist()
    {
        var list = Hamas.ReadList();
        if (list.Count > 0)
        {
            this.Terrorist = list[rand.Next(list.Count)];
        }
        else
        {
            this.Terrorist = null; // טיפול במקרה שאין מחבלים
        }
    }

    
}