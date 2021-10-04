/*
Lập trình xử lý phân số.

Mục tiêu: 
- Giải quyết một bài toán đơn giản theo pp HĐT
- Biết cách xây dựng lớp, tạo đối tượng, sử dụng đối tượng (truyền thông điệp)
- Biết cách thiết lập sự đóng gói (encapsulation) để che dấu dữ liệu "nhạy cảm"
    * Phân biệt được trường dữ liệu (fields) và thuộc tính (properties)
    * Đặt mức truy cập private cho các trường dữ liệu
    * Khi cần truy cập đến các trường dữ liệu này, tạo các phương thức dùng chung (public) get và set 
*/

using System;


/*
Khai báo lớp Phân số
*/
public class PhanSo
{
    private int _tuSo, _mauSo; // Đây là dữ liệu riêng (private), không cho phép truy xuất từ bên ngoài lớp

    public int tuSo{
        get{return _tuSo;} // Thuộc tính (property), có thể truy xuất từ bên ngoài lớp (public) thông qua hàm get (lấy giá trị)
        set{_tuSo = value;} // và set (đặt giá trị)
    }
    
    public int mauSo{
        get{return _mauSo;} // Thuộc tính (property), có thể truy xuất từ bên ngoài lớp (public) thông qua hàm get (lấy giá trị)
        private set{if(value != 0) _mauSo = value;} // và set (đặt giá trị)    
    }

    public void Nhap()
    {
        Console.Write("Tu so =");
        _tuSo = Console.ReadLine();
        
    }   
    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng phân số
        PhanSo p = new PhanSo();
        p.tuSo = 5;
        p.Xuat();
    }
}

