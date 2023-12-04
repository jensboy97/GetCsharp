// See https://aka.ms/new-console-template for more information

namespace MethodOverloading;

public class Overloader
{
    
    public static void Main()
    {
        var person = new overloading();
        var person2 = new overloading("Ola", 26);
        person2.PrintOut();
        person.PrintOut();
    }
    
}
