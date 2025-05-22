using System;
using System.Collections.Generic;
using IronSwords;

static class Hamas
{
    private static string DateOfFormation = "14.12.1987";
    private static string CurrentCommander = "sinuwar";
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