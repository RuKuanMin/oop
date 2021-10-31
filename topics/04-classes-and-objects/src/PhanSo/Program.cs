/*
Xử lý phân số

Mục tiêu: 
- Giải quyết một bài toán đơn giản theo phương pháp hướng đối tượng
- Biết xây dựng lớp, tạo đối tượng, sử dụng đối tượng
- Biết thiết lập bao đóng (encapsulation) để che dấu dữ liệu:
    * Phân biệt được trường dữ liệu (fields) và thuộc tính (properties)
    * Đặt mức truy cập private cho các trường dữ liệu
    * Khi muốn cho phép truy cập đến các trường dữ liệu này từ bên ngoài lớp, tạo thuộc tính dùng chung (public)
      với phương thức get (cho phép đọc), set (cho phép thay đổi)
- Dùng quy cách đặt tên (coding conventions) thống nhất (theo đề xuất của Microsoft)
  https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

*/

using System;

// Main program 
class Program
{
    static void Main(string[] args)
    {

        PhanSo p1 = new PhanSo(); // Tạo đối tượng phân số
        p1.Nhap();   // Gọi phương thức Nhap()
        p1.Xuat();   // Gọi phương thức Xuat()
        Console.WriteLine("Tu so = {0}", p1.TuSo);   // Thực hiện được vì thuộc tính TuSo cho phép đọc {get;} giá trị _tuSo
        Console.WriteLine("Mau so = {0}", p1.MauSo); // Thực hiện được vì thuộc tính MauSo cho phép đọc {get;} giá trị _mauSo       
        //p1.TuSo = 10;                                // Thực hiện được vì thuộc tính TuSo cho phép thay đổi {set;} giá trị _tuSo
        Console.WriteLine("Tu so = {0}", p1.TuSo);       
        // p.MauSo = 10;                            // Không thực hiện được vì thuộc tính MauSo không cho thay đổi {set;} giá trị _mauSo
        // Tối giản phân số
        p1.ToiGian();
        // In ra phân số tối giản:
        Console.WriteLine("Phan so toi gian:");
        p1.Xuat();
        // Tạo phân số sử dụng hàm thiết lập
        PhanSo p2 = new PhanSo(21,49);
        p2.Xuat();
        p2.ToiGian();
        p2.Xuat();
        // p1 = p1 + p2
        p1.Cong(p2);
        // In ra p1 sau khi cộng thêm p2
        Console.WriteLine("Tong 2 phan so:");
        p1.ToiGian();
        p1.Xuat();

    }
}

