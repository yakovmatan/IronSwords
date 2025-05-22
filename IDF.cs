using System.Collections.Generic;

public static class IDF
{
    private static string DateOfEstablishment = "26/02/1948";

    private static string CurrentCommander = "eyal zamir";

    private static List<IAttackTool> attackTools = new List<IAttackTool>();

    public static void AddAttackTool(IAttackTool tool)
    {
        attackTools.Add(tool);
    }

    public static IReadOnlyList<IAttackTool> ReadList()
    {
        return attackTools.AsReadOnly();
    }
}