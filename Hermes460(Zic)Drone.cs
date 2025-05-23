using System.Collections.Generic;

public class Hermes460ZikDrone : AttackTool
{

    public override List<string> target { get; } = new List<string> { "people", "cars" };

    public Hermes460ZikDrone():base(3,"ZIK")
    {
        IDF.AddAttackTool(this);
    }





}
    