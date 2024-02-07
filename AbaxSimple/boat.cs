namespace AbaxSimple;

public class boat: Vehicle
{
    private int grossTon;
    public boat(string regNr, int power, int topSpeed, int grossTon) : base(regNr, power, topSpeed)
    {
        this.grossTon = grossTon;
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Top speed: {TopSpeed}knot\n" +
                          $"Gross ton: {grossTon}kg\n");
    }

    public override void Run()
    {
        Console.WriteLine($"Boat {RegNr} is ready for fishing in {TopSpeed}knot and to fill up that {grossTon}kg cargo");
    }
}