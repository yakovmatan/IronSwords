using System;
using IronSwords;

public class TargetPrioritization
{
 
    public int tempWeaponPoints { get; private set; } = 0; // שדה זמני לשמירת רמת סיכון המחבל
    public int BestWeaponPoints { get; private set; } = 0; // שדה לשמירת רמת הסיכון הגבוהה ביותר

    public ITerrorist dangerTerrorist = Aman.ReadList()[0].Terrorist; // שדה לשמירת אובייקט המחבל המסוכן ביותר

    public string location;


    public TargetPrioritization()
    {
        TheMostDangerousTerrorist();
    }

    public void TheMostDangerousTerrorist()
    {
        foreach (var message in Aman.ReadList())
        {
            if (message.Terrorist.isLife) // בדיקה רק על המחבלים החיים
            {
                foreach (var i in message.Terrorist.weapone)  // מעבר על רשימת כלי הנשק של המחבל ודירוג תוך כדי
                {
                    if (i == "knife")
                    {
                        this.tempWeaponPoints += 1;
                    }

                    else if (i == "gun")
                    {
                        this.tempWeaponPoints += 2;
                    }

                    else if (i == "M16" || i == "AK47")
                    {
                        this.tempWeaponPoints += 3;
                    }
                }
                this.tempWeaponPoints *= message.Terrorist.rank; // קביעת רמת סיכון ע"פ הנוסחה
                if (this.tempWeaponPoints > this.BestWeaponPoints) // עדכון רמת הסיכון הגבוהה ביותר והמחבל המסוכן ביותר 
                {
                    this.BestWeaponPoints = this.tempWeaponPoints;
                    this.dangerTerrorist = message.Terrorist;
                    this.location = message.Location;
                }

            }
        }
    }

    public void Display()  // דוח על המחבל המסוכן ביותר
    {

        Console.WriteLine($"Name: {this.dangerTerrorist.name}\nRank: {this.dangerTerrorist.rank}\nquality score: {this.BestWeaponPoints}\nweapon: {string.Join(", ",this.dangerTerrorist.weapone)}\nlocation: {this.location}");
    }

    
}