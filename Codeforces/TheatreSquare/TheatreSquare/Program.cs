using System;

namespace TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long[] arr = Array.ConvertAll(input.Split(" "), long.Parse);
            long x, y;
            //For geting value of n that means width
            if (arr[0] % arr[2] == 0)
            {                                       //arr[0] means n
                x = (arr[0] / arr[2]);               //arr[2] means a
            }
            else
            { x = arr[0] / arr[2] + 1; }

            //For geting value of m that means height
            if (arr[1] % arr[2] == 0)
            {                                   //arr[1] means m
                y = (arr[1] / arr[2]);          //arr[2] means a
            }
            else
            { y = arr[1] / arr[2] + 1; }

            Console.WriteLine(x * y);
        }
    }
}
