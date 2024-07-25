ALTER PROCEDURE dbo.sp_DangNhap @Email varchar(50),@MatKhau varchar(20)
AS
BEGIN
	SET NOCOUNT	ON
	declare @status int
	if exists(select * from NhanVien where Email = @Email and MatKhau = @MatKhau)
		set @status = 1
	else
		set @status = 0
select @status
END
GO

--CREATE PROCEDURE dbo.sp_TaoTaiKhoan @email varchar(50),@randomid varchar(5)
--AS
--BEGIN
--	DECLARE @nhanvien nvarchar(20)
--	DECLARE @id int
--	DECLARE @nv varchar(20)
--	SET @nhanvien = CONCAT('NhânViên ',@randomid)
--	SET @id = (SELECT TOP 1 Id FROM NhanVien ORDER BY Id DESC) + 1
--	SET NOCOUNT ON
--	INSERT INTO NhanVien (MaNV,Email,TenNV,DiaChi,VaiTro,TinhTrang,MatKhau)
--	VALUES (CONCAT('NV',CAST(@id AS varchar)),@email,@nhanvien,N'chưa đặt',0,0,'12345')
--END
--GO

--CREATE PROCEDURE dbo.sp_QuenMK @email varchar(50), @newgenpass varchar(20)
--AS
--BEGIN
--	SET NOCOUNT	ON
--	if exists(select * from NhanVien where email = @email)
--		BEGIN
--			UPDATE NhanVien SET MatKhau = @newgenpass where Email = @email
--		END
--END
--GO

ALTER PROCEDURE dbo.sp_DoiMatKhau @Email varchar(50),@OldPass varchar(20),@NewPass varchar(20),@NewPassAgain varchar(20)
AS
BEGIN
	declare @old varchar(20)
	declare @status int
	select @old = MatKhau from NhanVien where Email = @Email

	if (@old = @OldPass)
		begin
		update NhanVien set MatKhau = @NewPass where Email = @Email and @NewPass = @NewPassAgain
		SET @status = 1
		end
	else 
		SET @status = 0
SELECT @status
END
GO

--CREATE PROCEDURE dbo.sp_MaNguoiDN @email varchar(50)
--AS
--BEGIN
--	SET NOCOUNT ON
--	SELECT MaNV FROM NhanVien WHERE Email = @email
--END
--GO

--CREATE PROCEDURE dbo.sp_GuiHoTro @email varchar(20), @noidung nvarchar(450)
--AS
--BEGIN
--	INSERT INTO HoTro (Email,NoiDung)
--	VALUES (@email,@noidung)
--END