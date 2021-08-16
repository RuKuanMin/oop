<h1 align="center"> 
TỔNG QUAN VỀ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG
</h1>

## Sơ lược về lập trình

Có thể nói, lập trình (programming) là trọng tâm của khoa học máy tính bởi đây là công cụ thực hành kết hợp trí tuệ con người với sức mạnh xử lý của máy tính điện tử để tạo ra chương trình máy tính (computer program) giúp tự động hóa xử lý thông tin. Máy tính điện tử chỉ có khả năng xử lý thông tin theo chương trình được lập sẵn. Để giải quyết một bài toán, máy tính không tự nghĩ ra cách giải mà con người cần phân tích yêu cầu của bài toán để xây dựng một dãy các chỉ thị được định nghĩa rõ ràng - gọi là thuật toán (algorithm) - rồi sử dụng một (hoặc một số) ngôn ngữ lập trình (programming language) để cài đặt thuật toán đó thành chương trình máy tính. 

Một chương trình tốt cần thỏa mãn các yêu cầu sau:

**Đối với người sử dụng:**
- Chính xác, hiệu quả: Chương trình giải quyết được các yêu cầu đặt ra của bài toán với thời gian ngắn, chi phí thấp.
- Ổn định, tin cậy.
- Giao diện thân thiện.

**Đối với người lập trình:**
- Mã nguồn dễ hiểu: Giúp giảm thiểu lỗi, dễ nâng cấp, bảo trì.
- Dễ cập nhật, nâng cấp khi yêu cầu của bài toán thay đổi.
- Có khả năng tái sử dụng hoặc kế thừa cho bài toán khác.

## Các mô thức lập trình (programming paradigms)

Đến nay, có nhiều phương pháp lập trình được đề xuất, nhiều ngôn ngữ lập trình được phát triển. Dưới đây là một số cách tiếp cận chính trong lập trình (được gọi là "mô thức" - programming paradigm).

| <img src="figs/programming_paradigms.png" width="70%"/> |
|:--:|
| Các mô thức lập trình |

#### Imperative Programming (lập trình hướng mệnh lệnh)
Ý tưởng cơ bản của lập trình mệnh lệnh tương đồng với cách máy tính thực hiện ở mức mã máy (machine code), hầu hết ngôn ngữ lập trình đều hỗ trợ kiểu lập trình này. 

Theo cách tiếp cận này, chương trình được xem là một dãy các lệnh yêu cầu máy tính thực hiện cho đến khi đạt được kết quả mong muốn. Lập trình mệnh lệnh phù hợp với các chương trình đơn giản. 
Một số ngôn ngữ phổ biến hiện nay hỗ trợ lập trình mệnh lệnh: C/C++, C#, Java, Python.

Ví dụ: Chương trình C tìm phần tử lớn nhất của dãy số.
```C
#include <stdio.h>

int main()
{
	int a[] = {3,8,2,1,6,5};
	int n=6, i=0, max;
	max = a[i];
	LOOP:
		if(max < a[i]) max = a[i];
		i++;
		if( i == n) goto FINISHED;
		goto LOOP;
	FINISHED:
		printf("Max value = %d\n", max);
}
```

#### Structured Programming (lập trình cấu trúc)
Structured program theorem (Bohm-Jacopini): sequencing, selection, and iteration are sucient to
express any computable function.

## Cách tiếp cận hướng đối tượng

## Tài liệu tham khảo 
https://www.cs.mcgill.ca/~rwest/wikispeedia/wpcd/wp/i/Imperative_programming.htm

Lectures on High-performance Computing for Economists, University of Pennsylvania, 2020

Giáo trình Kỹ thuật lập trình, Nguyễn Đức Thuần, Trường đại học Nha Trang, 2020
