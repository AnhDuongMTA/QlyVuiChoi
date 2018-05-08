USE QuanLyKhuVuiChoi
GO
--Phiếu Mua--
GO

CREATE PROC XemPM
AS
BEGIN
	SELECT * FROM PhieuMua
END

GO
CREATE PROC ThemPM(@maphieu VARCHAR(10),@ngaymua DATE,@makh VARCHAR(10))
AS
BEGIN
	INSERT PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	VALUES (@maphieu,@ngaymua,@makh)
END

GO
CREATE PROC SuaPM(@maphieu VARCHAR(10),@ngaymua DATE,@makh VARCHAR(10))
AS
BEGIN
	UPDATE PhieuMua SET Ngay_Mua=@ngaymua,Ma_KH=@makh
	WHERE Ma_Phieu=@maphieu
END

GO
CREATE PROC XoaPM(@maphieu VARCHAR(10))
AS
BEGIN
	DELETE PhieuMua
	WHERE Ma_Phieu=@maphieu
END
GO
CREATE PROC XemTC
AS
BEGIN
SELECT dbo.TroChoi.Ma_TroChoi,dbo.TroChoi.Ten_TroChoi,dbo.TroChoi.Ma_Khu,dbo.KhuVuc.Gia_NL,dbo.KhuVuc.Gia_TE
FROM dbo.TroChoi INNER JOIN dbo.KhuVuc ON KhuVuc.Ma_Khu = TroChoi.Ma_Khu
END
go
CREATE PROC XemTTTC
AS
BEGIN
SELECT dbo.TroChoi.Ma_TroChoi,dbo.TroChoi.Ten_TroChoi,dbo.KhuVuc.Ma_Khu
FROM dbo.TroChoi INNER JOIN dbo.KhuVuc ON KhuVuc.Ma_Khu = TroChoi.Ma_Khu
END
