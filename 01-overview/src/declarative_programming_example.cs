﻿using System;
using System.Collections.Generic;

namespace DeclarativeProgramming
{
    class Program
    {
        static void Main()
        {
            // Creating a list of numbers
            List<int> numbers = new List<int> { 3, 8, 2, 1, 5, 6 };

            // Sort the list ascending
            numbers.Sort();

            // Print the sorted list
            Console.WriteLine("[{0}]", string.Join(", ", numbers));

            // Wait for a key press
            Console.ReadKey();
        }
    }
}