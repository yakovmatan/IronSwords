using System;

public class AllMessages
{
    public void ShowAllMessagesForLivingTerrorist()
    {
        foreach (var message in Aman.ReadList())
        {
            if (message.Terrorist.IsLife)
            {
                Console.WriteLine("┌────────────────────────────────────────┐");
                Console.WriteLine($"│ Name     : {message.Terrorist.Name,-28}│");
                Console.WriteLine($"│ ID       : {message.Terrorist.Id,-28}│");
                Console.WriteLine($"│ Location : {message.Location,-28}│");
                Console.WriteLine($"│ Time     : {message.Timestamp,-28}│");
                Console.WriteLine("└────────────────────────────────────────┘\n");
            } 
        }

    }
}