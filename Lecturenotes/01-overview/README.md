<h1 align="center"> 
TỔNG QUAN VỀ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
</h1>


## Sơ lược quy trình phát triển phần mềm

Cùng với sự phát triển của phần cứng (hardware), phần mềm (software) ngày càng đa dạng về ứng dụng và phức tạp hơn về chức năng. Việc phát triển phần mềm, do đó, cần phải có quy trình chặt chẽ nhằm đảm bảo sản phẩm đạt chất lượng cao, đáp ứng yêu cầu người dùng; đồng thời đáp ứng khả năng bảo trì, nâng cấp, kế thừa và mở rộng về sau.

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

## Các phương pháp lập trình
Có thể nói, lập trình (implementation/programming/coding) là khâu rất quan trọng trong quy trình phát triển phần mềm, bởi đây là bước triển khai cài đặt bản thiết kế thành chương trình máy tính (computer program). Máy tính điện tử chỉ có khả năng xử lý thông tin theo chương trình được lập sẵn. Để giải quyết một bài toán, máy tính không tự nghĩ ra cách giải mà con người cần phân tích yêu cầu của bài toán để xây dựng một dãy các chỉ thị được định nghĩa rõ ràng - gọi là thuật toán (algorithm) - rồi sử dụng một (hoặc một số) ngôn ngữ lập trình (programming language) để cài đặt thuật toán thành chương trình. 

Một chương trình tốt cần thỏa mãn các yêu cầu sau:

**Đối với người sử dụng:**
- Chính xác, hiệu quả: Chương trình giải quyết được các yêu cầu đặt ra của bài toán với thời gian ngắn, chi phí thấp.
- Ổn định, tin cậy.
- Giao diện thân thiện, dễ sử dụng.

**Đối với người lập trình:**
- Mã nguồn dễ hiểu: Giúp giảm thiểu lỗi, dễ sửa lỗi, bảo trì, nâng cấp, mở rộng.
- Dễ cập nhật, nâng cấp, mở rộng khi yêu cầu của bài toán thay đổi.
- Có khả năng tái sử dụng hoặc kế thừa cho bài toán khác.

## Các mô thức lập trình (programming paradigms)

Đến nay, có nhiều phương pháp lập trình được đề xuất, và theo đó, nhiều ngôn ngữ lập trình được phát triển. Các phương pháp lập trình (được gọi là "mô thức lập trình" - programming paradigms) được chia thành hai nhóm chính: Lập trình hướng mệnh lệnh (imperative programming) và Lập trình khai báo (declarative programming).

| <img src="figs/programming_paradigms.png" width="70%"/> |
|:--:|
| Các mô thức lập trình |

#### Lập trình hướng mệnh lệnh (Imperative Programming)

Ý tưởng cơ bản của lập trình mệnh lệnh là **ra lệnh máy tính thực hiện từng bước cụ thể để đạt kết quả mong muốn - (tell the computer how to do)**, tương đồng với cách máy tính thực hiện ở mức mã máy (machine code). Hầu hết ngôn ngữ lập trình đều hỗ trợ kiểu lập trình này. 

Lập trình hướng thủ tục (procedural programming), hướng cấu trúc (structured programming), hướng đối tượng (object-oriented programming) đều thuộc mô thức lập trình hướng mệnh lệnh.

Lập trình hướng mệnh lệnh có các ưu điểm: dễ hiểu, dễ cài đặt. Vì thế người học lập trình thường bắt đầu với phương pháp này.

```csharp
/*
Ví dụ: Tính tổng các số lẻ < n.
Input: Số nguyên n > 0
Output: Tổng các số lẻ < n
*/

using System;

namespace SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int n=20, sum=0, i;
			i = 1;
			LOOP:
				if (i >= n) goto FINISHED;
				if (i % 2 !=0) sum += i;
				i++;
				goto LOOP;
			FINISHED:
				Console.WriteLine("Sum of the odd numbers < {0} = {1}", n, sum);
				Console.ReadKey(); // Wait for a key press to exit
		}
    }
}

```

#### Lập trình khai báo (Declarative Programming)

FEASIBILITY
Developers can reason a source code easily by determining what a single-core processor can do with it.

WIDELY USED
Imperative programming is being taught in schools, colleges, and workplaces by authority. Programmers and developers have a high degree of familiarity with it.
Lập trình mệnh lệnh phù hợp với các chương trình đơn giản. 

Một số ngôn ngữ phổ biến hỗ trợ lập trình mệnh lệnh: C/C++, C#, Java, PHP, Python.

```csharp
/*
Ví dụ: Lập trình khai báo với C# tính tổng các số lẻ < n.
Input: n > 0
Output: Tổng các số lẻ < n
*/
using System;
using System.Linq;

namespace DeclarativeProgramming
{
    class Program
    {
        static void Main()
        {
            int n = 50;
            var sum = Enumerable.Range(0, n)
                     .Where(i => i % 2 != 0)
                     .Sum();
            Console.WriteLine("Tong cac so le < {0}: {1}", n, sum);
            Console.ReadKey();
        }
    }
}
```


## Cách tiếp cận hướng đối tượng

## Tài liệu tham khảo 
https://www.cs.mcgill.ca/~rwest/wikispeedia/wpcd/wp/i/Imperative_programming.htm

Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020

https://cs.lmu.edu/~ray/notes/paradigms/

Giáo trình Kỹ thuật lập trình, Nguyễn Đức Thuần, Trường đại học Nha Trang, 2020


