using System;

namespace array_mare
{
    class Program
    {
        static void Main()
        {
            int [,] numbers = 
            {
                {1 , 2 , 3},
                {4 , 5 , 6},
                {7 , 8 , 9}, 
            };
            Console.WriteLine(numbers[1,2]);
        }
    }
}