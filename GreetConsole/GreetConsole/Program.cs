// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine("Hei, hva heter du?");
string Name = Console.ReadLine();
Console.WriteLine($"hyggelig å treffe deg {Name}! hvor gammel er du? ");
string Age = Console.ReadLine();
Console.WriteLine($"{Age}år det er en fin alder, hvor er du ifra?");
string Where = Console.ReadLine();
Console.WriteLine($"Kult så du heter {Name}, er {Age}år og kommer ifra {Where}");
