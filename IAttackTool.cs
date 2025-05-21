using System.Collections.Generic;

interface IAttackTool
{
    string Name { get; set; }

    int AmountAmmunition { get; set; }

    int fuel { get; set; }

    List<string> target { get; set; }
}