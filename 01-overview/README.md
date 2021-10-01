<h1 align="center"> 
GIỚI THIỆU
</h1>

## [1 - Sơ lược quy trình phát triển phần mềm](#sdlc)
## [2 - Các mô thức lập trình (programming paradigms)](#paradigms)
## [3 - Phương pháp lập trình hướng đối tượng](#oop)

<br>

## 1 - Sơ lược quy trình phát triển phần mềm <a name="sdlc"/>
Cùng với sự phát triển của phần cứng (hardware), phần mềm (software) ngày càng đa dạng về ứng dụng và phức tạp hơn về chức năng. Việc phát triển phần mềm, do đó, cần phải tuân theo quy trình chặt chẽ nhằm đảm bảo sản phẩm đạt chất lượng cao, đáp ứng yêu cầu người dùng; đồng thời đáp ứng khả năng bảo trì, nâng cấp, kế thừa và mở rộng về sau.

Hiện nay, các sản phẩm phần mềm thường được phát triển theo chu trình gọi là **Vòng đời phát triển phần mềm (software development lifecycle - SDLC)**. Chu trình này gồm các giai đoạn: lập kế hoạch (planning), phân tích (analysis), thiết kế (design), cài đặt (implementation), kiểm thử (testing), triển khai (deployment) và bảo trì (maintenance) sản phẩm. 

<p align="center">

|<img src="./figs/SDLC.PNG" alt="SDLC" width="80%"/>|
|:--:|
|Vòng đời phát triển phần mềm|

</p>

- Giai đoạn **lập kế hoạch** tiếp nhận yêu cầu từ khách hàng để làm rõ các yêu cần cần có của sản phẩm, từ đó lập kế hoạch tổng thể cho dự án và nghiên cứu các giải pháp khả thi về kỹ thuật, vận hành và kinh tế. 

- Giai đoạn **phân tích** tiến hành làm rõ yêu cầu về sản phẩm và lập bảng đặc tả chức năng (software requirement specification - SRS) mà phần mềm cần có. 

- Giai đoạn **thiết kế** căn cứ vào bảng SRS để xây dựng bảng đặc tả thiết kế (design document specification - DDS).

- Giai đoạn **cài đặt** triển khai lập trình tạo ứng dụng dựa trên bản DDS được chọn. Tùy thuộc vào loại ứng dụng mà một hoặc một số ngôn ngữ lập trình được sử dụng để cài đặt.

- Giai đoạn **kiểm thử** thực hiện kiểm tra các chức năng của phần mềm bằng các *test case* nhằm đảm bảo sản phẩm đáp ứng được yêu cầu đề ra, đồng thời ghi nhận các lỗi phát sinh (nếu có).

- Giai đoạn **triển khai** tiến hành đưa sản phẩm vào sử dụng sau giai đoạn kiểm thử.

- Giai đoạn **bảo trì** thực hiện hỗ trợ khách hàng, xử lý lỗi phát sinh (nếu có) trong quá trình sử dụng, hoặc cập nhật, chỉnh sửa sản phẩm theo yêu cầu.

## 2 - Các mô thức lập trình (programming paradigms) <a name="paradigms"/>
- Các ứng dụng ngày càng phức tạp và đa dạng hơn, do đó cách tiếp cận lập trình cũng cần có sự cải tiến để đáp ứng yêu cầu. 
- Có thể chia ngôn ngữ lập trình thành hai nhóm chính (được gọi là *"mô thức lập trình" (programming paradigms)* - có thể hiểu là phương pháp luận hay các nguyên tắc chung cơ bản trong lập trình): 
    * **Lập trình hướng mệnh lệnh (imperative programming)**.
    * **Lập trình khai báo (declarative programming)**.

<p align="center">

|<img src="figs/programming_paradigms.png" alt="SDLC"/>|
|:--:|
|Các mô thức lập trình.|

</p>

### **Lập trình hướng mệnh lệnh (Imperative Programming)**
- Ý tưởng cơ bản của lập trình mệnh lệnh là *ra lệnh máy tính thực hiện từng bước cụ thể theo một trình tự xác định để đạt kết quả mong muốn - (how to do)*, tương đồng với cách máy tính thực hiện ở mức mã máy (machine code). 
- Các câu lệnh được cài đặt theo trình tự của giải thuật, vì thế kiểu lập trình này còn gọi là lập trình giải thuật (algorithmic programming). Hầu hết ngôn ngữ lập trình đều hỗ trợ kiểu lập trình này. 
- Các phương pháp lập trình cấu trúc (structured programming), lập trình hướng thủ tục (procedural programming), lập trình hướng đối tượng (object-oriented programming) đều thuộc mô thức lập trình hướng mệnh lệnh.

#### Lập trình cấu trúc (structured programming)
- Dựa trên cách tiếp cận từ trên xuống (top-down development). Chương trình được chia thành các khối chức năng (stages), các chức năng này nếu cần lại được phân chia tiếp thành các khối chức năng nhỏ hơn, cho đến khi các khối chức năng nhỏ nhất đủ đơn giản để cài đặt thành các chương trình con.
- Chương trình là sự kết hợp của các cấu trúc điều khiển: tuần tự (sequence), chọn lựa (selection) và lặp (repetition).
- Mã nguồn dễ đọc dễ hiểu.
- Giảm lặp lại mã nguồn thông qua lời gọi chương trình con.

#### Lập trình hướng thủ tục (procedural programming)
Lập trình hướng thủ tục là sự cải tiến của lập trình cấu trúc, với các mở rộng sau:
-  Mỗi chức năng ở từng lớp được tổ chức thành chương trình con.
- Chương trình con nhận dữ liệu vào thông qua truyền đối số, xử lý và trả về kết quả.
- Chương trình có tính module hóa cao.
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

### **Lập trình khai báo (Declarative Programming)**

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


## 3 - Phương pháp lập trình hướng đối tượng <a name="oop"/>
### Cách tiếp cận hướng đối tượng
- OOP là phương pháp lập trình phổ biến nhất hiện nay bởi các ưu điểm: 
     * Mã nguồn được tổ chức module hóa
     * Các lập trình có sự tương đồng với bài toán trong thế giới thực.
OOP is the most popular programming paradigm because of its unique advantages like the modularity of the code and the ability to directly associate real-world business problems in terms of code.

## Tài liệu tham khảo 
https://www.cs.mcgill.ca/~rwest/wikispeedia/wpcd/wp/i/Imperative_programming.htm

Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020

https://cs.lmu.edu/~ray/notes/paradigms/

https://web.stanford.edu/class/cs106e/lectureNotes/L14NProgrammingLanguages.pdf

Giáo trình Kỹ thuật lập trình, Nguyễn Đức Thuần, Trường đại học Nha Trang, 2020


