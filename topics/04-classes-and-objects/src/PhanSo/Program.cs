/*
Xử lý phân số

Mục tiêu: 
- Giải quyết một bài toán đơn giản theo phương pháp hướng đối tượng
- Biết xây dựng lớp, tạo đối tượng, sử dụng đối tượng
- Biết thiết lập bao đóng (encapsulation) để che dấu dữ liệu:
    * Phân biệt được trường dữ liệu (fields) và thuộc tính (properties)
    * Đặt mức truy cập private cho các trường dữ liệu
    * Khi cần truy cập đến các trường dữ liệu này, tạo các phương thức dùng chung (public) get và set 
- Dùng quy cách đặt tên (coding conventions) thống nhất (theo đề xuất của Microsoft)
  https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
*/

using System;

//Khai báo lớp Phân số
public class PhanSo
{
    private int _tuSo=0, _mauSo=1; // Đây là dữ liệu riêng (private), không cho phép truy xuất từ bên ngoài lớp

    public int TuSo{        // Thuộc tính (property)
        get{return _tuSo;}  // Đọc giá trị của trường _tuSo
        set{_tuSo = value;} // Thay đổi giá trị của trường _tuSo
    }
    
    public int MauSo{   
        get{return _mauSo;} // Chỉ cho phép đọc, không được thay đổi giá trị biến _mauSo
    }

    public void Nhap()
    {
        Console.Write("Tu so = ");
        _tuSo = Convert.ToInt32(Console.ReadLine());
        do{
            Console.Write("Mau so = ");
            _mauSo = Convert.ToInt32(Console.ReadLine());
            if(_mauSo == 0) Console.WriteLine("Mau so phai != 0");
        }while(_mauSo == 0);
    }   

    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
    }
} // End of class PhanSo

// Main program 
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng phân số
        PhanSo p = new PhanSo();
        p.Nhap();   // Gọi phương thức nhập
        p.Xuat();
        Console.WriteLine("Tu so = {0}", p.TuSo);   // Thực hiện được vì thuộc tính TuSo cho phép đọc {get;} giá trị _tuSo
        Console.WriteLine("Mau so = {0}", p.MauSo); // Thực hiện được vì thuộc tính MauSo cho phép đọc {get;} giá trị _mauSo       
        p.TuSo = 10;                                // Thực hiện được vì thuộc tính TuSo cho phép thay đổi {set;} giá trị _tuSo
        Console.WriteLine("Tu so = {0}", p.TuSo);       
        // p.MauSo = 10;                            // Không thực hiện được vì thuộc tính MauSo không cho thay đổi {set;} giá trị _mauSo
    }
}