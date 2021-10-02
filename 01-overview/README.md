<h1 align="center"> 
GIỚI THIỆU
</h1>

## [1 - Sơ lược các mô thức lập trình (programming paradigms)](#paradigms)
## [2 - Phương pháp lập trình hướng đối tượng](#oop)

<br>

## 1 - Sơ lược các mô thức lập trình (programming paradigms) <a name="paradigms"/>
- Các chương trình máy tính ngày càng trở nên đa dạng và phức tạp hơn, do đó cách tiếp cận lập trình cũng cần có sự cải tiến để đáp ứng yêu cầu. 
- Có thể chia ngôn ngữ lập trình thành hai nhóm chính (gọi là *"mô thức lập trình" (programming paradigms)* - có thể hiểu là phương pháp luận hay nguyên tắc chung cơ bản trong lập trình): 
    * [**Lập trình hướng mệnh lệnh (imperative programming)**](#imperative)
    * [**Lập trình khai báo (declarative programming)**](#declarative)

<img alt="Programming paradigms" src="figs/programming-paradigms-2.png"> 

### **Lập trình hướng mệnh lệnh (Imperative Programming)** <a name="imperative"/>
- Nguyên lý lập trình mệnh lệnh là *ra lệnh máy tính thực hiện từng bước xử lý theo một trình tự xác định để đạt kết quả mong muốn - (how to do)*, tương đồng với cách máy tính thực hiện ở mức mã máy (machine code). 
- Các lệnh được cài đặt theo trình tự của giải thuật, vì thế kiểu lập trình này còn gọi là lập trình giải thuật (algorithmic programming). Hầu hết ngôn ngữ lập trình đều hỗ trợ kiểu lập trình này. 
- Các phương pháp lập trình cấu trúc (structured programming), lập trình hướng thủ tục (procedural programming), lập trình hướng đối tượng (object-oriented programming) đều thuộc mô thức lập trình hướng mệnh lệnh.

#### Lập trình cấu trúc (structured programming)
- Dựa trên cách tiếp cận theo hướng từ trên xuống (top-down development), từ tổng quát đến chi tiết. Theo đó, chương trình được chia thành các khối chức năng (stages), các chức năng này nếu cần lại được phân chia tiếp thành các khối chức năng nhỏ hơn, cho đến khi các khối chức năng nhỏ nhất đủ đơn giản để cài đặt thành các chương trình con (thủ tục/hàm).
- Chương trình là sự kết hợp của các cấu trúc điều khiển: tuần tự (sequence), chọn lựa (selection) và lặp (repetition).
- Mã nguồn dễ đọc dễ hiểu.
- Giảm lặp lại mã nguồn thông qua lời gọi chương trình con.

#### Lập trình hướng thủ tục(procedural programming)
Lập trình hướng thủ tục là sự cải tiến của lập trình cấu trúc, với các mở rộng sau:
-  Mỗi chức năng ở từng lớp được tổ chức thành chương trình con.
- Chương trình con nhận dữ liệu vào thông qua truyền đối số, xử lý và trả về kết quả.
- Chương trình có tính module hóa cao.
- Dữ liệu và xử lý tách rời nhau.
```csharp
/*
Ví dụ: Sắp xếp dãy số tăng dần theo phương pháp lập trình mệnh lệnh với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

int[] a = new int[6] { 3, 1, 2, 8, 6, 5 };
int n = 6;

// Sắp xếp tăng dần (giải thuật đổi chỗ trực tiếp)
for (int i=0; i < n-1; i++)
    for(int j=i+1; j < n; j++)
    {
        if(a[i] > a[j])
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
```

### **Lập trình khai báo (Declarative Programming)** <a name="declarative"/>

Các ngôn ngữ lập trình khai báo diễn đạt các câu lệnh theo cách *yêu cầu máy tính phải làm gì (what to do)* để đạt được kết quả mà không cần quan tâm đến cách thức thực hiện chi tiết. Các phân hệ của lập trình khai báo gồm có: Lập trình logic (như Prolog), hướng chức năng (như Haskell, Scala, F#), ngôn ngữ chuyên dụng (domain-specific) như SQL, HTML.

```csharp
/*
Ví dụ: Sắp xếp dãy số tăng dần theo lập trình khai báo với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

List<int> numbers = new List<int> { 3, 8, 2, 1, 5, 6 };

// Sort the list ascending
numbers.Sort();
```

## 2 - Phương pháp lập trình hướng đối tượng <a name="oop"/>
### Bài toán ví dụ
Để minh họa các cách tiếp cận lập trình, ta xét bài toán - đã đơn giản hóa - sau đây:

Một trường học cần xây dựng một phần mềm quản lý đào tạo. Hệ thống này quản lý dữ liệu của sinh viên (students), giảng viên (lecturers), các môn học (courses), và các kỳ thi (exams). 
Các chức năng của phần mềm gồm có: thêm sinh viên (addStudent), xóa sinh viên (removeStudent), dự thi (takeExams), xem điểm (viewGrades). 

Sau khi phân tích, mô hình hệ thống quản lý đào tạo được thiết kế như hình sau:

<img src="figs/academicsystem.PNG">

Mô hình quản lý đào tạo gồm có dữ liệu (data) và các chức năng (functions) thao tác trên dữ liệu. Trong đó, đường nét đứt thể hiện sự phụ thuộc của một tập dữ liệu vào một tập dữ liệu khác; chẳng hạn, mỗi sinh viên học nhiều môn học, mỗi môn học lại có nhiều sinh viên. Đường mũi tên thể hiện sự tác động của các chức năng lên một hoặc một số tập dữ liệu; ví dụ, chức năng thêm sinh viên (addStudent) sẽ thay đổi nội dung của tập dữ liệu sinh viên (Students), hay chức năng dự thi (takeExams) cần truy cập dữ liệu của sinh viên và kỳ thi (Exams). 

Theo cách tiếp cận lập trình hướng thủ tục/cấu trúc, mỗi chức năng được tổ chức thành một chương trình con (hàm) tương ứng. Các hàm thực hiện xử lý dữ liệu thông qua cách truyền tham số phù hợp và trả về kết quả cho lời gọi hàm. Cách thiết kế phát triển hệ thống như vậy khá rõ ràng, nhưng có những hạn chế. Xét các tình huống sau:
- *Tình huống 1*: Giả sử dữ liệu đang lưu trữ năm sinh là số có 2 chữ số, cần chuyển đổi năm sinh đang từ 2 chữ số sang 4 chữ số (ví dụ: 97 -> 1997), thì giải quyết thế nào?

Giải pháp hiển nhiên là cần thay đổi trường dữ liệu ngày sinh của sinh viên và giảng viên thành số có 4 chữ số. Khi đó, tất cả các hàm có tác động lên sinh viên và giảng viên sẽ không hoạt động được, trừ khi phải chỉnh sửa lại mã nguồn. Bên cạnh đó, tập dữ liệu sinh viên có mối quan hệ phụ thuộc với các tập dữ liệu khác, vì thế việc thay đổi này có thể gây ra lỗi cho hệ thống.

- *Tình huống 2*: Hệ thống cần quản lý thêm một thành phần dữ liệu mới là sinh viên hệ vừa làm vừa học, vậy cần giải quyết thế nào?



### Cách tiếp cận hướng đối tượng
- OOP là phương pháp lập trình phổ biến nhất hiện nay bởi các ưu điểm: 
     * Mã nguồn được module hóa cao.
     * Cách lập trình có sự tương đồng với bài toán trong thế giới thực.
OOP is the most popular programming paradigm because of its unique advantages like the modularity of the code and the ability to directly associate real-world business problems in terms of code.

## Tài liệu tham khảo 

#### Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020

#### [Programming Languages, Stanford University, 2018](https://web.stanford.edu/class/cs106e/lectureNotes/L14NProgrammingLanguages.pdf)

#### Object Oriented Analysis and Design using the UML

#### Giáo trình Kỹ thuật lập trình, Nguyễn Đức Thuần, Trường đại học Nha Trang, 2020


