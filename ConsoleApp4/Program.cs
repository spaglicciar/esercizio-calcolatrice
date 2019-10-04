using System;
using MyNamespace;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;
            bool success;
            string concatenazione;
                       
            do
            {
                Console.WriteLine("Inserisci il primo numero e premi invio");
                string numero1 = Console.ReadLine();
                success = Int32.TryParse(numero1, out x);
                if (success == false)
                {
                    Console.WriteLine("Il valore inserito non è corretto, riprovare");
                }
            } while (success == false);

            Console.WriteLine("Inserisci il secondo numero e premi invio");
            string numero2 = Console.ReadLine();
            y = Int32.Parse(numero2);

            result = MyClass.Sum(x, y);
            Console.WriteLine("La somma di " + x + " + " + y + " è: " + result);

            concatenazione = MyClass.Sum("Ciao", x);
            Console.WriteLine(concatenazione);

            Console.ReadLine();
        }
    }
}
