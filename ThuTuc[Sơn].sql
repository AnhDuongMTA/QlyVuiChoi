USE QuanLyKhuVuiChoi
GO
ALTER PROC Them_ThietBi (@MaTB VARCHAR(10),@TenTB NVARCHAR(30),@NgayBD DATE)
AS
BEGIN
	INSERT INTO dbo.ThietBi( Ma_TB, Ten_TB, Ngay_BD )
	VALUES  (@MaTB,@TenTB,@NgayBD)
END
GO
ALTER PROC Sua_ThietBi (@MaTB VARCHAR(10),@TenTB NVARCHAR(30),@NgayBD DATE)
AS
BEGIN
	UPDATE dbo.ThietBi
	SET Ten_TB = @TenTB,Ngay_BD = @NgayBD 
	WHERE Ma_TB = @MaTB
END
GO
CREATE PROC Xoa_ThietBi (@Ma VARCHAR(10))
AS
BEGIN
	DELETE dbo.ThietBi WHERE Ma_TB = @Ma
END
GO	
ALTER PROC ThietBi_SelectAll
AS
BEGIN 
 SELECT * FROM dbo.ThietBi
END
GO 
--------------------------------------------
GO 
CREATE PROC Them_TroChoi (@MaTC VARCHAR(10),@TenTC NVARCHAR(30),@MaKhu VARCHAR(10))
AS
BEGIN
	INSERT INTO dbo.TroChoi
	        ( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
	VALUES  (@MaTC,@TenTC,@MaKhu)
END
GO
CREATE PROC Sua_TroChoi (@MaTC VARCHAR(10),@TenTC NVARCHAR(30),@MaKhu VARCHAR(10))
AS
BEGIN
UPDATE dbo.TroChoi
SET Ten_TroChoi = @TenTC,Ma_Khu = @MaKhu
WHERE Ma_TroChoi = @MaTC
END
GO
CREATE PROC Xoa_TroChoi (@Ma VARCHAR(10))
AS
BEGIN
	DELETE dbo.TroChoi WHERE Ma_TroChoi = @Ma
END
GO
ALTER PROC TroChoi_SelectAll
AS
BEGIN
	SELECT Ma_TroChoi,Ten_TroChoi,Ten_Khu FROM dbo.TroChoi,dbo.KhuVuc
	WHERE KhuVuc.Ma_Khu = TroChoi.Ma_Khu
END
GO
CREATE PROC TroChoi_Select
AS
BEGIN 
	SELECT * FROM dbo.TroChoi
END
---------------------------------
CREATE PROC KhuVuc_SelectAll
AS
BEGIN
	SELECT * FROM dbo.KhuVuc
END
GO 
CREATE PROC VeChoi_SelectAll
AS
BEGIN
	SELECT Ma_Ve,Ten_Khu,Ten_KH ,So_VeNL,So_VeTE,Tong_Tien FROM dbo.VeChoi,dbo.KhachHang,dbo.KhuVuc
	WHERE KhachHang.Ma_KH = VeChoi.Ma_KH AND KhuVuc.Ma_Khu= VeChoi.Ma_Khu
END
GO 
CREATE PROC Them_VeChoi (@MaVe varchar(10),@MaKH VARCHAR(10),@TongTien int ,@MaKhu VARCHAR(10),@SoVeNL INT,@SoVeTE INT,@NgayBan DATE,@GiaVeNL INT,@GiaVeTE INT) 
AS
BEGIN
	INSERT INTO dbo.VeChoi
	        ( Ma_Ve ,
	          So_VeNL ,
	          So_VeTE ,
	          Ngay_Ban ,
	          Tong_Tien ,
	          Ma_KH ,
	          Ma_Khu,
			  GiaVeNL,
			  GiaVeTE
	        )
	VALUES  (@MaVe,@SoVeNL,@SoVeTE,@NgayBan,@SoVeNL*@GiaVeNL+ @SoVeTE*@GiaVeTE,@MaKH,@MaKhu)
END
GO 
ALTER PROC Sua_VeChoi (@MaVe varchar(10),@MaKH VARCHAR(10),@MaKhu VARCHAR(10),@SoVeNL INT,@SoVeTE INT,@NgayBan DATE,@GiaVeNL INT,@GiaVeTE INT) 
AS
BEGIN
	UPDATE dbo.VeChoi SET So_VeNL = @SoVeNL,So_VeTE = @SoVeTE ,Ngay_Ban = @NgayBan,Tong_Tien = @SoVeNL*@GiaVeNL+ @SoVeTE*@GiaVeTE ,Ma_KH = @MaKH,Ma_Khu = @MaKHu,GiaVeNL =@GiaVeNL,GiaVeTE =@GiaVeTE
	WHERE Ma_Ve = @MaVe
END
go
CREATE PROC Xoa_VeChoi(@Ma varchar(10))
AS
BEGIN
	DELETE dbo.VeChoi 
	WHERE Ma_Ve = @Ma
END
GO 
CREATE PROC TroChoi_SelectAll
AS 
BEGIN
	SELECT * FROM dbo.TroChoi
END
GO 
CREATE PROC KhuVuc_Select
AS
BEGIN
	SELECT * FROM dbo.KhuVuc WHERE Gia_NL > 0 OR Gia_TE > 0
END
GO 
CREATE PROC KhuVuc_SelectNV (@MaKhu varchar(10))
AS
BEGIN
	SELECT Ma_NV,Ten_NV,Ten_Khu,Gioi_Tinh,DiaChi,Luong FROM dbo.NhanVien,dbo.KhuVuc
	 WHERE KhuVuc.Ma_Khu= NhanVien.Ma_Khu and dbo.NhanVien.Ma_Khu = @MaKhu
END
go
CREATE PROC KhuVuc_SelectTC (@MaKhu varchar(10))
AS
BEGIN
	SELECT Ma_TroChoi,Ten_TroChoi,Ten_Khu FROM dbo.TroChoi,dbo.KhuVuc
	 WHERE KhuVuc.Ma_Khu= dbo.TroChoi.Ma_Khu and dbo.TroChoi.Ma_Khu = @MaKhu
END
go
CREATE PROC KhuVuc_SelectDV (@MaKhu varchar(10))
AS
BEGIN
	SELECT Ma_DV,Ten_DV,Ten_Khu,Gia_DV FROM dbo.DichVu,dbo.KhuVuc
	 WHERE DichVu.Ma_Khu= KhuVuc.Ma_Khu AND dbo.DichVu.Ma_Khu = @MaKhu
END
GO
-------------------------------------------------------- Chi Tiết Dịch Vụ--------------------------------------------------------
ALTER PROC Them_CTDV (@MaDV varchar(10),@MaKhu varchar(10), @Gia INT)
AS
BEGIN
	INSERT INTO dbo.ChiTietDV
	        ( MaDV, MaKhu, Gia )
	VALUES  (@MaDV ,@MaKhu,@Gia )
END
GO 
ALTER PROC Xoa_CTDV (@MaDV varchar(10),@MaKhu varchar(10))
AS
BEGIN
DELETE dbo.ChiTietDV WHERE MaDV =@MaDV AND MaKhu =@MaKhu
END
GO

ALTER PROC CTDV_SelectID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaKhu,Ten_Khu,Ten_DV,Gia FROM dbo.ChiTietDV,dbo.KhuVuc,dbo.DichVu WHERE MaKhu =@Ma AND MaDV = Ma_DV AND MaKhu = Ma_Khu
END
GO

--------------------------------------------------------Chi Tiết Thiết Bị -----------------------------------------------
ALTER PROC Them_CTTB (@MaTB varchar(10),@MaTC varchar(10),@SoLuong INT )
AS
BEGIN
	INSERT INTO dbo.ChiTietThietBi
	        ( MaTC, MaTB, SoLuong )
	VALUES  ( @MaTC,@MaTB,@SoLuong)
END
GO 
CREATE PROC Xoa_CTTB (@MaTB varchar(10),@MaTC varchar(10))
AS
BEGIN
DELETE dbo.ChiTietThietBi WHERE MaTC =@MaTC AND MaTB =@MaTB
END
GO
ALTER PROC CTTB_SelectID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaTC, Ten_TroChoi,Ten_TB,SoLuong FROM dbo.ChiTietThietBi,dbo.TroChoi,dbo.ThietBi WHERE MaTC =@Ma AND MaTC = Ma_TroChoi AND MaTB =Ma_TB 
END
GO