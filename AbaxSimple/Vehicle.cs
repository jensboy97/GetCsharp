namespace AbaxSimple;

public abstract class Vehicle
{
    protected string RegNr;
    protected int Power;
    protected int TopSpeed;
    

    public Vehicle(string regNr, int power)
    {
        RegNr = regNr;
        Power = power;
    }
    
    public Vehicle(string regNr, int power, int topSpeed)
    {
        RegNr = regNr;
        Power = power;
        TopSpeed = topSpeed;
    }

    public virtual void printInfo()
    {
       Console.WriteLine($"Vin: {RegNr}\n" +
                         $"power: {Power}kw");
    }

    public abstract void Run();
}