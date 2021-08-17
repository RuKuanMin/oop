<h1 align="center"> 
TỔNG QUAN VỀ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
</h1>


## Quy trình phát triển phần mềm

Các sản phẩm phần mềm thường được phát triển theo quy trình có tên gọi **Vòng đời phát triển phần mềm (software development lifecycle - SDLC)**. Quy trình này gồm các giai đoạn: lập kế hoạch (planning), phân tích (analysis), thiết kế (design), cài đặt (implementation), kiểm thử (testing), triển khai (deployment) và bảo trì (maintenance) sản phẩm. 

<p align="center">

|<img src="./figs/SDLC.PNG" alt="SDLC" width="80%"/>|
|:--:|
|Vòng đời phát triển phần mềm|

</p>

- Giai đoạn **lập kế hoạch** tiếp nhận yêu cầu từ khách hàng để làm rõ các yêu cần cần có của sản phẩm, từ đó lập kế hoạch tổng thể cho dự án và nghiên cứu các giải pháp khả thi về kỹ thuật, vận hành và kinh tế. 

- Giai đoạn **phân tích** tiến hành làm rõ yêu cầu về sản phẩm và lập bảng đặc tả chức năng (software requirement specification - SRS) mà phần mềm cần có. 

- Giai đoạn **thiết kế** căn cứ vào bảng SRS để xây dựng bảng đặc tả thiết kế (design document specification - DDS).

- Giai đoạn **cài đặt** triển khai lập trình tạo ứng dụng dựa trên bản DDS được chọn. Tùy thuộc vào loại ứng dụng mà một hoặc một số ngôn ngữ lập trình được sử dụng để cài đặt.

## Sơ lược về lập trình
Có thể nói, lập trình (implementation/programming/coding) là khâu rất quan trọng trong quy trình phát triển phần mềm, bởi đây là bước triển khai cài đặt thiết kế thành chương trình máy tính (computer program). Máy tính điện tử chỉ có khả năng xử lý thông tin theo chương trình được lập sẵn. Để giải quyết một bài toán, máy tính không tự nghĩ ra cách giải mà con người cần phân tích yêu cầu của bài toán để xây dựng một dãy các chỉ thị được định nghĩa rõ ràng - gọi là thuật toán (algorithm) - rồi sử dụng một (hoặc một số) ngôn ngữ lập trình (programming language) để cài đặt thuật toán thành chương trình máy tính. 

Một chương trình tốt cần thỏa mãn các yêu cầu sau:

**Đối với người sử dụng:**
- Chính xác, hiệu quả: Chương trình giải quyết được các yêu cầu đặt ra của bài toán với thời gian ngắn, chi phí thấp.
- Ổn định, tin cậy.
- Giao diện thân thiện.

**Đối với người lập trình:**
- Mã nguồn dễ hiểu: Giúp giảm thiểu lỗi, bảo trì, nâng cấp.
- Dễ cập nhật, nâng cấp khi yêu cầu của bài toán thay đổi.
- Có khả năng tái sử dụng hoặc kế thừa cho bài toán khác.

## Các mô thức lập trình (programming paradigms)

Đến nay, có nhiều phương pháp lập trình được đề xuất, nhiều ngôn ngữ lập trình được phát triển. Dưới đây là một số cách tiếp cận chính trong lập trình (được gọi là "mô thức" - programming paradigm).

| <img src="figs/programming_paradigms.png" width="70%"/> |
|:--:|
| Các mô thức lập trình |

#### Lập trình hướng mệnh lệnh (Imperative Programming)
Ý tưởng cơ bản của lập trình mệnh lệnh tương đồng với cách máy tính thực hiện ở mức mã máy (machine code), hầu hết ngôn ngữ lập trình đều hỗ trợ kiểu lập trình này. 
Theo cách tiếp cận này, chương trình được xem là một dãy các lệnh yêu cầu máy tính thực hiện **làm thế nào (how)** - từng bước một - cho đến khi đạt được kết quả mong muốn. Lập trình hướng thủ tục (procedural programming), hướng cấu trúc (structured programming), hướng đối tượng (object-oriented programming) đều thuộc mô thức lập trình hướng mệnh lệnh.

Lập trình hướng mệnh lệnh có các ưu điểm: mã nguồn dễ đọc, dễ hiểu, dễ triển khai. Vì thế, 


FEASIBILITY
Developers can reason a source code easily by determining what a single-core processor can do with it.

WIDELY USED
Imperative programming is being taught in schools, colleges, and workplaces by authority. Programmers and developers have a high degree of familiarity with it.
Lập trình mệnh lệnh phù hợp với các chương trình đơn giản. 

Một số ngôn ngữ phổ biến hỗ trợ lập trình mệnh lệnh: C/C++, C#, Java, PHP, Python.


## Cách tiếp cận hướng đối tượng

## Tài liệu tham khảo 
https://www.cs.mcgill.ca/~rwest/wikispeedia/wpcd/wp/i/Imperative_programming.htm

Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020

https://cs.lmu.edu/~ray/notes/paradigms/

Giáo trình Kỹ thuật lập trình, Nguyễn Đức Thuần, Trường đại học Nha Trang, 2020


