/*
Minh họa lập trình hướng đối tượng
Input: Mảng các số nguyên
Output: Mảng sắp xếp tăng dần
*/
using System;

// Khai báo lớp Array chứa mảng số nguyên và các xử lý trên mảng
public class Array{
    private int[] numbers; // Dữ liệu/biến thành viên

    // constructor
    public Array(int elements)
    {
        numbers = new int[elements];
        Random randNum = new Random();
        for(int i=0; i < numbers.Length; i++)
            numbers[i] = randNum.Next(0,20);
    }

    // Phương thức/Hàm thành viên
    public void Print()
    {
        Console.WriteLine("{0}", string.Join(", ", numbers));
    }

    // Sắp xếp tăng dần
    public void Sort()
    {   
        for(int i=0; i < numbers.Length - 1; i++)
            for(int j=i+1; j < numbers.Length; j++)
                if(numbers[i] > numbers[j])
                {
                    int t = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = t;
                }
    }
}

// Chương trình chính    
class Program
{
    static void Main(string[] args)
    {
        // Tạo mảng ngẫu nhiên các số nguyên - gọi phương thức thiết lập (constructor)
        Array myNumbers = new Array(6);
        
        // In mảng - gọi phương thức Print()
        myNumbers.Print();

        // Sắp xếp tăng dần - gọi phương thức Sort()
        myNumbers.Sort();

        // In mảng sau sắp xếp - gọi phương thức Print()
        myNumbers.Print();
    }
}
