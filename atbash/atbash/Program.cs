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



        static Dictionary<string, string> find_dangerous_word(string message, string decripted_message)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] word_array = decripted_message.Split();
            dict["decripted_message"] = decripted_message;
            dict["message"] = message;
            dict["dangerous word"] = "";
            int points = 0;
            string dangerous_word = "bomb nukhba fighter rocket secret";
            foreach (string word in word_array)
            {
                if (dangerous_word.Contains(word))
                {
                    points++;
                    if (!dict["dangerous word"].Contains(word))
                    {
                        dict["dangerous word"] += $",{word}";
                    }
                }
            }

            dict["points"] = points.ToString();
            return dict;
        }



    }
}
