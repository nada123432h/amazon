using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int nSum = 0;
            int nOdd = 0;
            int nEven = 0;
            for(int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                nEven=(x%2==0) ? nEven += x : nOdd += x;


                nSum += x;
            }
            Console.WriteLine(nSum);
            Console.WriteLine(nOdd);
            Console.WriteLine(nEven);

        }
    }
}
