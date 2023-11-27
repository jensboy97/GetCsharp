// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.CompilerServices;

namespace opgLoops;
public class Program
{
    
public static void Main()
{
    ForTerje();
    EachTerje();
    WhileTerje();
}

public static void ForTerje()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Terje");
    }
}

public static void EachTerje()
{
    string text = "TERJE!";
    foreach (var letter in text)
    {
        Console.WriteLine(letter);
    }
}

public static void WhileTerje()
{
    bool TerjeRun = true;
    int i = 0;
    while (TerjeRun == true)
    {
        if (i > 10)
        {
            TerjeRun = false;
        }
        Console.WriteLine("Terje"+i);
        i++;
    }
}
}

