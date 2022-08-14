using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_to_values
{
    class ValueSwap
    {
        public void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ValueSwap ob = new ValueSwap();

            int x = 100;
            int y = 200;

            Console.WriteLine($"x and y before call: {x} , {y}");
 
            ob.Swap(ref x, ref y);
            Console.WriteLine($"x and y after call: {x} , {y}");

            Console.ReadKey();


        }
    }
}
