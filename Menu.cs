using System;

public class Menu
{
    private TopTerroristReport messageAnalyzer = new TopTerroristReport();
    private StrikeAvailability weaponProvider = new StrikeAvailability();
    private TargetPrioritization threatAnalyzer = new TargetPrioritization();
    private Strike strikeExecutor = new Strike();

    public void Show()
    {
        Console.WriteLine("\n\nSelect an action:");
        Console.WriteLine("1. The terrorist with the most intelligence reports");
        Console.WriteLine("2. Get stride weapon information");
        Console.WriteLine("3. Find the most dengerous terrorist");
        Console.WriteLine("4. Exeute a strike");
        Console.WriteLine("0. Exit");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                messageAnalyzer.ShowTopTerroristReport();
                break;

            case "2":
                weaponProvider.ShowStrikeAvailabilty();
                break;

            case "3":
                threatAnalyzer.Display();
                break;

            case "4":
                try
                {
                    strikeExecutor.StrikeExecution();
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