INSERT INTO nhanvien (MaNhanVien,TenNhanVien,ChucVu,Luong,Email,TrangThai,MatKhau) VALUES
('NV1', N'Nguyễn Văn A', N'Quản Trị', 15000000.00, 'ChungBao@gmail', N'Chưa đilàm', '7372'),
('NV2', N'Trần Thị B', N'Nhân Viên', 12000000.00, 'loginus@1234', N'Chưa đilàm', '1234'),
('NV3', N'Lê Văn C', N'Nhân Viên', 8000000.00, 'thinh@gmail.com', N'Chưa đilàm', '8931'),
('NV4', N'Phạm Thị D', N'Nhân Viên', 7000000.00, 'd.pham@example.com', N'Chưa đilàm', '2871'),
('NV5', N'Vũ Văn E', N'Nhân Viên', 9000000.00, 'e.vu@example.com', N'Chưa đilàm', '2344');

INSERT INTO khachhang (MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES
('KH1', N'Nguyễn Văn A', '0901234567', N'123 Đường ABC, Quận 1, TP. Hồ Chí Minh'),
('KH2', N'Trần Thị B', '0912345678', N'456 Đường DEF, Quận 2, TP. Hồ Chí Minh'),
('KH3', N'Lê Văn C', '0923456789', N'789 Đường GHI, Quận 3, TP. Hồ Chí Minh'),
('KH4', N'Phạm Thị D', '0934567890', N'101 Đường JKL, Quận 4, TP. Hồ Chí Minh'),
('KH5', N'Vũ Văn E', '0945678901', N'202 Đường MNO, Quận 5, TP. Hồ Chí Minh');

INSERT INTO nhacungcap (MaNCC, TenNCC, DiaChi, SDT) VALUES
('NCC1', 'Laki', N'Phố Hà Nội', '0932029821'),
('NCC2', 'Nemo', N'TP. HCM', '0932029821'),
('NCC3', 'Nom', N'Quảng Ninh', '0932029821'),
('NCC4', 'Pipi', N'Phố Hà Nội', '0932029821'),
('NCC5', 'Sham', N'Sapa', '0932029821');

INSERT INTO sanpham (MaSanPham, TenSanPham, LoaiSanPham, SoLuong, Gia, MaNCC, TrangThai) VALUES
('SP1', N'Áo sơ mi', N'Áo thun nam', 1, 150000.00, 'NCC1', N'Đang Bán'),  -- Sản phẩm 1, loại Laptop, giá 15.000.000 VNĐ
('SP2', N'Đầm', N'Dầm cho nữ', 1, 120000.00, 'NCC2', N'Chưa được bán'),  -- Sản phẩm 2, loại Smartphone, giá 12.000.000 VNĐ
('SP3', N'Áo trẻ em', N'Áo quần cho trẻ', 1, 80000.00, 'NCC3', N'Chưa được bán'),  -- Sản phẩm 3, loại Tai Nghe, giá 8.000.000 VNĐ
('SP4', N'Quần tây', N'Quần tây cho nam', 2, 70000.00, 'NCC4', N'Đang Bán'),  -- Sản phẩm 4, loại Màn Hình, giá 7.000.000 VNĐ
('SP5', N'Áo Kaki', N'Áo len', 2, 20000.00, 'NCC5', N'Chưa được bán');  -- Sản phẩm 5, loại Phụ Kiện, giá 2.000.000 VNĐ

--INSERT INTO kho (MaSanPham, SoLuong) VALUES
--('SP1', 50),   -- Sản phẩm với MaSP 1 có số lượng 50
--('SP2', 30),   -- Sản phẩm với MaSP 2 có số lượng 30
--('SP3', 20),   -- Sản phẩm với MaSP 3 có số lượng 20
--('SP4', 10),   -- Sản phẩm với MaSP 4 có số lượng 10
--('SP5', 40);   -- Sản phẩm với MaSP 5 có số lượng 40

INSERT INTO hoadon (MaHoaDon, MaNhanVien, MaKhachHang, NgayTao, TongTien, TrangThai) VALUES
('HD1', 'NV1', 'KH1', '2024-07-01', 0, N'Đã Thanh Toán'),   -- Hóa đơn 1, Nhân viên 1, Khách hàng 1, Ngày tạo 2024-07-01, Trạng thái Đã Thanh Toán
('HD2', 'NV2', 'KH2', '2024-07-02', 0, N'Chưa Thanh Toán'),  -- Hóa đơn 2, Nhân viên 2, Khách hàng 2, Ngày tạo 2024-07-02, Trạng thái Chưa Thanh Toán
('HD3', 'NV1', 'KH3', '2024-07-03', 0, N'Đã Thanh Toán'),   -- Hóa đơn 3, Nhân viên 1, Khách hàng 3, Ngày tạo 2024-07-03, Trạng thái Đã Thanh Toán
('HD4', 'NV3', 'KH4', '2024-07-04', 0, N'Đã Thanh Toán'),   -- Hóa đơn 4, Nhân viên 3, Khách hàng 4, Ngày tạo 2024-07-04, Trạng thái Đã Thanh Toán
('HD5', 'NV4', 'KH5', '2024-07-05', 0, N'Chưa Thanh Toán');  -- Hóa đơn 5, Nhân viên 2, Khách hàng 5, Ngày tạo 2024-07-05, Trạng thái Chưa Thanh Toán

INSERT INTO chitiethoadon (MaHoaDon,MaSanPham, SoLuong) VALUES
('HD1', 'SP1', 2),  -- Hóa đơn 1, Sản phẩm 1, Số lượng 2
('HD1', 'SP2', 1),  -- Hóa đơn 1, Sản phẩm 2, Số lượng 1
('HD2', 'SP3', 3),  -- Hóa đơn 2, Sản phẩm 3, Số lượng 3
('HD3', 'SP4', 1),  -- Hóa đơn 3, Sản phẩm 4, Số lượng 1
('HD4', 'SP5', 5),  -- Hóa đơn 4, Sản phẩm 5, Số lượng 5
('HD5', 'SP2', 2),  -- Hóa đơn 5, Sản phẩm 2, Số lượng 2
('HD5', 'SP3', 1);  -- Hóa đơn 5, Sản phẩm 3, Số lượng 1

-- RESET IDENTITY
DBCC CHECKIDENT (SanPham, RESEED, 0);
DBCC CHECKIDENT (NhanVien, RESEED, 0);
DBCC CHECKIDENT (KhachHang, RESEED, 0);
DBCC CHECKIDENT (NhaCungCap, RESEED, 0);
DBCC CHECKIDENT (HoaDon, RESEED, 0);
-- RESET IDENTITY

--DELETE FROM ChiTietHoaDon
--DELETE FROM HoaDon
--DELETE FROM NhaCungCap
--DELETE FROM SanPham
--DELETE FROM NhanVien
--DELETE FROM KhachHang

-- DROP Hết Store Procedures
SELECT 'DROP PROCEDURE [' + SCHEMA_NAME(p.schema_id) + '].[' + p.NAME + '];'
FROM sys.procedures p
-- DROP Hết Store Procedures