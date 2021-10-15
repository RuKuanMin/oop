/*
Tính tiền taxi dựa vào quãng đường đi và bảng giá
Bảng giá:
Số km <= 1: 15000 đ
Từ km thứ 2 đến km 5: 13500 đ/km
Từ km thứ 6 trở đi: 11000 đ/km
Nếu số km > 100 thì giảm 10% tổng số tiền phải trả.

Input: 
Quãng đường (km): nhập từ bàn phím
Bảng giá
Output: Số tiền phải trả
*/
using System;

namespace TaxiFare
{
    class Program
    {
        static void Main(string[] args)
        {
            double quangDuong, soTien=0;
            Console.WriteLine("Nhap quang duong (km):");
            // quangDuong = Convert.ToDouble(Console.ReadLine());

            bool inputOK = double.TryParse(Console.ReadLine(), out quangDuong);

            if(inputOK)
            {
                if(quangDuong <= 0 ) Console.WriteLine("Khoang cach phai > 0");
                else 
                {
                    if(quangDuong <= 1) soTien = 15000; // hard code
                    else if(quangDuong <= 5) soTien = 15000 + (quangDuong-1) * 13500;
                    else if(quangDuong <= 100) soTien = 15000 + (quangDuong-1) * 13500 + (quangDuong - 5) * 11000;
                    else soTien = (15000 + (quangDuong-1) * 13500 + (quangDuong - 5) * 11000) * 0.9;

                    Console.WriteLine("Quang duong: {0} (km), so tien: {1} (VND)", quangDuong, soTien);
                }          
            }
            else
            {
                Console.WriteLine("Vui long nhap gia tri so km.");
            }
        }
    }
}




