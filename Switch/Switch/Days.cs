namespace Switch;

public class Days
{
    // public int Mandag = 1;
    // public int Tirsdag = 2;
    // public int Onsdag = 3;
    // public int Torsdag = 4;
    // public int Fredag = 5;
    // public int Lørdag = 6;

    public void Switcharu()
    {
        Console.WriteLine("velg et tall mellom 1-7");
        int Input = Convert.ToInt32(Console.ReadLine());
        switch (Input)
        {
            case 1:
                Console.WriteLine("Mandag");
                break;

            case 2:
                Console.WriteLine("Tirsdag");
                break;

            case 3:
                Console.WriteLine("Onsdag");
                break;

            case 4:
                Console.WriteLine("Torsdag");
                break;

            case 5:
                Console.WriteLine("Fredag");
                break;

            case 6:
                Console.WriteLine("Lørdag");
                break;

            case 7:
                Console.WriteLine("Søndag");
                break;

            default:
                Switcharu();
                break;
        }
    }
}
    