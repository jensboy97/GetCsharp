namespace AbaxSimple;

public class Plane: Vehicle
{
    private int wingSpan;
    private int maxLoad;
    private int ownWeight;
    private string flightClass;
    public Plane(string regNr, int power, int wingSpan, int maxLoad, int ownWeight, string flightClass) : base(regNr, power)
    {
        this.wingSpan = wingSpan;
        this.maxLoad = maxLoad;
        this.ownWeight = ownWeight;
        this.flightClass = flightClass;
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Wing span: {wingSpan}meter\n" +
                          $"Max load: {maxLoad}tons\n" +
                          $"Own weight {ownWeight}tons\n" +
                          $"Flight class: {flightClass}\n");
    }

    public override void Run()
    {
        Console.WriteLine($"{flightClass} {RegNr} is in the skies and rdy for war!");
    }
}