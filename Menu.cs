using System;
using IronSwords;

public class Menu
{
    private TopTerroristReport MessageAnalyzer = new TopTerroristReport();
    private StrikeAvailability WeaponProvider = new StrikeAvailability();
    private TargetPrioritization ThreatAnalyzer = new TargetPrioritization();
    private AllMessages ShowMessage = new AllMessages();
    private Strike StrikeExecutor = new Strike();
    private EliminatedTerrorist EliminatedTerrorist = new EliminatedTerrorist();

    public void Show()
    {
        Console.WriteLine("\n\nSelect an action:");
        Console.WriteLine("1. The terrorist with the most intelligence reports");
        Console.WriteLine("2. Get strike weapon information");
        Console.WriteLine("3. Find the most dengerous terrorist");
        Console.WriteLine("4. Execute a strike");
        Console.WriteLine("5. Show messages for living terrorist");
        Console.WriteLine("6. The terrorist who were eliminated");
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

            case "5":
                ShowMessage.ShowAllMessagesForLivingTerrorist();
                break;

            case "6":
                EliminatedTerrorist.PrintDeadTerrorist();
                break;


            case "0":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid selection. please try again");
                break;
        }
        Console.WriteLine("Press any key to continu...");
        Console.ReadKey();
        Console.Clear();


    }

}