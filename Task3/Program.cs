using System.Data.Common;
using System.Linq;

namespace Task3
{
    public class Logic
    {
        public static string CalcFractions(string inputString)
        {
            Dictionary<char, int> dictionary = new();
            foreach (var c in inputString.ToLower())
            {
                if (dictionary.ContainsKey(c) && Char.IsLetter(c))
                    dictionary[c]++;
                else if (Char.IsLetter(c))
                    dictionary[c] = 1;
            }
            
            var totalLetter = dictionary.Values.Sum();

            var outputMsg = "";
            foreach (var pair in dictionary)
                outputMsg += $"{pair.Key} = {(float)pair.Value / totalLetter * 100:F2}%\n";

            return outputMsg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше предложение: ");
            string input = Console.ReadLine();
            var result = Logic.CalcFractions(input);

            Console.WriteLine(result);
        }
    }
}
