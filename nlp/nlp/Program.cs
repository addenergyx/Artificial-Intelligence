using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nlp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("treasureisland.txt");
            System.Console.WriteLine(input);
            //System.Console.ReadLine();

            System.Console.WriteLine("----------------------");
            int cc = CharCount(input);
            System.Console.WriteLine("----------------------");
            int wc = WhiteSpaceCount(input);
            System.Console.WriteLine("----------------------");
            int vc = VowelCount(input);
            System.Console.WriteLine("----------------------");
            int coc = ConstantCount(input);
            System.Console.WriteLine("----------------------");


            System.Console.WriteLine(cc);
            System.Console.WriteLine(wc);
            System.Console.WriteLine(vc);
            System.Console.WriteLine(coc);
            System.Console.ReadLine();

        }

        private readonly char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        static public int CharCount(string input)
        {
            return input.Split().Length;
        }

        static public int WhiteSpaceCount(string input)
        {
            return input.Count(Char.IsWhiteSpace);
        }

        static public int VowelCount(string input)
        {
            return input.ToLower().Count(x => input.Contains(x));
        }

        static public int ConstantCount(string input)
        {
            return input.ToLower().Count(x => input.Contains(x));
        }
    }
}
