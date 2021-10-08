/*
Sắp xếp dãy số tăng dần theo lập trình hướng mệnh lệnh với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;

namespace ImperativeProgramming
{
    class Program
    {
        static void Main()
        {
            // Khởi tạo một mảng số nguyên
            int[] numbers = new int{3,8,2,1,6,5};
            int n=6;

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
            Console.WriteLine("Mảng tăng dần:");
            for(int i=0; i < n; i++)
                Console.Write("{}  ", numbers[i]);
                
            // Wait for a key press
            Console.ReadKey();
        }
    }
}
