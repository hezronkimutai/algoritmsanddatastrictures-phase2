//  In the above code “Hello World” 
// is printed only once on the screen. 

// Hence the complexity is O(1).
using System;
using SpaceTimeComplexity;
public class GFG
{

    static public void Main()
    {
        Console.WriteLine("O(1) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.Oone();
        Console.WriteLine("O(n) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.On();
        Console.WriteLine("O(2n) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.O2n();
        Console.WriteLine("O(log(n)) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.Ologn();
        Console.WriteLine("O(n^2) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.On2();
        Console.WriteLine("O(n^3) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.On3();
        // Console.WriteLine("O(n^4) Time Complexity");
        // SpaceTimeComplexity.TimeComplexity.Osqrtn();
        Console.WriteLine("O(lognlog(n)) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.Olognlogn();
        Console.WriteLine("O(nlog(n)) Time Complexity");
        SpaceTimeComplexity.TimeComplexity.Onlogn();
    }
}

