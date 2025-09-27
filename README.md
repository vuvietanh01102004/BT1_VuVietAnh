#  Môn: Phát triển ứng dụng trên nền web
# Vũ Việt Anh   
# MSSV: K225480106082
# BÀI TẬP VỀ NHÀ 01:
## TẠO SOLUTION GỒM CÁC PROJECT SAU:
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).

2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE

3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
  
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

# Bài làm
## Đề tài: Máy tính tiền đi chợ
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
### Tạo SOLUTION và Project
- Tên Class Library: MarketLibrary
<img width="1881" height="903" alt="image" src="https://github.com/user-attachments/assets/39d50dcd-859a-42cf-9796-1c965aa964c0" />

<img width="1881" height="935" alt="image" src="https://github.com/user-attachments/assets/b53a3ce2-6720-457f-8aca-23b9b74d8ece" />

<img width="1882" height="934" alt="image" src="https://github.com/user-attachments/assets/e4139a28-3d6a-4fee-bed3-d6ea243452d7" />

<img width="1867" height="901" alt="image" src="https://github.com/user-attachments/assets/2476af97-1235-472f-8a33-523446f20661" />

- Chuột phải vào MarketLibrary rồi ấn build sẽ cho ra kết quả:
<img width="719" height="384" alt="Ảnh chụp màn hình 2025-09-28 030104" src="https://github.com/user-attachments/assets/82f50de4-5608-4e25-853c-7b0e136e8725" />

2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
### Tạo Project Console App
<img width="1881" height="904" alt="image" src="https://github.com/user-attachments/assets/100f8687-b7cd-4e20-b7d1-dae736d2756f" />

<img width="1884" height="935" alt="image" src="https://github.com/user-attachments/assets/bd16192f-4937-4bf5-8788-8c363db472dc" />







