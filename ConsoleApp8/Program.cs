using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    internal class Program
    {
        // \d - любой цифровой символ
        // \w - это любая буква или цифра
        // \. - что угодно
        // {} - количество раз
        static string number = "Легче позвонить чем у кого-то занимать: +7 (917) 084-39-93";
        static string pattern = @"\+\d{1} \(\d{3}\) \d{3}-\d{2}-\d{2}";
        public static void match_string (string input, string match)
        {
            Match m = Regex.Match(input, match);
            if (m.Success) 
            {
                Console.WriteLine("Номер найден!");
            }
            else
            {
                Console.WriteLine("Номер не найден");
            }
        }
        static void Main(string[] args)
        {
            match_string(number, pattern);
        }
    }
}
