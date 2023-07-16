using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarcCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: apple");


            char[] chars = new char[] { 'a', 'p', 'p', 'l', 'e' };

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')
                {
                    a++;
                }
                else if (chars[i] == 'p')
                {
                    b++;
                }
                else if (chars[i] == 'l')
                {
                    c++;
                }
                else if (chars[i] == 'e')
                {
                    d++;
                }           
            
            }

            Console.WriteLine("The frequency of the characters are:");
            Console.WriteLine("Character a:" + " " + a + " " + "times");
            Console.WriteLine("Character p:"+" " + b + " " + "times");
            Console.WriteLine("Character l:"+" " + c + " " + "times");
            Console.WriteLine("Character e:"+" " + d + " " + "times");
        }
    }
}
