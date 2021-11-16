using System;

namespace jag_är_inte_du
{
    class Program
    {
        static void Main(string[] args)
        {
            //yoooooo
            //dhago tfdoögd

            int a = 333;
            int b = 332;

            Suwitchu(ref a, ref b);

            Console.WriteLine(a + " " + b);
        }

        static void Suwitchu(ref int a, ref int b){
            int a2 = a;
            a = b;
            b = a2;
        }
    }
}
