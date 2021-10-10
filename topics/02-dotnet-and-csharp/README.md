<h2 align="center"> 
.NET và ngôn ngữ C#
</h2>

<div class="header">
<a href="#dotnet"><h3>Sơ lược về .NET</h3></a>
<ul>
    <li><h4>.NET Framework</h4></li>
    <li><h4>.NET 5</h4></li>
</ul>

<a href="#csconcepts"><h3>Ngôn ngữ C#</h3></a>
<ul>
    <li>
        <h4>Đặc điểm</h4>
    </li>
    <li>
        <h4>Các thành phần của C# </h4>
    </li>
</ul>
</div>


## <a name="dotnet">Sơ lược về .NET </a>
- .NET - do Microsoft phát hành từ 2002 - là nền tảng phát triển nhiều loại ứng dụng (web, mobile, desktop, games, IoT).
- .NET hỗ trợ một số ngôn ngữ lập trình khác nhau: C#, F#, và Visual Basic.

- Các phiên bản của .NET:
    - .NET Framework
    - NET 5 (.NET Core)
    - UWP (Univeral Windows Platform)
    - Mono

- Mỗi phiên bản .NET gồm các thành phần chính sau:
    - Trình biên dịch & xử lý thực thi (Common Language Runtime - CLR).
    - Thư viện các lớp dựng sẵn.
    - Một số nền tảng phát triển ứng dụng, như Windows Forms, Windows Presentation Foundation (WPF).
    - Bộ công cụ phát triển, như Microsoft Visual Studio. 

#### Quá trình biên dịch & chạy ứng dụng
- **Dịch**: Mã nguồn được dịch thành file mã trung gian (CIL) với phần mở rộng là `.exe` hoặc `.dll`. 
- **Chạy**: Khi chạy ứng dụng, trình quản lý thực thi CLR chuyển mã trung gian thành mã máy thông qua trình biên dịch gọi là JIT (just-in-time compiler).

<img src="figs/swimlane-architecture-framework.svg" width="75%">

### .NET Framework
#### Đặc điểm
- Là phiên bản đầu tiên của .NET.
- Hỗ trợ phát triển các loại ứng dụng Windows và web.

#### Kiến trúc .NET Framework
- Hai thành phần chính của .NET Framework là CLR, và thư viện lớp dựng sẵn (.NET Framework Class Library). 
    * CLR chịu trách nhiệm quản lý các tiến trình, kiểm soát việc định kiểu (type-safety), xử lý ngoại lệ,...
    * Thư viện lớp cung cấp các APIs dùng cho xử lý file, kết nối cơ sở dữ liệu, ...; và các kiểu dữ liệu dùng chung như kiểu chuỗi (strings), kiểu ngày (dates), kiểu số (numbers),...



### [.NET 5 (.NET Core)](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- Là phiên bản cung cấp khả năng phát triển ứng dụng đa nền tảng (cross-plaform).
- Các loại ứng dụng: Desktop, Web, Mobile, Windows Forms, WPF, Games, IoT, Console,...
- Có thể tạo ứng dụng .NET trên nhiều hệ điều hành: Windows, macOS, Linux, Android, iOS, ...
- Mã nguồn mở trên [GitHub](https://github.com/dotnet).


### Ngôn ngữ lập trình C#


### <a name="resources">Tài liệu tham khảo</a>

#### [Microsoft: .NET Framework documentation](https://docs.microsoft.com/en-us/dotnet/framework/)
#### [Microsoft: C# tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/)
#### [Microsoft: .NET tutorial](https://dotnet.microsoft.com/learn/dotnet/in-browser-tutorial/)
#### [W3Schools.com: C# tutorial](https://www.w3schools.com/cs/index.php/)
#### [Visual Studio Code: Working with C#](https://code.visualstudio.com/docs/languages/csharp/)
