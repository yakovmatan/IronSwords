using System.Collections.Generic;

public interface IAttackTool
{
    string Name { get; }

    int AmountAmmunition { get; }

    int fuel { get; }

    List<string> target { get; }
}