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
