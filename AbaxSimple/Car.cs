namespace AbaxSimple;

public class Car: Vehicle
{
    private string color;
    private string weightClass;
    public Car(string regNr, int power, int topSpeed, string color, string weightClass) : base(regNr, power, topSpeed)
    {
        
        this.color = color;
        this.weightClass = weightClass;
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Top speed: {TopSpeed}km/h\n" +
                          $"color: {color}\n" +
                          $"Lightweight: {weightClass}\n");
    }

    public override void Run()
    {
        Console.WriteLine($"{weightClass} {color} car with Vin plate: {RegNr} is speeding in {TopSpeed}km/h, and escaping the police");
    } 
}