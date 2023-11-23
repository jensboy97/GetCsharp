
public class ifElse
{
    
        
  public static Random rand = new Random();
   public int numberOne = rand.Next(1, 11);
   public int numberTwo = rand.Next(1, 11);
   public int number1 = rand.Next(1, 31);
   public int number2 = rand.Next(1, 31);
   public bool success = true;
    

    public bool Matte1()
    {
        if (numberOne == numberTwo)
        {
            Console.WriteLine($"{success}");
            return success;
        }
        else
        {
            Console.WriteLine("feil!!!");
            return false;
        }
    }

    public int Matte2()
    {
        if (numberOne != numberTwo)
        {
            return numberOne + numberTwo;
        }
        else
        {
            return numberOne * numberTwo; 
        }
    }

    public bool Matte3()
    {
        int sum = number1 + number2;
        Console.WriteLine($" {number1} + {number2} = {sum}");

        if (number1==30||number2 == 30||sum==30)
        {
            
            Console.WriteLine(success);
            return success;
        }
        else
        
        {
            
           Console.WriteLine(false);
           return false; 
        } 
    }
}