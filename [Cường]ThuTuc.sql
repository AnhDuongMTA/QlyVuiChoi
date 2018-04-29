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
