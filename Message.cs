using System;
using IronSwords;

public class Message : IMessage
{
    ITerrorist terorrist;

    public string Location { get; private set; }

    public DateTime Timestemp { get; private set; }

    public Message()
    {
        ChooseTerorrist();
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
        this.Timestemp = now;

    }

    private void ChooseTerorrist()
    {
        Random random = new Random();
        int length = Hamas.ReadList().Count;
        this.terorrist = Hamas.ReadList()[random.Next(length)];
    }

    
}