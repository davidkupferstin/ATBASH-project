using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decrypt_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] function = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            String DecryptionOfTheCipher(String _cipher, char[] _function)
            {              
                
                List<char> arguments = new List<char>();
                String argumentses1 = null;
                for (int i = 0; i < _cipher.Length -1; i++) 
                {
                    if (_cipher[i] == ' ')
                    {
                        arguments.Add(' ');
                    }
                    else
                    {
                        for (int j = 0; j < _function.Length - 1; j++)
                        {
                            if (_cipher[i] == _function[j])
                            {                            
                                arguments.Add(_function[_function.Length - (j + 1)]);
                            }
                        }

                    }
                    
                }
                foreach (var item in arguments)
                {
                    argumentses1+= item;
                }
                return argumentses1;
            }
            String Cipher = "gsrh rh z yzw vmnvb hvxvig";
            Console.WriteLine(DecryptionOfTheCipher(Cipher, function));
        }
    }
}
