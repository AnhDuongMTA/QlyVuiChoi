USE QuanLyKhuVuiChoi

go
ALTER PROC SP_ChiTietPhieuMuaSelectAll
AS
BEGIN
	SELECT dbo.PhieuMua.Ma_Phieu,Ten_DV,SoLuong,DonGia,ThanhTien, dbo.KhachHang.Ten_KH
	FROM ((dbo.ChiTietPhieuMua INNER JOIN dbo.DichVu ON DichVu.Ma_DV = ChiTietPhieuMua.Ma_DV) INNER JOIN dbo.PhieuMua ON PhieuMua.Ma_Phieu = ChiTietPhieuMua.Ma_Phieu) INNER JOIN dbo.KhachHang ON dbo.PhieuMua.Ma_KH = KhachHang.Ma_KH
END

GO
CREATE PROC SP_ThemCTPM @MaPhieu VARCHAR(10) , @MaDV VARCHAR(10), @SoLuong INT , @DonGia INT , @ThanhTien INT 
AS
BEGIN
	INSERT dbo.ChiTietPhieuMua( Ma_Phieu , Ma_DV ,SoLuong ,DonGia ,ThanhTien)
	VALUES  ( @MaPhieu,@MaDV,@SoLuong,@DonGia,@ThanhTien)
END 

GO 
ALTER PROC SP_SuaCTPM @MaPhieu VARCHAR(10) , @MaDV VARCHAR(10), @SoLuong INT , @DonGia INT , @ThanhTien INT 
AS
BEGIN
	UPDATE dbo.ChiTietPhieuMua SET SoLuong =@SoLuong,DonGia = @DonGia,ThanhTien = @SoLuong*@DonGia
	WHERE Ma_Phieu = @MaPhieu AND Ma_DV =@MaDV
END 

GO
CREATE PROC SP_XoaCTPM @MaPhieu VARCHAR(10) 
AS
BEGIN
	DELETE dbo.ChiTietPhieuMua
	WHERE Ma_Phieu =@MaPhieu
END 

GO
CREATE PROC SP_XemCTPM_MaPhieu @MaPhieu VARCHAR(10)
AS 
BEGIN
	SELECT c.Ma_DV,d.Ten_DV, SoLuong,DonGia,ThanhTien
	FROM dbo.ChiTietPhieuMua c INNER JOIN dbo.DichVu  d ON d.Ma_DV = c.Ma_DV
	WHERE c.Ma_Phieu = @MaPhieu
END

--- INSERT 
INSERT dbo.PhieuMua( Ma_Phieu, Ngay_Mua, Ma_KH )
VALUES  ( 'PM001',  GETDATE(),'KH019')
INSERT dbo.PhieuMua( Ma_Phieu, Ngay_Mua, Ma_KH )
VALUES  ( 'PM004',  GETDATE(),'KH018')
INSERT dbo.PhieuMua( Ma_Phieu, Ngay_Mua, Ma_KH )
VALUES  ( 'PM005',  GETDATE(),'KH017')
INSERT dbo.PhieuMua( Ma_Phieu, Ngay_Mua, Ma_KH )
VALUES  ( 'PM007',  GETDATE(),'KH016')
INSERT dbo.PhieuMua( Ma_Phieu, Ngay_Mua, Ma_KH )
VALUES  ( 'PM008',  GETDATE(),'KH015')


INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM001' ,'DV001' , 1 ,10000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM001' ,'DV002' , 10 ,1000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM001' ,'DV003' ,2 ,5000 , 10000)

INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM004' ,'DV001' , 1 ,10000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM004' ,'DV002' , 10 ,1000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM004' ,'DV003' , 3 ,5000 , 15000)

INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM005' ,'DV001' , 2 ,10000 , 20000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM005' ,'DV002' , 10 ,1000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM005' ,'DV003' , 3 ,5000 , 15000)

INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM007' ,'DV001' , 1 ,10000 , 10000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM007' ,'DV002' , 20 ,1000 , 20000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM007' ,'DV003' , 2 ,5000 , 10000)

INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM008' ,'DV001' , 3 ,10000 , 30000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM008' ,'DV002' , 20 ,1000 , 20000)
INSERT dbo.ChiTietPhieuMua( Ma_Phieu ,Ma_DV , SoLuong , DonGia ,ThanhTien)
VALUES  ( 'PM008' ,'DV003' , 2 ,5000 , 10000)
