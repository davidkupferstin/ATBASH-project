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
            String chiper = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";
            warning_message(find_dangerous_word, chiper);
        }
        static String DecryptionOfTheCipher(String _cipher)
        {
            string Arranged = null;
            for (int i = 0; i < _cipher.Length; i++)
            {
                if (_cipher[i] >= 'A' && _cipher[i] <= 'Z')
                {
<<<<<<< HEAD
                    Arranged += ((char)(('A' + 'Z') - (_cipher[i])));
                }
                else if (_cipher[i] >= 'a' && _cipher[i] <= 'z')
                {
                    Arranged += ((char)(('a' + 'z') - (_cipher[i])));
=======
                    arranged += ((char)(('A' + 'Z') - (_cipher[i])));
                }
                else if (_cipher[i] >= 'a' && _cipher[i] <= 'z')
                {
                    arranged += ((char)(('a' + 'z') - (_cipher[i])));
>>>>>>> 7892f540b71c2d674b03477dc913647bf048c050
                }
                else
                {
                    Arranged += _cipher[i];
                }
            }
            return Arranged;
        }




        static Dictionary<string, string> find_dangerous_word(string message, string decrypted_message)

        {
            string decripted_message = DecryptionOfTheCipher(message);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] word_array = decripted_message.Split(' ');
            dict["decripted_message"] = decripted_message;
            dict["message"] = message;
            dict["dangerous word"] = "";
            int points = 0;
            string[] dangerous_word = { "bomb", "nukhba", "fighter", "rocket", "secret","attac" };
            foreach (string word in word_array)
            {
                if (dangerous_word.Contains(word.ToLower()) || dangerous_word.Contains(word.Substring(0, word.Length - 1).ToLower()))
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

    

     static void warning_message(Func<string, string, Dictionary<string, string>> func, string message)
        {
            string decripted_message = DecryptionOfTheCipher(message) ;
            Dictionary<string, string> dict = func(message, decripted_message);
            int points = Int16.Parse(dict["points"]);
            if (points >= 1 && points <= 5)
            {

                dict["message"] += " \nWARNING";
                Console.WriteLine($"the message is:\n {dict["message"]}\nthe decripted message is:\n {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");

            }
            else if (points >= 6 && points <= 10)
            {
                dict["message"] += "\nDANGER";
                Console.WriteLine($" the message is:\n {dict["message"]}\nthe decripted message is:\n {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");
            }
            else if (points >= 11 && points <= 15)
            {
                dict["message"] += "\nULTRA AlErT";
                Console.WriteLine($" the message is:\n {dict["message"]}\nthe decripted message is:\n {dict["decripted_message"]}\n" +
                    $"the total points is: {dict["points"]}");
            }
        }

      


    }
}



    

