# eShopMobile
Sử dụng framework ASP.NET Core để thực hiện bài tập lớn
bài tập lớn được chia làm 8 project nhỏ, trong đó:
1. project eShopMobile.Ultilities và eShopMobile.ViewModels để dùng chung cho tất cả các project, chứa các thành phần như các model trả dữ liệu ra view, các exception, các định dạng kết quả trả về từ api,phân trang, ....
2. project eShopMobile.Application chứa các service dùng cho bài tập lớn
3. project eShopMobile.Data làm nhiệm vụ kết nối với database. Database sử dụng msSQL và tạo ra bằng Fluent API, sử dụng Entity Codefirst
4. project eShopMobile.BackendApi dùng để xử lí các kết quả trả về từ hạ tầng của các api
5. project eShopMobile.ApiIntegration dùng để tích hợp các api vào frontend
6. project eShopMobile.AdminApp dùng cho phía quản trị web
7. project eShopMobile.WebApp dành cho người dùng
