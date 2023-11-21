using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabeltilordning
{
    internal class Datatyper
    {
        int Tall1 = 2;
        int Tall2 = 4;
        string nullverdi = "denne motoden returnerer ingenting";

        public int ReturnWholeNumber(int nr1, int nr2)
        {

            return nr1 + nr2;
        }

        public string ReturnString(string tekst)
        {
            return tekst; 
        }

        public void run()
        {
            Console.WriteLine($"dette er en int: {ReturnWholeNumber(Tall1, Tall2)}");
            Console.WriteLine($"dette er en string {ReturnString(nullverdi)} ");
        }
    }
}
