USE QuanLyKhuVuiChoi

go
CREATE PROC SP_ChiTietPhieuMuaSelectAll
AS
BEGIN
	SELECT *FROM dbo.ChiTietPhieuMua
END

GO
CREATE PROC SP_ThemCTPM @MaPhieu VARCHAR(10) , @MaDV VARCHAR(10), @SoLuong INT , @DonGia INT , @ThanhTien INT 
AS
BEGIN
	INSERT dbo.ChiTietPhieuMua( Ma_Phieu , Ma_DV ,SoLuong ,DonGia ,ThanhTien)
	VALUES  ( @MaPhieu,@MaDV,@SoLuong,@DonGia,@ThanhTien)
END 

GO 
CREATE PROC SP_SuaCTPM @MaPhieu VARCHAR(10) , @MaDV VARCHAR(10), @SoLuong INT , @DonGia INT , @ThanhTien INT 
AS
BEGIN
	UPDATE dbo.ChiTietPhieuMua SET Ma_DV = @MaDV,SoLuong =@SoLuong,DonGia = @DonGia,ThanhTien = @ThanhTien
END 

GO
CREATE PROC SP_XoaCTPM @MaPhieu VARCHAR(10) 
AS
BEGIN
	DELETE dbo.ChiTietPhieuMua
	WHERE Ma_Phieu =@MaPhieu
END 