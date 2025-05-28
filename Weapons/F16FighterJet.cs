using System.Collections.Generic;

public class F16FighterJet : AttackTool
{
    public override List<string> target { get; } = new List<string> { "buildings" };
    public string OperatedBy { get; } = "pilot";

    public F16FighterJet() : base(8,"F16")
    {
        IDF.AddAttackTool(this);
    }





}