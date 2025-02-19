USE [master]
GO
/****** Object:  Database [QuanLiCuaHang]    Script Date: 2/17/2025 12:38:28 AM ******/
CREATE DATABASE [QuanLiCuaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiCuaHang', FILENAME = N'C:\Users\ChungBao\QuanLiCuaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLiCuaHang_log', FILENAME = N'C:\Users\ChungBao\QuanLiCuaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLiCuaHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiCuaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiCuaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiCuaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiCuaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiCuaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiCuaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiCuaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiCuaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiCuaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiCuaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiCuaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiCuaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLiCuaHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLiCuaHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLiCuaHang] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLiCuaHang] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLiCuaHang]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [varchar](20) NOT NULL,
	[MaSanPham] [varchar](20) NOT NULL,
	[SoLuong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [varchar](20) NOT NULL,
	[MaKhachHang] [varchar](20) NOT NULL,
	[NgayTao] [varchar](20) NOT NULL,
	[TongTien] [float] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [varchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[Luong] [float] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[HinhAnh] [varchar](100) NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaSanPham] [varchar](20) NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[LoaiSanPham] [nvarchar](100) NOT NULL,
	[HinhAnh] [varchar](100) NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [float] NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_Luong]  DEFAULT ((0)) FOR [Luong]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_Gia]  DEFAULT ((0)) FOR [Gia]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatChiTietHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatChiTietHoaDon] @MaHoaDon varchar(20),@MaKhachHang varchar(20),@TongThanhTien float
AS
BEGIN
	UPDATE HoaDon SET TongTien = TongTien + @TongThanhTien WHERE MaHoaDon = @MaHoaDon AND MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatHoaDon] @MaHoaDon varchar(20),@MaKhachHang varchar(20),@TenKhachHang nvarchar(100),@NgayLap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE HoaDon SET NgayTao = @NgayLap,TrangThai = @TrangThai WHERE MaHoaDon = @MaHoaDon AND MaKhachHang = @MaKhachHang
	UPDATE KhachHang SET TenKhachHang = @TenKhachHang WHERE MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatKhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatKhachHang] @MaKhachHang varchar(20),@TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE KhachHang SET TenKhachHang = @TenKhachHang,SDT = @SDT,DiaChi = @DiaChi
	WHERE MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatNhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatNhaCungCap] @MaNhaCungCap varchar(20),@TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	UPDATE NhaCungCap SET TenNCC = @TenNhaCungCap,SDT = @SDT,DiaChi = @DiaChi WHERE MaNCC = @MaNhaCungCap
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatNhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatNhanVien] @MaNhanVien varchar(20),@TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@Email varchar(50),@HinhAnh varchar(100),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE NhanVien SET TenNhanVien = @TenNhanVien,ChucVu = @ChucVu,Luong = @Luong,Email = @Email,HinhAnh = @HinhAnh,TrangThai = @TrangThai WHERE MaNhanVien = @MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatSanPham] @MaSanPham varchar(20),@TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	UPDATE SanPham SET TenSanPham = @TenSanPham,LoaiSanPham = @LoaiSanPham,HinhAnh = @HinhAnh,SoLuong = @SoLuong,Gia = @Gia,MaNCC = @MaNhaCungCap,TrangThai = @TrangThai 
	WHERE MaSanPham = @MaSanPham
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChucVuNguoiDN]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChucVuNguoiDN] @Email varchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT ChucVu FROM NhanVien WHERE Email = @Email
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DangNhap] @Email varchar(50),@MatKhau varchar(20)
AS
BEGIN
	SET NOCOUNT	ON
	DECLARE @status int
	IF EXISTS(SELECT Email, MatKhau FROM NhanVien WHERE Email = @Email and MatKhau = @MatKhau)
		SET @status = 1
	ELSE
		SET @status = 0
SELECT @status
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachChiTietHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachChiTietHoaDon] @MaHoaDon varchar(20)
AS
BEGIN
	SELECT a.MaHoaDon,a.MaSanPham,b.TenSanPham,a.SoLuong,b.Gia,(b.Gia * a.SoLuong) AS 'TongThanhTien' 
	FROM ChiTietHoaDon a inner join SanPham b on a.MaSanPham = b.MaSanPham WHERE a.MaHoaDon = @MaHoaDon ORDER BY b.Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachHoaDon]
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,b.SDT,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien 
	FROM HoaDon a inner join KhachHang b on a.MaKhachHang = b.MaKhachHang ORDER BY a.Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachKhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachKhachHang]
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang ORDER BY Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachNhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachNhaCungCap]
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNCC,TenNCC,SDT,DiaChi FROM NhaCungCap ORDER BY Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachNhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachNhanVien]
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,TrangThai,HinhAnh FROM NhanVien ORDER BY Id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachSanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachSanPham]
AS
BEGIN
	SET NOCOUNT ON
	UPDATE SanPham SET TrangThai = N'Hết Hàng' WHERE SoLuong < 1
	SELECT MaSanPham,TenSanPham,LoaiSanPham,SoLuong,Gia,TrangThai,MaNCC,HinhAnh
	FROM SanPham ORDER BY ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DoiMatKhau]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DoiMatKhau] @Email varchar(50),@OldPass varchar(20),@NewPass varchar(20),@NewPassAgain varchar(20)
AS
BEGIN
	DECLARE @old varchar(20)
	DECLARE @status int
	SELECT @old = MatKhau from NhanVien where Email = @Email

	IF (@old = @OldPass)
	BEGIN
		UPDATE NhanVien SET MatKhau = @NewPass WHERE Email = @Email AND @NewPass = @NewPassAgain
		SET @status = 1
	END
	ELSE
		SET @status = 0
SELECT @status
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaHDvaMaKH]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LayMaHDvaMaKH] @SDT varchar(20), @NgayTao varchar(20)
AS
BEGIN
	SELECT b.MaHoaDon,a.MaKhachHang FROM KhachHang a inner join HoaDon b on a.MaKhachHang = b.MaKhachHang
	WHERE b.NgayTao = @NgayTao AND a.SDT = @SDT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaNguoiDN]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaNguoiDN] @Email varchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien FROM NhanVien WHERE Email = @Email
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NgungLapHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NgungLapHoaDon] @MaHoaDon varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSanPham
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong WHERE MaSanPham = @MaSanPham
	
	IF NOT EXISTS(SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
	BEGIN
		DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_QuenMatKhau]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_QuenMatKhau] @Email varchar(50), @NewGenPassword varchar(20)
AS
BEGIN
	SET NOCOUNT	ON
	IF EXISTS(SELECT Email FROM NhanVien WHERE Email = @Email)
	BEGIN
		UPDATE NhanVien SET MatKhau = @NewGenPassword WHERE Email = @Email
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoHoaDonMoi]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaoHoaDonMoi] @TenKhachHang nvarchar(100),@SDT varchar(20),@NgayLap varchar(20),@MaNVGhi varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	DECLARE @MaKH varchar(20)

	SET @MaHD = CONCAT('HD',CAST((SELECT IDENT_CURRENT('HoaDon')+1) AS varchar))

	if not exists(SELECT SDT FROM KhachHang WHERE SDT = @SDT)
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
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemChiTietHoaDon] @MaHoaDon varchar(20),@MaKhachHang varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	DECLARE @SoLuongSanPham int
	DECLARE @GiaSanPham float
	SET @SoLuongSanPham = (SELECT SoLuong FROM SanPham WHERE MaSanPham = @MaSanPham)
	SET @GiaSanPham = (SELECT Gia FROM SanPham WHERE MaSanPham = @MaSanPham)

	IF (@SoLuongSanPham >= @SoLuong)
	BEGIN
		INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong) VALUES
		(@MaHoaDon, @MaSanPham, @SoLuong)
		UPDATE SanPham SET SoLuong = @SoLuongSanPham - @SoLuong WHERE MaSanPham = @MaSanPham
		UPDATE HoaDon SET TongTien += @SoLuong * @GiaSanPham
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemKhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemKhachHang] @TenKhachHang nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	IF NOT EXISTS (SELECT SDT FROM KhachHang WHERE SDT = @SDT)
	BEGIN
		DECLARE @MaKH varchar(20)
		SET @MaKH = CONCAT('KH',CAST((SELECT IDENT_CURRENT('KhachHang')+1) AS varchar))
		INSERT INTO KhachHang (MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES
		(@MaKH,@TenKhachHang,@SDT,@DiaChi)
	END
	ELSE
	BEGIN
		SELECT 0;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemNhaCungCap] @TenNhaCungCap nvarchar(100),@SDT varchar(20),@DiaChi nvarchar(255)
AS
BEGIN
	DECLARE @MaNCC varchar(20)
	SET @MaNCC = CONCAT('NCC',CAST((SELECT IDENT_CURRENT('NhaCungCap')+1) AS varchar))
	INSERT INTO NhaCungCap (MaNCC,TenNCC,DiaChi,SDT) VALUES
	(@MaNCC,@TenNhaCungCap,@DiaChi,@SDT)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemNhanVien] @TenNhanVien nvarchar(100),@ChucVu nvarchar(50),@Luong float,@Email varchar(50),@HinhAnh varchar(100),@TrangThai nvarchar(50),@MatKhau varchar(20)
AS
BEGIN
	DECLARE @MaNV varchar(20)
	SET @MaNV = CONCAT('NV',CAST((SELECT IDENT_CURRENT('NhanVien')+1) AS varchar))
	INSERT INTO NhanVien (MaNhanVien,TenNhanVien,ChucVu,Luong,Email,HinhAnh,TrangThai,MatKhau) VALUES
	(@MaNV,@TenNhanVien,@ChucVu,@Luong,@Email,@HinhAnh,@TrangThai,@MatKhau)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemSanPham] @TenSanPham nvarchar(100),@LoaiSanPham nvarchar(100),@HinhAnh varchar(200),@SoLuong int,@Gia float,@MaNhaCungCap varchar(20),@TrangThai nvarchar(50)
AS
BEGIN
	DECLARE @MaSP varchar(20)
	SET @MaSP = CONCAT('SP',CAST((SELECT IDENT_CURRENT('SanPham')+1) AS varchar))
	INSERT INTO SanPham (MaSanPham,TenSanPham,LoaiSanPham,HinhAnh,SoLuong,Gia,MaNCC,TrangThai) VALUES
	(@MaSP,@TenSanPham,@LoaiSanPham,@HinhAnh,@SoLuong,@Gia,@MaNhaCungCap,@TrangThai)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimHoaDon] @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT a.MaHoaDon,a.MaKhachHang,b.TenKhachHang,a.NgayTao,a.TongTien,a.TrangThai,a.MaNhanVien 
	FROM HoaDon a inner join KhachHang b on a.MaKhachHang = b.MaKhachHang
	WHERE a.MaHoaDon LIKE '%' + @Varible + '%' OR a.MaKhachHang LIKE '%' + @Varible + '%' OR b.TenKhachHang LIKE '%' + @Varible + '%' 
	OR a.TrangThai LIKE '%' + @Varible + '%' OR a.MaNhanVien LIKE '%' + @Varible + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKhachHang] @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaKhachHang,TenKhachHang,SDT,DiaChi FROM KhachHang 
	WHERE MaKhachHang LIKE '%' + @Varible + '%' OR TenKhachHang LIKE '%' + @Varible + '%' OR SDT LIKE '%' + @Varible + '%' 
	OR DiaChi LIKE '%' + @Varible + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimNhaCungCap] @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNCC,TenNCC,SDT,DiaChi FROM NhaCungCap 
	WHERE MaNCC LIKE '%' + @Varible + '%' OR TenNCC LIKE '%' + @Varible + '%' OR DiaChi LIKE '%' + @Varible + '%' 
	OR SDT LIKE '%' + @Varible + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimNhanVien] @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaNhanVien,TenNhanVien,ChucVu,Luong,Email,HinhAnh,TrangThai FROM NhanVien 
	WHERE MaNhanVien LIKE '%' + @Varible + '%' OR TenNhanVien LIKE '%' + @Varible + '%' OR ChucVu LIKE '%' + @Varible + '%' 
	OR Email LIKE '%' + @Varible + '%' OR TrangThai LIKE '%' + @Varible + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimSanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimSanPham] @Varible nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON
	SELECT MaSanPham,TenSanPham,LoaiSanPham,SoLuong,Gia,MaNCC,TrangThai,HinhAnh
	FROM SanPham
	WHERE MaSanPham LIKE '%' + @Varible + '%' OR TenSanPham LIKE '%' + @Varible + '%' OR LoaiSanPham LIKE '%' + @Varible + '%' 
	OR MaNCC LIKE '%' + @Varible + '%' OR TrangThai LIKE '%' + @Varible + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaChiTietHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaChiTietHoaDon] @MaHoaDon varchar(20),@MaSanPham varchar(20),@SoLuong int
AS
BEGIN
	UPDATE SanPham SET SoLuong = SoLuong + @SoLuong, TrangThai = N'Đang Bán' WHERE MaSanPham = @MaSanPham
	DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSanPham
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaHoaDon]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaHoaDon] @MaHoaDon varchar(20),@MaKhachHang varchar(20)
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
/****** Object:  StoredProcedure [dbo].[sp_XoaKhachHang]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaKhachHang] @MaKhachHang varchar(20),@SDT varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)

	WHILE EXISTS (SELECT TOP 1 MaHoaDon FROM HoaDon WHERE MaKhachHang = @MaKhachHang)
	BEGIN
		SET @MaHD = (SELECT TOP 1 MaHoaDon FROM HoaDon WHERE MaKhachHang = @MaKhachHang)
		DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHD
		DELETE FROM HoaDon WHERE MaKhachHang = @MaKhachHang
	END

	DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang AND SDT = @SDT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhaCungCap]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaNhaCungCap] @MaNhaCungCap varchar(20),@SDT varchar(20)
AS
BEGIN
	UPDATE SanPham SET MaNCC = '' WHERE MaNCC = @MaNhaCungCap
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNhaCungCap AND SDT = @SDT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaNhanVien] @MaNhanVien varchar(20)
AS
BEGIN
	DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSanPham]    Script Date: 2/17/2025 12:38:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaSanPham] @MaSanPham varchar(20)
AS
BEGIN
	DECLARE @MaHD varchar(20)
	SET @MaHD = (SELECT TOP 1 MaHoaDon FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham)
	DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham
	DELETE FROM HoaDon WHERE MaHoaDon = @MaHD
	DELETE FROM SanPham WHERE MaSanPham = @MaSanPham
END
GO
USE [master]
GO
ALTER DATABASE [QuanLiCuaHang] SET  READ_WRITE 
GO
