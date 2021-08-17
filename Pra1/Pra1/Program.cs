using System;

namespace Pra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vec = new Vector2D();
            vec.x = 1.0;
            vec.y = 2.0;

            Vector2D vec1 = new Vector2D();
            vec1.x = 3.0;
            vec1.y = 4.0;
            vec.Add(vec1);
            Console.WriteLine("{0}:{1}", vec.x, vec.y);
            vec.Sub(vec1);
            Console.WriteLine("{0}:{1}", vec.x, vec.y);
            vec.Mul(8.0);
            Console.WriteLine("{0}:{1}", vec.x, vec.y);
            double result = vec.DotProduct(vec1);
            Console.WriteLine("{0}", result);

        }
    }
}
