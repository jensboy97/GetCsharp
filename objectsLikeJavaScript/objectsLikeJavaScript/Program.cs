// See https://aka.ms/new-console-template for more information

namespace objectsLikeJavaScript


{
    
    public class LikeJs
    {
        public static void Main()
        {
            var pikachu = new Pokemon("Pikachu", 50, 21);
            var charmander = new Pokemon("Charmander", 62, 15);
            Console.WriteLine($"Name: {pikachu.Name} Health:{pikachu.Health} Level:{pikachu.Level}");
            Console.WriteLine($"Name: {charmander.Name} Health:{charmander.Health} Level:{charmander.Level}");
            
        }
    }
}