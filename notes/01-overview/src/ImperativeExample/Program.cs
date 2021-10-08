/*
Minh họa lập trình hướng mệnh lệnh với C#
Sắp xếp dãy số tăng dần 
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;

namespace ImperativeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một mảng số nguyên
            int n=6;
            int[] numbers = new int[] {3,8,2,1,6,5};
            
            // Sắp xếp tăng dần - giải thuật đổi chỗ trực tiếp
            for(int i=0; i < n-1; i++)
                for(int j=i+1; j < n; j++)
                    if(numbers[i] > numbers[j])
                    {
                        int t = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = t;
                    }

            // In ra danh sách đã sắp xếp
            Console.WriteLine("Mang tang dan:");
            for(int i=0; i < n; i++)
                Console.Write("{0} ", numbers[i]);
                
            // Wait for a key press
            Console.ReadKey();
        }
    }
}
