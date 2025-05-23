using IronSwords;

public class Strike
{
    private ITerrorist target;
    private string location;

    public Strike()
    {
        TargetPrioritization prioritization = new TargetPrioritization();
        this.target = prioritization.dangerTerrorist;
        this.location = prioritization.location;
    }

    public void StrikeExecution()
    {
        foreach (var weapon in IDF.ReadList())
        {
            if (string.Join(",",weapon.target).Contains(location)) // בודק האם הכלי מתאים לבדוק את המטרה
            {
                weapon.Attack();
            }
        }
    }
}