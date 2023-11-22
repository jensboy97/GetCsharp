namespace programcs;

public class Randomizer
{
    public void GetHobby()
    {
        Console.WriteLine("Hva heter du?");
        string Name = Console.ReadLine();
        Console.WriteLine($"Heisann {Name}, din nye hobby er {Rando()}");
    }

    public string Rando()
    {
        Random rand = new Random();
        var randomNumber = rand.Next(0, 5);
        if (randomNumber == 0)
        {
            return "ølsmaking";
        }
        else if (randomNumber == 1)
        {
            return "koding";
        }
        else if (randomNumber == 2)
        {
            return "bading";
        }
        else if (randomNumber == 3)
        {
            return "sykling";
        }
        else
        {
            return "gaming";
        }
    }
}