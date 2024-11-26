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
        static string email = "Моя почта: er626677@gmail.com";
        static string emailPattern = @"[a-zA-Z0-9]+@[A-Za-z]+\.[A-Za-z]+$";
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
        public static void email_pattern(string input, string match)
        {
            Match m = Regex.Match(input, match);
            if (m.Success)
            {
                Console.WriteLine("Почта найдена!");
            }
            else
            {
                Console.WriteLine("Почта не найдена!");
            }
        }
        static void Main(string[] args)
        {
            match_string(number, pattern);
            email_pattern(email, emailPattern);
        }
    }
}
