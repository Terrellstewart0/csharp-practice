﻿using System;
namespace ThisIsATest
{
    public class Fizzbuzz
    {
        public Fizzbuzz()
        {

            Console.WriteLine("hello yall");

            for (var i = 0; i < 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("Fizzbuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }


        }
    }
}
