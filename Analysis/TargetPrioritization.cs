using System;
using IronSwords;

public class TargetPrioritization
{

    public int BestWeaponPoints { get; private set; } // שדה לשמירת רמת הסיכון הגבוהה ביותר

    public ITerrorist dangerTerrorist = null; // שדה לשמירת אובייקט המחבל המסוכן ביותר

    public string location { get; private set; }
    public DateTime TimeStamp { get; private set; }


    public TargetPrioritization()
    {
        TheMostDangerousTerrorist();
    }

    public void TheMostDangerousTerrorist()
    {
        this.BestWeaponPoints = 0;
        foreach (var message in Aman.ReadList())
        {
            if (message.Terrorist.IsLife) // בדיקה רק על המחבלים החיים
            {
                int score = 0;
                foreach (var i in message.Terrorist.Weapons)  // מעבר על רשימת כלי הנשק של המחבל ודירוג תוך כדי
                {
                    if (i == "knife")
                    {
                        score += 1;
                    }

                    else if (i == "gun")
                    {
                        score += 2;
                    }

                    else if (i == "M16" || i == "AK47")
                    {
                        score += 3;
                    }
                }
                score *= message.Terrorist.Rank; // קביעת רמת סיכון ע"פ הנוסחה
                if (score > this.BestWeaponPoints) // עדכון רמת הסיכון הגבוהה ביותר והמחבל המסוכן ביותר 
                {
                    this.BestWeaponPoints = score;
                    this.dangerTerrorist = message.Terrorist;
                    this.location = message.Location;
                    this.TimeStamp = message.Timestamp;
                }
                

            }
        }
        if (this.BestWeaponPoints == 0)
        {
            this.dangerTerrorist = null;
            this.location = null;
        }
    }

    public void Display()  // דוח על המחבל המסוכן ביותר
    {
        TheMostDangerousTerrorist();
        if (this.dangerTerrorist == null)
        {
            Console.WriteLine("No live terrorists were found.");
        }
        else
        {
            Console.WriteLine("Most Dangerous Terrorist Report");
            Console.WriteLine(new string('=', 40));

            Console.WriteLine($"Name                : {dangerTerrorist.Name}");
            Console.WriteLine($"ID                  : {dangerTerrorist.Id}");
            Console.WriteLine($"Rank                : {dangerTerrorist.Rank}");
            Console.WriteLine($"Weapon Score        : {BestWeaponPoints}");
            Console.WriteLine($"Weapons             : {string.Join(", ", dangerTerrorist.Weapons)}");
            Console.WriteLine($"Last Known Location : {location}");
            Console.WriteLine($"Timestamp           : {TimeStamp}");

            Console.WriteLine(new string('=', 40));

        }

    }
    
}