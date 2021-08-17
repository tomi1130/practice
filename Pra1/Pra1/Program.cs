using System;

namespace Pra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc keisan = new Calc();
            int a = 1, b = 2, c = 3;
            int ans1 = keisan.Add(a, b);
            int ans2 = keisan.Add(a, b, c);

            Console.WriteLine("{0},{1}", ans1, ans2);
        }
    }
}
