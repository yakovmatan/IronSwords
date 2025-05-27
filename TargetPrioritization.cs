using System;
using IronSwords;

public class TargetPrioritization
{
 
    public int BestWeaponPoints { get; private set; } // שדה לשמירת רמת הסיכון הגבוהה ביותר

    public ITerrorist dangerTerrorist = null; // שדה לשמירת אובייקט המחבל המסוכן ביותר

    public string location;
    public DateTime TimeStamp;


    public TargetPrioritization()
    {
        TheMostDangerousTerrorist();
    }

    public void TheMostDangerousTerrorist()
    {
        this.BestWeaponPoints = 0;
        foreach (var message in Aman.ReadList())
        {
            if (message.Terrorist.isLife) // בדיקה רק על המחבלים החיים
            {
                int score = 0;
                foreach (var i in message.Terrorist.weapone)  // מעבר על רשימת כלי הנשק של המחבל ודירוג תוך כדי
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
                score *= message.Terrorist.rank; // קביעת רמת סיכון ע"פ הנוסחה
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

            Console.WriteLine($"Name: {this.dangerTerrorist.name}\nRank: {this.dangerTerrorist.rank}\nquality score: {this.BestWeaponPoints}\nweapon: {string.Join(", ", this.dangerTerrorist.weapone)}\nlocation: {this.location}");

        }

    }
    
}