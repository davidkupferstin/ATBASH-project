using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }





        static void warning_message(Func<string, string, Dictionary<string, string>> func, string arg1, string arg2)
        {

            Dictionary<string, string> dict = func(arg1, arg2);
            int points = Int16.Parse(dict["points"]);
            if (points >= 1 && points <= 5)
            {

                dict["message"] += " WARNING";
                Console.WriteLine($"the message is: {dict["message"]}\nthe decripted message is: {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");

            }
            else if (points >= 6 && points <= 10)
            {
                dict["message"] += "DANGER";
                Console.WriteLine($" the message is: {dict["message"]}\nthe decripted message is: {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");
            }
            else if (points >= 11 && points <= 15)
            {
                dict["message"] += "ULTRA AlErT";
                Console.WriteLine($" the message is: {dict["message"]}\nthe decripted message is: {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");
            }
        }

      


    }



}
