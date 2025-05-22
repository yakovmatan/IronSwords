using System.Collections.Generic;
using IronSwords;

static class Aman
{
    private static List<IMessage> messages = new List<IMessage>();

    public static void AddMessage(IMessage message)
    {
        messages.Add(message);
    }
    public static IReadOnlyList<IMessage> ReadList()
    {
        return messages.AsReadOnly();
    }
}