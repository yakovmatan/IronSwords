using System.Collections.Generic;

public static class IDF
{
    private static string DateOfEstablishment = "26/02/1948";

    private static string CurrentCommander = "eyal zamir";

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