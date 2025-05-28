using System;

public class MessageFactory
{
    private Random Rand = new Random();
    public void CreateMessage()
    {
        for (int i = 0; i < Rand.Next(10,21); i++)
        {
            new Message();
        }

    }
}