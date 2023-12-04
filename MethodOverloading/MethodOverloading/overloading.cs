namespace MethodOverloading;

public class overloading
{
       public string Name = "terje";
       public int Age;
       
       
    public overloading(string name,int age)
    {
        Name = name;
        Age = age;
    }

    public overloading()
    {
        
    }

    public void PrintOut()
    {
        Console.WriteLine($"Hei og velkommen {Name}");
    }
}