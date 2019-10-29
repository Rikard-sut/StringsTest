using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsUPG14
{
    class Program
    {
        static Dictionary<string, string> ordbok = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            ordbok.Add(".NET", "platform to write programs.");
            ordbok.Add("CLR", "execution environment for .NET");
            ordbok.Add("NAMESPACE", "hierarchial organization for classes.");

            Console.WriteLine("Ord i ordboken: {0}\n", string.Join(", ", ordbok.Keys));
            Console.ReadKey();
            Console.WriteLine("Skriv in ordet du vill veta förklaringen till.");

            string input = Console.ReadLine().ToUpper();

            if (ordbok.ContainsKey(input))
            {
                Console.WriteLine(string.Format("\n{0} : {1}\n",input, ordbok[input]));
            }
            else
            {
                Console.WriteLine(string.Format("\nOrdboken inehåller ej ordet \"{0}\".\n",input));
            }

            /*
            Console.WriteLine(dict.ContainsKey(input) ? string.Format("\n{0} : {1}\n", input, dict[input])
                : string.Format("\n Ordbok innehåller ej ordet \"{0}\".\n", input));
                */
            Console.ReadKey();
        }
    }
}
