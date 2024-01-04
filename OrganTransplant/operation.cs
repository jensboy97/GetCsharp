namespace ConsoleApp1;

public class operation
{
    private static Random random = new Random();
    private int randomNumber = random.Next(1, 101);
    private Person _bernt = new Person("Bernt");
    private Person _kåre = new Person("Kåre");
    private Organ _kNyre = new Organ("kåres nyre");
    private Organ _bNyre = new Organ("Bernts nyre");
    private List<Organ> _organs = new List<Organ>();
    private int Kidneys = 0;

//gjøre at man først må sjekke nyren, hvis det er suksess så legger man nyren inn i en liste som man kan bruke operasjon
    public void Intro()
    {
        Console.WriteLine($"Det har vært en ulykke og {_bernt.Name} trenger en ny nyre.\n" +
                          $"Heldigvis tilbyr {_kåre.Name} å gi en nyre til {_bernt.Name}.\n" +
                          $"på sykehuset må de bekrefte at {_kNyre.Type} er riktig for {_bernt.Name}");
        Console.ReadKey();
        Meny();
    }
    public void Meny()
    {
        Console.WriteLine("trykk 1 for å sjekke om nyren passer\n" +
                          "trykk 2 for å operere\n" +
                          "trykk 3 for å ikke gjøre operasjonen\n" +
                          "trykk 4 for å se liste med nyrer");
        
        char choice = Console.ReadKey().KeyChar;
        switch (choice)
        {
            case '1':
                CheckOrgan();
                break;
            case '2':
                PrepareSurgery();
                break;
            case '3':
                Console.WriteLine("Det var meget synd! Bernt kommer ikke til å greie seg.");
                Console.ReadKey();
                Meny();
                break;
            case '4':
                 OrganList();
                break;
            default:
                Console.WriteLine("ikke gyldig! tast enten 1 eller 2");
                Console.ReadKey();
                return ;
        }
    }

    private void CheckOrgan()
    {
        if (95 <= randomNumber)
        {
         Console.WriteLine($"Dessverre er {_kNyre.Type} ødelagt av alkohol og kan ikke brukes, prøve igjen!");
         Console.ReadKey();
         Console.Clear();
         Meny();
        }
        else
        {
         Console.WriteLine($"{_kNyre.Type} passer perfekt! {_bernt.Name} har nå en nyre for operasjon");  
         Console.ReadKey();
         _organs.Add(new Organ($"{_kNyre.Type}"));
         Kidneys++;
         Meny();
        }
    }

    private void PrepareSurgery()
    {
        if (0 >= Kidneys)
        {
         Console.WriteLine("du har ingen nyrer og kan ikke operere!");
         Console.ReadKey();
         Meny();
        }
        else
        {
            Console.WriteLine("alt er klart for operasjon");
            Console.ReadKey();
            Operate();
        }
    }
    private void Operate()
    {
        Console.WriteLine("Bernt skal nå opereres og har 95% sjanse for suksess");
        Console.ReadKey();
        
    if (95<=randomNumber)
    {
        Console.WriteLine("Operasjonen var dessverre ikke vellykket, Bernt døde! ");
        Console.ReadKey();
        Console.Clear();
        Intro();
    }
    else
    {
        Console.WriteLine("operasjonen var vellykket, Bernt vil leve!");
        Console.ReadKey();
        Kidneys--;
        Meny();
    }
    }

    private void OrganList()
    {
        foreach (var organ in _organs)
        {
            Console.WriteLine(organ.Type);
        }
        Console.ReadKey();
        Meny();
    } 
}