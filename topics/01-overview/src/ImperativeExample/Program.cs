/*
Minh họa lập trình tuần tự với C#
Sắp xếp dãy số tăng dần 
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;

// Khởi tạo một mảng số nguyên
int n=6;
int[] numbers = new int[] {3,8,2,1,6,5};

int i=0;
OUTER_LOOP:
    int j=i+1;
    INNER_LOOP:
        if(numbers[i] > numbers[j])
            {
                int t = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = t;
            }
        j += 1;
        if(j < n) goto INNER_LOOP;
    i += 1;
    if(i < n-1) goto OUTER_LOOP;

// In ra mảng đã sắp xếp
Console.WriteLine("Mang tang dan:");
i = 0;
LOOP:
    Console.Write("{0} ", numbers[i]);
    i += 1;
    if(i < n) goto LOOP;
                

