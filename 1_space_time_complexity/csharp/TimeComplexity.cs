
using System;

namespace SpaceTimeComplexity
{

    public class TimeComplexity
    {

        static public void Oone()
        {
            // “Hello World” is printed only once on the screen. 
            // Hence the complexity is O(1).
            Console.WriteLine("Hello World");
        }
        static public void On()
        {
            // The loop runs n times. 
            // Hence the complexity is O(n).
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
        static public void Ologn()
        {
            // The loop runs log(n) times. 
            // Hence the complexity is O(log(n)).
            int n = 10;
            for (int i = 1; i < n; i = i * 2)
            {
                Console.WriteLine("Hello World");
            }
        }
        static public void On2()
        {
            // The loop runs n^2 times. 
            // Hence the complexity is O(n^2).
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Hello World");
                }
            }
        }
        static public void On3()
        {
            // The loop runs n^3 times. 
            // Hence the complexity is O(n^3).
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine("Hello World");
                    }
                }
            }
        }
        static public void O2n()
        {
            // The loop runs 2^n times. 
            // Hence the complexity is O(2^n).
            int n = 10;
            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                Console.WriteLine("Hello World");
            }
        }
        static public void Onfact()
        {
            // The loop runs n! times. 
            // Hence the complexity is O(n!).
            int n = 10;
            for (int i = 0; i < Factorial(n); i++)
            {
                Console.WriteLine("Hello World");
            }
        }
        static public void OlognLogn()
        {
            // The loop runs log(n) * log(n) times. 
            // Hence the complexity is O(log(n) * log(n)).
            int n = 10;
            for (int i = 1; i < n; i = (int)Math.Pow(i, 2))
            {

                Console.WriteLine("Hello World");
            }
        }
    }
}
