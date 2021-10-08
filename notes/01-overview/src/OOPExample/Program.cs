/*
Minh họa lập trình hướng đối tượng
Input: Mảng các số nguyên
Output: Mảng sắp xếp tăng dần
*/
using System;

namespace OOPExample
{
    public class Array{
        private int[] numbers;

        // constructor
        public Array(int elements)
        {
            numbers = new int[elements];
            Random randNum = new Random();
            for(int i=0; i < numbers.Length; i++)
                numbers[i] = randNum.Next(0,20);
        }

        // Display the numbers
        public void Print()
        {
            Console.WriteLine("{0}", string.Join(", ", numbers));
        }
    }

    // Chương trình chính    
    class Program
    {
        static void Main(string[] args)
        {
            Array myNumbers = new Array(6);
            myNumbers.Print();
        }
    }
}
