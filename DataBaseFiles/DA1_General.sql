-- LOAD DATA TO GRIDVIEW

ALTER PROCEDURE dbo.sp_DanhSachSanPham
AS
BEGIN
	SET NOCOUNT ON
	UPDATE SanPham SET TrangThai = N'Hết Hàng' WHERE SoLuong < 1

	SELECT MaSanPham,TenSanPham,LoaiSanPham,Gia,SoLuong,MaNCC,TrangThai,HinhAnh
	FROM SanPham
END
GO

ALTER PROCEDURE dbo.sp_DanhSachKhachHang
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang
END
GO

ALTER PROCEDURE dbo.sp_DanhSachNhanVien
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,TrangThai FROM NhanVien
END
GO

ALTER PROCEDURE dbo.sp_DanhSachNhaCungCap
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNCC,TenNCC,DiaChi,SDT FROM NhaCungCap
END
GO

ALTER PROCEDURE dbo.sp_DanhSachHoaDon
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,b.SDT,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien
	FROM HoaDon a join KhachHang b on a.MaKhachHang = b.MaKhachHang
END
GO

ALTER PROCEDURE dbo.sp_DanhSachChiTietHoaDon @TenKhachHang nvarchar(100)
AS
BEGIN
	--DECLARE @MaKH varchar(20)
	--SET @MaKH = (SELECT TOP 1 MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang)
	--SET NOCOUNT ON
	--SELECT a.MaHoaDon,b.MaSanPham,c.TenSanPham,b.SoLuong,c.Gia,(b.SoLuong * c.Gia) as 'TongTien'
	--FROM HoaDon a inner join (ChiTietHoaDon b inner join SanPham c on b.MaSanPham = c.MaSanPham )on a.MaHoaDon = b.MaHoaDon
	--WHERE a.MaKhachHang = @MaKH

	select a.MaHoaDon,a.MaSanPham,d.TenSanPham,a.SoLuong,d.Gia,(a.SoLuong*d.Gia) as 'TongTien',c.TenKhachHang from ChiTietHoaDon a
	inner join HoaDon b on a.MaHoaDon = b.MaHoaDon
	inner join KhachHang c on b.MaKhachHang = c.MaKhachHang
	inner join SanPham d on a.MaSanPham = d.MaSanPham WHERE c.TenKhachHang = @TenKhachHang
END
GO

-- SEARCH NhanVien

ALTER PROCEDURE dbo.sp_TimNhanVien @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,TrangThai FROM NhanVien 
	WHERE MaNhanVien LIKE '%' + @Varible + '%' OR TenNhanVien LIKE '%' + @Varible + '%' OR Email LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO NhanVien

ALTER PROCEDURE dbo.sp_ThemNhanVien @TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@Email varchar(50),@HinhAnh varchar(100),@TrangThai nvarchar(50),@MatKhau varchar(20)
AS
BEGIN
	DECLARE @MaNV varchar(20)
	SET @MaNV = CONCAT('NV',CAST((SELECT MAX(Id + 1) FROM NhanVien) AS varchar))
	INSERT INTO NhanVien (MaNhanVien,TenNhanVien,ChucVu,Luong,Email,HinhAnh,TrangThai,MatKhau) VALUES
	(@MaNV,@TenNhanVien,@ChucVu,@Luong,@Email,@HinhAnh,@TrangThai,@MatKhau)
END
GO

-- UPDATE NhanVien

ALTER PROCEDURE dbo.sp_CapNhatNhanVien @MaNhanVien varchar(20),@TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@HinhAnh varchar(100),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE NhanVien SET TenNhanVien = @TenNhanVien,ChucVu = @ChucVu,Luong = @Luong,HinhAnh = @HinhAnh,TrangThai = @TrangThai WHERE MaNhanVien = @MaNhanVien
END
GO

-- DELETE NhanVien

ALTER PROCEDURE dbo.sp_XoaNhanVien @MaNhanVien varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT MaHoaDon FROM HoaDon WHERE MaNhanVien = @MaNhanVien)
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHD
	DELETE FROM HoaDon WHERE MaNhanVien = @MaNhanVien
	DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien
END
GO

-- SEARCH KhachHang

ALTER PROCEDURE dbo.sp_TimKhachHang @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang 
	WHERE MaKhachHang LIKE '%' + @Varible + '%' OR TenKhachHang LIKE '%' + @Varible + '%' OR SDT LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO KhachHang

ALTER PROCEDURE dbo.sp_ThemKhachHang @TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	DECLARE @MaKH varchar(20)
	SET @MaKH = CONCAT('KH',CAST((SELECT MAX(Id + 1) FROM KhachHang) AS varchar))
	INSERT INTO KhachHang (MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES
	(@MaKH,@TenKhachHang,@SDT,@DiaChi)
END
GO

-- UPDATE KhachHang

ALTER PROCEDURE dbo.sp_CapNhatKhachHang @MaKhachHang varchar(20),@TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE KhachHang SET TenKhachHang = @TenKhachHang,SDT = @SDT,DiaChi = @DiaChi
	WHERE MaKhachHang = @MaKhachHang AND SDT = @SDT
END
GO

-- DELETE KhachHang

ALTER PROCEDURE dbo.sp_XoaKhachHang @MaKhachHang varchar(20),@SDT varchar(20)
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

ALTER PROCEDURE dbo.sp_TimNhaCungCap @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaNCC, a.TenNCC, b.MaSanPham, a.DiaChi, a.SDT FROM NhaCungCap a inner join SanPham b on a.MaNCC = b.MaNCC 
	WHERE a.MaNCC LIKE '%' + @Varible + '%' OR a.TenNCC LIKE '%' + @Varible + '%' OR b.MaSanPham LIKE '%' + @Varible + '%' OR a.SDT LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO NhaCungCap

ALTER PROCEDURE dbo.sp_ThemNhaCungCap @TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	DECLARE @MaNCC varchar(20)
	SET @MaNCC = CONCAT('NCC',CAST((SELECT MAX(Id + 1) FROM NhaCungCap) AS varchar))
	INSERT INTO NhaCungCap (MaNCC,TenNCC,DiaChi,SDT) VALUES
	(@MaNCC,@TenNhaCungCap,@DiaChi,@SDT)
END
GO

-- UPDATE NhaCungCap

ALTER PROCEDURE dbo.sp_CapNhatNhaCungCap @MaNhaCungCap varchar(20),@TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE NhaCungCap SET TenNCC = @TenNhaCungCap,SDT = @SDT,DiaChi = @DiaChi WHERE MaNCC = @MaNhaCungCap
END
GO

-- DELETE NhaCungCap

ALTER PROCEDURE dbo.sp_XoaNhaCungCap @MaNhaCungCap varchar(20),@SDT varchar(20)
AS
BEGIN
	UPDATE SanPham SET MaNCC = '' WHERE MaNCC = @MaNhaCungCap
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNhaCungCap AND SDT = @SDT
END
GO

-- SEARCH SanPham

ALTER PROCEDURE dbo.sp_TimSanPham @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaSanPham,TenSanPham,LoaiSanPham,SoLuong,Gia,MaNCC,TrangThai,HinhAnh
	FROM SanPham
	WHERE MaSanPham LIKE '%' + @Varible + '%' OR TenSanPham LIKE '%' + @Varible + '%' OR LoaiSanPham LIKE '%' + @Varible + '%' OR MaNCC LIKE '%' + @Varible + '%'
END
GO

-- INSERT INTO SanPham

ALTER PROCEDURE dbo.sp_ThemSanPham @TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	DECLARE @MaSP varchar(20)
	SET @MaSP = CONCAT('SP',CAST((SELECT MAX(Id + 1) FROM SanPham) AS varchar))
	INSERT INTO SanPham (MaSanPham,TenSanPham,LoaiSanPham,HinhAnh,SoLuong,Gia,MaNCC,TrangThai) VALUES
	(@MaSP,@TenSanPham,@LoaiSanPham,@HinhAnh,@SoLuong,@Gia,@MaNhaCungCap,@TrangThai)
END
GO

-- UPDATE SanPham

ALTER PROCEDURE dbo.sp_CapNhatSanPham @MaSanPham varchar(20),@TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE SanPham SET TenSanPham = @TenSanPham,LoaiSanPham = @LoaiSanPham,HinhAnh = @HinhAnh,SoLuong = @SoLuong,Gia = @Gia,MaNCC = @MaNhaCungCap,TrangThai = @TrangThai WHERE MaSanPham = @MaSanPham
END
GO

-- DELETE SanPham 

ALTER PROCEDURE dbo.sp_XoaSanPham @MaSanPham varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham)
	DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham
	DELETE FROM HoaDon WHERE MaHoaDon = @MaHD
	DELETE FROM SanPham WHERE MaSanPham = @MaSanPham
END
GO


--CREATE PROCEDURE dbo.sp_TimHang @tenhang varchar(50)
--AS
--BEGIN
--	SET NOCOUNT ON
--	SELECT * FROM Hang WHERE TenHang LIKE '%' + @tenhang + '%'
--END
--GO

--CREATE PROCEDURE dbo.sp_ThemHang @tenhang nvarchar(50),@soluong int,@dongianhap float,@dongiaban float,@hinhanh varchar(200),@ghichu nvarchar(20),@manv varchar(20)
--AS
--BEGIN
--	INSERT INTO Hang(TenHang,SoLuong,DonGiaNhap,DonGiaBan,HinhAnh,GhiChu,MaNV)
--	VALUES (@tenhang,@soluong,@dongianhap,@dongiaban,@hinhanh,@ghichu,@manv)
--END
--GO

--CREATE PROCEDURE dbo.sp_CapNhatHang @mahang int,@tenhang nvarchar(50),@soluong int,@dongianhap float,@dongiaban float,@hinhanh varchar(200),@ghichu nvarchar(20)
--AS
--BEGIN
--	UPDATE Hang SET TenHang = @tenhang,SoLuong = @soluong,DonGiaNhap = @dongianhap,DonGiaBan = @dongiaban,HinhAnh = @hinhanh,GhiChu = @ghichu
--	WHERE MaHang = @mahang
--END
--GO

--CREATE PROCEDURE dbo.sp_XoaHang @mahang int
--AS
--BEGIN
--	DELETE FROM Hang WHERE MaHang = @mahang
--END
--GO

-- SEARCH HoaDon

ALTER PROCEDURE dbo.sp_TimHoaDon @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien
	FROM HoaDon a inner join KhachHang b on a.MaKhachHang = b.MaKhachHang
	WHERE a.MaHoaDon LIKE '%' + @Varible + '%' OR a.MaKhachHang LIKE '%' + @Varible + '%' OR b.TenKhachHang LIKE '%' + @Varible + '%' OR a.TrangThai LIKE '%' + @Varible + '%' OR a.MaNhanVien LIKE '%' + @Varible + '%'
END
GO

-- INSERT HoaDon

ALTER PROCEDURE dbo.sp_TaoHoaDonMoi @TenKhachHang nvarchar(100),@SDT varchar(20),@NgayLap varchar(20),@MaNVGhi varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	DECLARE @MaKH varchar(20)

	SET @MaHD = CONCAT('HD',CAST((SELECT MAX(Id + 1) FROM HoaDon) AS varchar))

	if not exists(SELECT SDT FROM KhachHang WHERE SDT = @SDT)
	BEGIN
		SET @MaKH = CONCAT('KH',CAST((SELECT MAX(Id + 1) FROM KhachHang) AS varchar))
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

ALTER PROCEDURE dbo.sp_CapNhatHoaDon @MaHoaDon varchar(20),@TenKhachHang nvarchar(100),@NgayLap varchar(20)
AS
BEGIN
	DECLARE @MaKH varchar(20)
	SET @MaKH = (SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang)

	UPDATE HoaDon SET MaKhachHang = @MaKH,NgayTao = @NgayLap WHERE MaHoaDon = @MaHoaDon
END
GO

-- DELETE HoaDon

ALTER PROCEDURE dbo.sp_XoaHoaDon @MaHoaDon varchar(20)
AS
BEGIN
	DECLARE @SoLuong int
	SET @SoLuong = (SELECT TOP 1 SoLuong FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	DECLARE @MaSP varchar(20)
	SET @MaSP = (SELECT MaSanPham FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong, TrangThai = N'Đang Bán' WHERE MaSanPham = @MaSP
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon
	DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon
END
GO

-- INSERT ChiTietHoaDon

ALTER PROCEDURE dbo.sp_ThemChiTietHoaDon @TenKhachHang nvarchar(100),@MaSanPham varchar(20),@SoLuong int,@TongThanhTien float
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY Id DESC)
	DECLARE @SoLuongSanPham int
	SET @SoLuongSanPham = (SELECT SoLuong FROM SanPham WHERE MaSanPham = @MaSanPham)

	IF (@SoLuongSanPham > @SoLuong)
	BEGIN
		INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong) VALUES
		(@MaHD, @MaSanPham, @SoLuong)

		UPDATE HoaDon SET TongTien = @TongThanhTien WHERE MaHoaDon = @MaHD
		UPDATE SanPham SET SoLuong = @SoLuongSanPham - @SoLuong WHERE MaSanPham = @MaSanPham
	END
END
GO

-- UPDATE ChiTietHoaDon (Hoàn thành hoá đơn)

ALTER PROCEDURE dbo.sp_CapNhatChiTietHoaDon @MaHoaDon varchar(20),@TongTien float
AS
BEGIN
	UPDATE HoaDon SET TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon
END
GO

-- DELETE ChiTietHoaDon

ALTER PROCEDURE dbo.sp_XoaChiTietHoaDon @MaSanPham varchar(20)
AS
BEGIN
	DECLARE @SoLuong int
	SET @SoLuong = (SELECT TOP 1 SoLuong FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham)
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong, TrangThai = N'Đang Bán' WHERE MaSanPham = @MaSanPham
	DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham
END
GO

--CREATE PROCEDURE dbo.sp_ThemHoaDon @MaKH varchar(20),@MaSP varchar(20),@SoLuongMua int, @MaNV varchar(20), @NgayTao varchar(20), @TrangThai nvarchar(20)
--AS
--BEGIN
--	DECLARE @Id varchar(20) 
--	SET @Id = CONCAT('SP',CAST((SELECT MAX(Id) FROM HoaDon) + 1 AS varchar))

--	INSERT INTO HoaDon (MaHoaDon, MaKH, MaNV, NgayTao, TrangThai)
--	VALUES (@Id, @MaKH, @MaNV, @NgayTao, @TrangThai)
--	INSERT INTO ChiTietHoaDon (MaHoaDon,MaSanPham,SoLuong)
--	VALUES (@Id,@MaSP,@SoLuongMua)
--END
--GO

--CREATE PROCEDURE dbo.sp_TinhTien
--AS
--BEGIN
--	DECLARE @TongTien float
--	SET @TongTien = (SELECT SUM(c.Gia * b.SoLuong) FROM (HoaDon a inner join ChiTietHoaDon b on a.MaHoaDon = b.MaHoaDon) inner join SanPham c on c.MaSanPham = b.MaSanPham WHERE a.MaKH = @MaKH)
--	SELECT @TongTien
--END
