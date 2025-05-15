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
            String DecryptionOfTheCipher(String _cipher)
            {
                string arranged = null;
                for (int i = 0; i < _cipher.Length; i++)
                {
                    bool notLetter = false;
                    for (int j = 0; j < 26; j++)
                    {
                        if (_cipher[i] == 'A' + j)
                        {
                            arranged += ((char)('Z'- (j)));
                            notLetter = true;
                        }
                        if (_cipher[i] == 'a' + j)
                        {
                            arranged += ((char)('z' - (j)));
                            notLetter = true;
                        }
                    }
                    if (notLetter == false)
                    {
                        arranged += _cipher[i];
                    }
                }
                return arranged;
            }
            String Cipher = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";
            Console.WriteLine(DecryptionOfTheCipher(Cipher));
        }
    }
}
