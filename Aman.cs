using System.Collections.Generic;
using IronSwords;

static class Aman
{
    private static List<IMessage> Messages = new List<IMessage>();

    public static void AddMessage(IMessage message)
    {
        Messages.Add(message);
    }
    public static IReadOnlyList<IMessage> ReadList()
    {
        return Messages.AsReadOnly();
    }
}