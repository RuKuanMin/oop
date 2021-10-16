/*
Tính tiền taxi dựa vào quãng đường đi và bảng giá
Bảng giá:
Số km <= 1: 15000 đ
Từ km thứ 2 đến km 5: 13500 đ/km
Từ km thứ 6 trở đi: 11000 đ/km
Nếu số km > 100 thì giảm 10% tổng số tiền phải trả.

Input: Quãng đường (km)
Output: Số tiền phải trả
*/
using System;

const double Gia1=15000, Gia2=13500, Gia3=11000;
double quangDuong, soTien=0;
bool inputOK=false;

// Input
Console.WriteLine("Nhap quang duong di (km):");

/*
Kiểm soát việc nhập dữ liệu 
-> yêu cầu nhập lại cho đến khi thỏa mãn là giá trị số > 0
*/
do{
    // Hàm ReadLine() trả về chuỗi ký tự nhập từ bàn phím 
    // -> cần thực hiện chuyển chuỗi ký tự sang kiểu dữ liệu phù hợp
    inputOK = double.TryParse(Console.ReadLine(), out quangDuong);
    if(!inputOK || quangDuong <= 0) 
        Console.WriteLine("Quang duong phai la so > 0.");
} while(!(inputOK && quangDuong > 0));

// Process 
if(quangDuong <= 1) 
    soTien = Gia1;
else    if(quangDuong <= 5) 
            soTien = Gia1 + (quangDuong - 1) * Gia2;
        else    if(quangDuong <= 100) 
                    soTien = Gia1 + (quangDuong - 1) * Gia2 + (quangDuong - 5) * Gia3;
                else 
                    soTien = (Gia1 + (quangDuong - 1) * Gia2 + (quangDuong - 5) * Gia3) * 0.9;
/// Output
Console.WriteLine("Quang duong: {0:0.00} (km), so tien: {1:C} (VND)", quangDuong, soTien);
