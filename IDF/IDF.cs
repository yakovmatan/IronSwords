using System.Collections.Generic;

public static class IDF
{
    public static string DateOfEstablishment { get; } = "26/02/1948";

    public static string CurrentCommander { get; private set; } = "eyal zamir";

    private static List<AttackTool> attackTools = new List<AttackTool>();

    public static void AddAttackTool(AttackTool tool)
    {
        attackTools.Add(tool);
    }

    public static IReadOnlyList<AttackTool> ReadList()
    {
        return attackTools.AsReadOnly();
    }
}