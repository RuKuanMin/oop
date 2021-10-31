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

        
        /* Tạo 1 mảng các phân số
            - Tìm & in ra phân số lớn nhất
            - Sắp xếp mảng phân số theo thứ tự tăng dần của giá trị
        
        // Khai báo mảng phân số
        const int Number_Of_Elements = 5;
        PhanSo[] psList = new PhanSo[Number_Of_Elements];
        // Nhập danh sách phân số
        for(int i=0; i < Number_Of_Elements; i++)
        {
            // Phải khởi tạo từng đối tượng
            psList[i] = new PhanSo();
            Console.WriteLine("Nhap phan so thu {0}", i+1);
            psList[i].Nhap();
        }
        // In danh sách phân số
        Console.WriteLine("Danh sach phan so:");
        for(int i=0; i < Number_Of_Elements; i++)
            psList[i].Xuat();

        // Tìm phân số lớn nhất
        PhanSo psMax = new PhanSo(psList[0]); // gán phân số lớn nhất = phân số đầu tiên 
                                              // sử dụng hàm thiết lập sao chép
        // Xét lần lượt từng phần tử, so sánh & gán
        for(int i=1; i < Number_Of_Elements; i++)
            if(psMax.GiaTri() < psList[i].GiaTri()) psMax = psList[i];

        // In ra phân số lớn nhất
        Console.WriteLine("Phan so lon nhat:");
        psMax.Xuat();

        // Sắp xếp mảng phân số tăng dần
        for(int i=0; i < Number_Of_Elements - 1; i++)
            for(int j=i+1; j < Number_Of_Elements; j++)
            if(psList[i].GiaTri() > psList[j].GiaTri())
            {
                PhanSo tmp = new PhanSo();
                tmp = psList[i];
                psList[i] = psList[j];
                psList[j] = tmp;
            }

        // In danh sách phân số sau sắp xếp
        Console.WriteLine("Danh sach phan so da sap xep:");
        for(int i=0; i < Number_Of_Elements; i++)
            psList[i].Xuat();
        */
    }
}

