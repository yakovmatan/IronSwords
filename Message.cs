using System;
using IronSwords;

public class Message : IMessage
{
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
        Random rand = new Random();
        string[] locations = { "buildings", "people", "cars", "open area" };
        this.Location =  locations[rand.Next(4)];

    }

    private void TheTimestemp()
    {
        DateTime now = DateTime.Now;
        this.Timestamp = now;

    }

    private void ChooseTerrorist()
    {
        Random random = new Random();
        int length = Hamas.ReadList().Count;
        this.Terrorist = Hamas.ReadList()[random.Next(length)];
    }

    
}