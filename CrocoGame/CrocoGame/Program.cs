// See https://aka.ms/new-console-template for more information

namespace CrocoGame;

public class Croco
{
    public static void Main()
    {
        Game();
    }

    
    public static class Score
    {
      public static int points = 0;
    }
    
    
    public static void Game()
    {
        Random rand = new Random();
        int First = rand.Next(1, 31);
        int Second = rand.Next(1, 31);
        char Answer = Check(First, Second);
        if (RightAnswers(First, Second, Answer))
        {
            Score.points++; 
            Console.WriteLine($"bra jobba, du har nå {Score.points} poeng");
        }
        else
        {
            Score.points--; 
            Console.WriteLine($"beklager, du har nå {Score.points} poeng. prøv igjen");
        }
        Game();
    }


     static char Check(int First, int Second)
    {
        Console.WriteLine($"{First}   {Second}");
        string answer = Console.ReadLine();
        char Answer;
        while (!char.TryParse(answer, out Answer))
        {
            Console.WriteLine("svar ugyldig, mulige svar er: \"<\" \"=\" \">\"");
            answer = Console.ReadLine();
        }

        return Answer; 
    } 
    
    public static bool RightAnswers(int First, int Second, char Answer)
    {
        return (First > Second && Answer.Equals('>'))
               || (First < Second && Answer.Equals('<'))
               || (First == Second && Answer.Equals('='));
    }
    
}