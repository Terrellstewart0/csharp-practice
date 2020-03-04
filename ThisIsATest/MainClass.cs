using System;

namespace Practice
{
    class SecondClass
    {
        public static void Main(string[] args)
        {

            for (int x = 1; x< 100; x++)
            {
                if (x % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (x % 5 == 0)
                    Console.WriteLine("buzz");
                else if (x % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(x);

            };
            //Fizz buzz! 




        }
    }
}
