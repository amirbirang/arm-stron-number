using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int num = 100; num <= 999;num++)
            {
                int help, digit1, digit2, digit3;
                digit3 = num % 10;
                help = num / 10;
                digit2 = help % 10;
                digit1 = help / 10;
                digit1 = digit1 * digit1 * digit1;
                digit2 = digit2 * digit2 * digit2;
                digit3 = digit3 * digit3 * digit3;
                if(num==digit3+digit2+digit1)
                {
                    Console.WriteLine(num);
                }
               
            }
            Console.ReadKey();
        }
    }
}
