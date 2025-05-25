using System;

public class Menu
{
    private TopTerroristReport MessageAnalyzer = new TopTerroristReport();
    private StrikeAvailability WeaponProvider = new StrikeAvailability();
    private TargetPrioritization ThreatAnalyzer = new TargetPrioritization();
    private Strike StrikeExecutor = new Strike();

    public void Show()
    {
        Console.WriteLine("\n\nSelect an action:");
        Console.WriteLine("1. The terrorist with the most intelligence reports");
        Console.WriteLine("2. Get strike weapon information");
        Console.WriteLine("3. Find the most dengerous terrorist");
        Console.WriteLine("4. Execute a strike");
        Console.WriteLine("0. Exit");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                MessageAnalyzer.ShowTopTerroristReport();
                break;

            case "2":
                WeaponProvider.ShowStrikeAvailabilty();
                break;

            case "3":
                ThreatAnalyzer.Display();
                break;

            case "4":
                try
                {
                    StrikeExecutor.StrikeExecution();
                    break;
                }
                catch
                {
                    Console.WriteLine("No terrorist available for attack");
                    break;
                }
                

            case "0":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid selection. please try again");
                break;
        }

    }

}