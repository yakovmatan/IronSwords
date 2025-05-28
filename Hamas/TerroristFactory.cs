using System;
using System.Collections.Generic;

public class TerroristFactory
{
    private List<string> terrorists = new List<string>
    {
    "Abu Karim",
    "Jamal Al-Zein",
    "Khaled Nasir",
    "Fadi Al-Masri",
    "Tariq Haddad",
    "Omar Bakr",
    "Yusuf Mahdi",
    "Samir Qassem",
    "Nabil Rahman",
    "Adnan Zarif",
    "Rami Khatib",
    "Bassam Jaber",
    "Walid Hamdan",
    "Sami Al-Najjar",
    "Zayd Amari",
    "Imad Khalil",
    "Nasser Farouk",
    "Majid Yasin",
    "Ibrahim Salim",
    "Ali Darwish"
    };
    Random rand = new Random();
    public void CreateTerrorist()
    {
        for (int i = 0; i<11; i++)
        {
            int index = rand.Next(terrorists.Count);
            string terrorist = terrorists[index];
            terrorists.RemoveAt(index);
            new Terrorist(terrorist);
        }
    }
    
}