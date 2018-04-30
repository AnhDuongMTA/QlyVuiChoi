USE QuanLyKhuVuiChoi
GO
CREATE PROC Them_ThietBi (@MaTB VARCHAR(10),@TenTB NVARCHAR(30),@NgayBD DATE,@MaTC VARCHAR(10))
AS
BEGIN
	INSERT INTO dbo.ThietBi( Ma_TB, Ten_TB, Ngay_BD, Ma_TroChoi )
	VALUES  (@MaTB,@TenTB,@NgayBD,@MaTC)
END
GO
CREATE PROC Sua_ThietBi (@MaTB VARCHAR(10),@TenTB NVARCHAR(30),@NgayBD DATE,@MaTC VARCHAR(10))
AS
BEGIN
	UPDATE dbo.ThietBi
	SET Ten_TB = @TenTB,Ngay_BD = @NgayBD ,Ma_TroChoi = @MaTC
	WHERE Ma_TB = @MaTB
END
GO
CREATE PROC Xoa_ThietBi (@Ma VARCHAR(10))
AS
BEGIN
	DELETE dbo.ThietBi WHERE Ma_TB = @Ma
END
GO
CREATE PROC ThietBi_SelectAll
AS
BEGIN
	SELECT Ma_TB,Ten_TB,Ngay_BD,Ten_TroChoi FROM dbo.ThietBi,dbo.TroChoi
	WHERE ThietBi.Ma_TroChoi =TroChoi.Ma_TroChoi
END
GO 
CREATE PROC ThietBi_Select
AS
BEGIN
	SELECT * FROM dbo.ThietBi
END

--------------------------------------------
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
CREATE PROC Sua_VeChoi (@MaVe varchar(10),@MaKH VARCHAR(10),@TongTien int ,@MaKhu VARCHAR(10),@SoVeNL INT,@SoVeTE INT,@NgayBan DATE) 
AS
BEGIN
	UPDATE dbo.VeChoi SET So_VeNL = @SoVeNL,So_VeTE = @SoVeTE ,Ngay_Ban = @NgayBan,Tong_Tien = @TongTien ,Ma_KH = @MaKH,Ma_Khu = @MaKHu
	WHERE Ma_Ve = @MaVe
END
go
CREATE PROC Xoa_VeChoi(@Ma varchar(10))
AS
BEGIN
	DELETE dbo.VeChoi 
	WHERE Ma_Ve = @Ma
END
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
--------------------------------------------------------
CREATE PROC Them_CTDV (@MaDV varchar(10),@MaKhu varchar(10), @GioMo time, @GioDong time )
AS
BEGIN
	INSERT INTO dbo.ChiTietDV
	        ( MaDV, MaKhu, Gio_Mo, Gio_Dong )
	VALUES  (@MaDV ,@MaKhu,@GioMo,@GioDong )
END
GO 
CREATE PROC Xoa_CTDV (@MaDV varchar(10),@MaKhu varchar(10))
AS
BEGIN
DELETE dbo.ChiTietDV WHERE MaDV =@MaDV AND MaKhu =@MaKhu
END
GO
CREATE PROC CTDV_SelectID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT * FROM dbo.ChiTietDV WHERE MaKhu =@Ma
END
GO
--------------------------------------------------------
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
CREATE PROC CTTB_SelectID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaTC, Ten_TroChoi,MaTB,SoLuong FROM dbo.ChiTietThietBi,dbo.TroChoi WHERE MaTC =@Ma AND MaTC = Ma_TroChoi
END
GO