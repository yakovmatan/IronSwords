using System;
using System.Collections.Generic;
using IronSwords;

static class Hamas
{
    public static string DateOfFormation { get; } = "14.12.1987";
    public static string CurrentCommander { get; private set; } = "sinuwar";
    private static List<ITerrorist> listOfTerrorists = new List<ITerrorist>();
    
    public static void AddTerrorist(ITerrorist terrorist)
    {
        listOfTerrorists.Add(terrorist);
    }
    public static IReadOnlyList<ITerrorist> ReadList()
    {
        return listOfTerrorists.AsReadOnly();
    }
}