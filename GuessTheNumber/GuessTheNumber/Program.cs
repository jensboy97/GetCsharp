// See https://aka.ms/new-console-template for more information
namespace GuessTheNumber;
   
class Guess
    {
        static void Main()
        {
            guessGame();
        }

        static void guessGame()
        {
            Console.WriteLine("skriv et tall mellom 0 og 100");
            int answer = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);

            while (answer != randomNumber)
            {
                string text = (answer < randomNumber) ? "Tallet er høyere!" : "Tallet er lavere!";
                Console.WriteLine(text);
                answer = Convert.ToInt32(Console.ReadLine());
            }

            if (answer == randomNumber)
            {
                Console.WriteLine("Riktig!");
                Console.WriteLine("trykk enter for å spille igjen");
                Console.ReadLine();
                guessGame();

            }
        }
    }
