using System;

namespace _3._4_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|     x       |      y       |");
            for (double x = 2; x <= 4; x += 0.2)
            {
                double y = Math.Pow(x, 3) + 3 * Math.Pow(x, 2) - 3;
                Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
            }
        }
    }
}
