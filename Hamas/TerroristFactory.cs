using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IronSwords.LLM;

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
    public async Task CreateTerrorists(GeminiClient gemini)
    {
        for (int i = 0; i<11; i++)
        {
            int index = rand.Next(terrorists.Count);
            string terrorist = terrorists[index];
            string id = await GetId(gemini);
            new Terrorist(terrorist,id);
        }
    }

    private async Task<string> GetId(GeminiClient gemini)
    {
        return await gemini.SendPromptAsync("Give me a random 9-digit number only, no explanation or text.");
    }
    
}