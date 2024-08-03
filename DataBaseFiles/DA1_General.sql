-- LOAD DATA TO GRIDVIEW

CREATE PROCEDURE dbo.sp_DanhSachSanPham
AS
BEGIN
	SET NOCOUNT ON
	UPDATE SanPham SET TrangThai = N'Hết Hàng' WHERE SoLuong < 1
	SELECT MaSanPham,TenSanPham,LoaiSanPham,SoLuong,Gia,TrangThai,MaNCC,HinhAnh
	FROM SanPham ORDER BY Id
END
GO

CREATE PROCEDURE dbo.sp_DanhSachKhachHang
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang ORDER BY Id
END
GO

CREATE PROCEDURE dbo.sp_DanhSachNhanVien
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,TrangThai,HinhAnh FROM NhanVien ORDER BY Id
END
GO

CREATE PROCEDURE dbo.sp_DanhSachNhaCungCap
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNCC,TenNCC,SDT,DiaChi FROM NhaCungCap ORDER BY Id
END
GO

CREATE PROCEDURE dbo.sp_DanhSachHoaDon
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,b.SDT,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien 
	FROM HoaDon a inner join KhachHang b on a.MaKhachHang = b.MaKhachHang ORDER BY a.Id
END
GO

CREATE PROCEDURE dbo.sp_DanhSachChiTietHoaDon @MaHoaDon varchar(20)
AS
BEGIN
	SELECT a.MaHoaDon,a.MaSanPham,b.TenSanPham,a.SoLuong,b.Gia,(b.Gia * a.SoLuong) AS 'TongThanhTien' 
	FROM ChiTietHoaDon a inner join SanPham b on a.MaSanPham = b.MaSanPham WHERE a.MaHoaDon = @MaHoaDon ORDER BY b.Id
END
GO

-- SEARCH NhanVien

CREATE PROCEDURE dbo.sp_TimNhanVien @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,HinhAnh,TrangThai FROM NhanVien 
	WHERE MaNhanVien LIKE '%' + @Varible + '%' OR TenNhanVien LIKE '%' + @Varible + '%' OR ChucVu LIKE '%' + @Varible + '%' 
	OR Email LIKE '%' + @Varible + '%' OR TrangThai LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO NhanVien

CREATE PROCEDURE dbo.sp_ThemNhanVien @TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@Email varchar(50),@HinhAnh varchar(100),@TrangThai nvarchar(50),@MatKhau varchar(20)
AS
BEGIN
	DECLARE @MaNV varchar(20)
	SET @MaNV = CONCAT('NV',CAST((SELECT IDENT_CURRENT('NhanVien')+1) AS varchar))
	INSERT INTO NhanVien (MaNhanVien,TenNhanVien,ChucVu,Luong,Email,HinhAnh,TrangThai,MatKhau) VALUES
	(@MaNV,@TenNhanVien,@ChucVu,@Luong,@Email,@HinhAnh,@TrangThai,@MatKhau)
END
GO

-- UPDATE NhanVien

CREATE PROCEDURE dbo.sp_CapNhatNhanVien @MaNhanVien varchar(20),@TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@Email varchar(50),@HinhAnh varchar(100),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE NhanVien SET TenNhanVien = @TenNhanVien,ChucVu = @ChucVu,Luong = @Luong,Email = @Email,HinhAnh = @HinhAnh,TrangThai = @TrangThai WHERE MaNhanVien = @MaNhanVien
END
GO

-- DELETE NhanVien

CREATE PROCEDURE dbo.sp_XoaNhanVien @MaNhanVien varchar(20)
AS
BEGIN
	DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien
END
GO

-- SEARCH KhachHang

CREATE PROCEDURE dbo.sp_TimKhachHang @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang 
	WHERE MaKhachHang LIKE '%' + @Varible + '%' OR TenKhachHang LIKE '%' + @Varible + '%' OR SDT LIKE '%' + @Varible + '%' 
	OR DiaChi LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO KhachHang

CREATE PROCEDURE dbo.sp_ThemKhachHang @TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	DECLARE @MaKH varchar(20)
	SET @MaKH = CONCAT('KH',CAST((SELECT IDENT_CURRENT('KhachHang')+1) AS varchar))
	INSERT INTO KhachHang (MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES
	(@MaKH,@TenKhachHang,@SDT,@DiaChi)
END
GO

-- UPDATE KhachHang

CREATE PROCEDURE dbo.sp_CapNhatKhachHang @MaKhachHang varchar(20),@TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE KhachHang SET TenKhachHang = @TenKhachHang,SDT = @SDT,DiaChi = @DiaChi
	WHERE MaKhachHang = @MaKhachHang AND SDT = @SDT
END
GO

-- DELETE KhachHang

CREATE PROCEDURE dbo.sp_XoaKhachHang @MaKhachHang varchar(20),@SDT varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT MaHoaDon FROM HoaDon WHERE MaKhachHang = @MaKhachHang)
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHD
	DELETE FROM HoaDon WHERE MaKhachHang = @MaKhachHang
	DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang AND SDT = @SDT
END
GO

-- SEARCH NhaCungCap

CREATE PROCEDURE dbo.sp_TimNhaCungCap @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNCC,TenNCC,SDT,DiaChi FROM NhaCungCap 
	WHERE MaNCC LIKE '%' + @Varible + '%' OR TenNCC LIKE '%' + @Varible + '%' OR DiaChi LIKE '%' + @Varible + '%' 
	OR SDT LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO NhaCungCap

CREATE PROCEDURE dbo.sp_ThemNhaCungCap @TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	DECLARE @MaNCC varchar(20)
	SET @MaNCC = CONCAT('NCC',CAST((SELECT IDENT_CURRENT('NhaCungCap')+1) AS varchar))
	INSERT INTO NhaCungCap (MaNCC,TenNCC,DiaChi,SDT) VALUES
	(@MaNCC,@TenNhaCungCap,@DiaChi,@SDT)
END
GO

-- UPDATE NhaCungCap

CREATE PROCEDURE dbo.sp_CapNhatNhaCungCap @MaNhaCungCap varchar(20),@TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE NhaCungCap SET TenNCC = @TenNhaCungCap,SDT = @SDT,DiaChi = @DiaChi WHERE MaNCC = @MaNhaCungCap
END
GO

-- DELETE NhaCungCap

CREATE PROCEDURE dbo.sp_XoaNhaCungCap @MaNhaCungCap varchar(20),@SDT varchar(20)
AS
BEGIN
	UPDATE SanPham SET MaNCC = '' WHERE MaNCC = @MaNhaCungCap
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNhaCungCap AND SDT = @SDT
END
GO

-- SEARCH SanPham

CREATE PROCEDURE dbo.sp_TimSanPham @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaSanPham,TenSanPham,LoaiSanPham,SoLuong,Gia,MaNCC,TrangThai,HinhAnh
	FROM SanPham
	WHERE MaSanPham LIKE '%' + @Varible + '%' OR TenSanPham LIKE '%' + @Varible + '%' OR LoaiSanPham LIKE '%' + @Varible + '%' 
	OR MaNCC LIKE '%' + @Varible + '%' OR TrangThai LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO SanPham

CREATE PROCEDURE dbo.sp_ThemSanPham @TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	DECLARE @MaSP varchar(20)
	SET @MaSP = CONCAT('SP',CAST((SELECT IDENT_CURRENT('SanPham')+1) AS varchar))
	INSERT INTO SanPham (MaSanPham,TenSanPham,LoaiSanPham,HinhAnh,SoLuong,Gia,MaNCC,TrangThai) VALUES
	(@MaSP,@TenSanPham,@LoaiSanPham,@HinhAnh,@SoLuong,@Gia,@MaNhaCungCap,@TrangThai)
END
GO

-- UPDATE SanPham

CREATE PROCEDURE dbo.sp_CapNhatSanPham @MaSanPham varchar(20),@TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE SanPham SET TenSanPham = @TenSanPham,LoaiSanPham = @LoaiSanPham,HinhAnh = @HinhAnh,SoLuong = @SoLuong,Gia = @Gia,MaNCC = @MaNhaCungCap,TrangThai = @TrangThai 
	WHERE MaSanPham = @MaSanPham
END
GO

-- DELETE SanPham 

CREATE PROCEDURE dbo.sp_XoaSanPham @MaSanPham varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham)
	DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham
	DELETE FROM HoaDon WHERE MaHoaDon = @MaHD
	DELETE FROM SanPham WHERE MaSanPham = @MaSanPham
END
GO

-- SEARCH HoaDon

CREATE PROCEDURE dbo.sp_TimHoaDon @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien 
	FROM HoaDon a inner join KhachHang b on a.MaKhachHang = b.MaKhachHang
	WHERE a.MaHoaDon LIKE '%' + @Varible + '%' OR a.MaKhachHang LIKE '%' + @Varible + '%' OR b.TenKhachHang LIKE '%' + @Varible + '%' 
	OR a.TrangThai LIKE '%' + @Varible + '%' OR a.MaNhanVien LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO HoaDon

CREATE PROCEDURE dbo.sp_TaoHoaDonMoi @TenKhachHang nvarchar(100),@SDT varchar(20),@NgayLap varchar(20),@MaNVGhi varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	DECLARE @MaKH varchar(20)

	SET @MaHD = CONCAT('HD',CAST((SELECT IDENT_CURRENT('HoaDon')+1) AS varchar))

	IF NOT EXISTS(SELECT SDT FROM KhachHang WHERE SDT = @SDT)
	BEGIN
		SET @MaKH = CONCAT('KH',CAST((SELECT IDENT_CURRENT('KhachHang')+1) AS varchar))
		INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SDT, DiaChi) VALUES
		(@MaKH,@TenKhachHang,@SDT,N'Chưa đặt')
	END
	ELSE
	BEGIN
		SET @MaKH = (SELECT MaKhachHang FROM KhachHang WHERE SDT = @SDT)
	END

	INSERT INTO HoaDon (MaHoaDon, MaKhachHang, NgayTao, TongTien, TrangThai, MaNhanVien) VALUES
	(@MaHD,@MaKH,@NgayLap,0,N'Chưa thanh toán',@MaNVGhi)
END
GO

-- UPDATE HoaDon

CREATE PROCEDURE dbo.sp_CapNhatHoaDon @MaHoaDon varchar(20),@MaKhachHang varchar(20),@TenKhachHang nvarchar(100),@NgayLap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE HoaDon SET NgayTao = @NgayLap,TrangThai = @TrangThai WHERE MaHoaDon = @MaHoaDon AND MaKhachHang = @MaKhachHang
	UPDATE KhachHang SET TenKhachHang = @TenKhachHang WHERE MaKhachHang = @MaKhachHang
END
GO

-- DELETE HoaDon

CREATE PROCEDURE dbo.sp_XoaHoaDon @MaHoaDon varchar(20),@MaKhachHang varchar(20)
AS
BEGIN
	DECLARE @SoLuong int
	DECLARE @MaSP varchar(20)

	WHILE EXISTS(SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	BEGIN
		SET @SoLuong = (SELECT TOP 1 SoLuong FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
		SET @MaSP = (SELECT TOP 1 MaSanPham FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
		UPDATE SanPham SET SoLuong = SoLuong + @SoLuong,TrangThai = N'Đang Bán' WHERE MaSanPham = @MaSP
		DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSP
	END
	
	IF NOT EXISTS(SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	BEGIN
		DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon
	END
END
GO

-- INSERT INTO ChiTietHoaDon

CREATE PROCEDURE dbo.sp_ThemChiTietHoaDon @MaHoaDon varchar(20),@MaKhachHang varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	DECLARE @SoLuongSanPham int
	SET @SoLuongSanPham = (SELECT SoLuong FROM SanPham WHERE MaSanPham = @MaSanPham)

	IF (@SoLuongSanPham >= @SoLuong)
	BEGIN
		INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong) VALUES
		(@MaHoaDon, @MaSanPham, @SoLuong)
		UPDATE SanPham SET SoLuong = @SoLuongSanPham - @SoLuong WHERE MaSanPham = @MaSanPham
	END
END
GO

-- UPDATE ChiTietHoaDon (Hoàn thành hoá đơn)

CREATE PROCEDURE dbo.sp_CapNhatChiTietHoaDon @MaHoaDon varchar(20),@MaKhachHang varchar(20),@TongThanhTien float
AS
BEGIN
	UPDATE HoaDon SET TongTien = TongTien + @TongThanhTien WHERE MaHoaDon = @MaHoaDon AND MaKhachHang = @MaKhachHang
END
GO

-- DELETE ChiTietHoaDon

CREATE PROCEDURE dbo.sp_XoaChiTietHoaDon @MaHoaDon varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong, TrangThai = N'Đang Bán' WHERE MaSanPham = @MaSanPham
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSanPham
END
GO

-- NGUNG LAP HOA DON

CREATE PROCEDURE dbo.sp_NgungLapHoaDon @MaHoaDon varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSanPham
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong WHERE MaSanPham = @MaSanPham
	
	IF NOT EXISTS(SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	BEGIN
		DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon
	END
END
