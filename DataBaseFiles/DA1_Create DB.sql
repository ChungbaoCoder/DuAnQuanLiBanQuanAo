
INSERT INTO nhanvien (MaNhanVien,TenNhanVien,ChucVu,Luong,Email, MatKhau) VALUES
(1, N'Nguyễn Văn A', N'Giám Đốc', 15000000.00, 'a.nguyen@example.com', '1092'),
(2, N'Trần Thị B', N'Trưởng Phòng', 12000000.00, 'b.tran@example.com', '0292'),
(3, N'Lê Văn C', N'Nhân Viên Kinh Doanh', 8000000.00, 'c.le@example.com', '8931'),
(4, N'Phạm Thị D', N'Nhân Viên Hành Chính', 7000000.00, 'd.pham@example.com', '2871'),
(5, N'Vũ Văn E', N'Nhân Viên Kỹ Thuật', 9000000.00, 'e.vu@example.com', '2344');

INSERT INTO khachhang (MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES
(1, N'Nguyễn Văn A', '0901234567', N'123 Đường ABC, Quận 1, TP. Hồ Chí Minh'),
(2, N'Trần Thị B', '0912345678', N'456 Đường DEF, Quận 2, TP. Hồ Chí Minh'),
(3, N'Lê Văn C', '0923456789', N'789 Đường GHI, Quận 3, TP. Hồ Chí Minh'),
(4, N'Phạm Thị D', '0934567890', N'101 Đường JKL, Quận 4, TP. Hồ Chí Minh'),
(5, N'Vũ Văn E', '0945678901', N'202 Đường MNO, Quận 5, TP. Hồ Chí Minh');

INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT) VALUES
('NCC1', 'Laki', N'Phố Hà Nội', '0932029821'),
('NCC2', 'Laki', N'Phố Hà Nội', '0932029821'),
('NCC3', 'Laki', N'Phố Hà Nội', '0932029821'),
('NCC4', 'Laki', N'Phố Hà Nội', '0932029821'),
('NCC5', 'Laki', N'Phố Hà Nội', '0932029821');

INSERT INTO sanpham (MaSanPham, TenSanPham, LoaiSanPham, Gia, MaNCC, TrangThai) VALUES
(1, N'Áo sơ mi', N'Áo thun nam', 150000.00, 'NCC1', N'Chưa được bán'),  -- Sản phẩm 1, loại Laptop, giá 15.000.000 VNĐ
(2, N'Đầm', N'Dầm cho nữ', 120000.00, 'NCC2', N'Chưa được bán'),  -- Sản phẩm 2, loại Smartphone, giá 12.000.000 VNĐ
(3, N'Áo trẻ em', N'Áo quần cho trẻ', 80000.00, 'NCC3', N'Chưa được bán'),  -- Sản phẩm 3, loại Tai Nghe, giá 8.000.000 VNĐ
(4, N'Quần tây', N'Quần tây cho nam', 70000.00, 'NCC4', N'Chưa được bán'),  -- Sản phẩm 4, loại Màn Hình, giá 7.000.000 VNĐ
(5, N'Áo Kaki', N'Áo len', 20000.00, 'NCC5', N'Chưa được bán');  -- Sản phẩm 5, loại Phụ Kiện, giá 2.000.000 VNĐ

INSERT INTO kho (MaSanPham, SoLuong) VALUES
(1, 50),   -- Sản phẩm với MaSP 1 có số lượng 50
(2, 30),   -- Sản phẩm với MaSP 2 có số lượng 30
(3, 20),   -- Sản phẩm với MaSP 3 có số lượng 20
(4, 10),   -- Sản phẩm với MaSP 4 có số lượng 10
(5, 40);   -- Sản phẩm với MaSP 5 có số lượng 40

INSERT INTO hoadon (MaHoaDon, MaNhanVien, MaKhachHang, NgayTao, TongTien, TrangThai) VALUES
(1, 1, 1, '2024-07-01', 0, N'Đã Thanh Toán'),   -- Hóa đơn 1, Nhân viên 1, Khách hàng 1, Ngày tạo 2024-07-01, Trạng thái Đã Thanh Toán
(2, 2, 2, '2024-07-02', 0, N'Chưa Thanh Toán'),  -- Hóa đơn 2, Nhân viên 2, Khách hàng 2, Ngày tạo 2024-07-02, Trạng thái Chưa Thanh Toán
(3, 1, 3, '2024-07-03', 0, N'Đã Thanh Toán'),   -- Hóa đơn 3, Nhân viên 1, Khách hàng 3, Ngày tạo 2024-07-03, Trạng thái Đã Thanh Toán
(4, 3, 4, '2024-07-04', 0, N'Đã Thanh Toán'),   -- Hóa đơn 4, Nhân viên 3, Khách hàng 4, Ngày tạo 2024-07-04, Trạng thái Đã Thanh Toán
(5, 2, 5, '2024-07-05', 0, N'Chưa Thanh Toán');  -- Hóa đơn 5, Nhân viên 2, Khách hàng 5, Ngày tạo 2024-07-05, Trạng thái Chưa Thanh Toán

INSERT INTO chitiethoadon (MaHoaDon,MaSanPham, SoLuong) VALUES
(1, 1, 2),  -- Hóa đơn 1, Sản phẩm 1, Số lượng 2
(1, 2, 1),  -- Hóa đơn 1, Sản phẩm 2, Số lượng 1
(2, 3, 3),  -- Hóa đơn 2, Sản phẩm 3, Số lượng 3
(3, 4, 1),  -- Hóa đơn 3, Sản phẩm 4, Số lượng 1
(4, 5, 5),  -- Hóa đơn 4, Sản phẩm 5, Số lượng 5
(5, 2, 2),  -- Hóa đơn 5, Sản phẩm 2, Số lượng 2
(5, 3, 1);  -- Hóa đơn 5, Sản phẩm 3, Số lượng 1

DBCC CHECKIDENT (SanPham, RESEED, 0);
GO