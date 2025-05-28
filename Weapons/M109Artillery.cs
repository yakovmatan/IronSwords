using System.Collections.Generic;

public class  M109Artillery : AttackTool
{

    public override List<string> target { get; } = new List<string> { "open area" };


    public M109Artillery():base(3,"M109")
    {
        IDF.AddAttackTool(this);
    }

  


}