USE QuanLyKhuVuiChoi
GO
------------------------------------------------------
CREATE TABLE NguoiDung
(
	TaiKhoan NVARCHAR(50),
	MatKhau NVARCHAR(50),
	PhanQuyen VARCHAR(20)
)
------------------------------------------------------
GO 
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( N'admin', -- TaiKhoan - nvarchar(50)
          N'admin', -- MatKhau - nvarchar(50)
          'Admin'  -- PhanQuyen - varchar(20)
          )
GO 
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( N'user1', -- TaiKhoan - nvarchar(50)
          N'1', -- MatKhau - nvarchar(50)
          'User'  -- PhanQuyen - varchar(20)
          )
GO 
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( N'user2', -- TaiKhoan - nvarchar(50)
          N'2', -- MatKhau - nvarchar(50)
          'User'  -- PhanQuyen - varchar(20)
          )
GO 
---------------------------------------------------------
--------------------------------------------------------
CREATE PROC DangNhap(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50))
 AS
 BEGIN
 SELECT * FROM dbo.NguoiDung 
 WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau AND PhanQuyen=@PhanQuyen
 END
 GO
 ---------------------------------------------------------
 --thu tuc them nguoi dung-----------------------------------------------
 CREATE PROC SP_ThemNguoiDung(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50))
 AS
 BEGIN
 INSERT dbo.NguoiDung
 VALUES  (@TaiKhoan,@MatKhau,@PhanQuyen )
 END
 GO
 ---------------------------------------------------------
 --thu thuc xem nhân viên----------------------------------------------------
 CREATE PROC SP_XemThongTinNhanVien
 AS 
 BEGIN
 SELECT * FROM dbo.NhanVien
 END 
 GO
 ---------------------------------------------------------
 --thủ tục thêm nhân viên------------------------------------------
 CREATE PROC SP_ThemNhanVien(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @MaKhu VARCHAR(50), @GioiTinh NVARCHAR(10),@NgaySinh DATE,@DiaChi NVARCHAR(50),@Luong INT)
 AS 
 BEGIN
INSERT dbo.NhanVien
VALUES  ( @MaNV ,@TenNV ,@MaKhu,@GioiTinh,@NgaySinh,@DiaChi,@Luong)
 END
 GO
 ---------------------------------------------------------
 --thủ tục sửa nhân viên----------------------------------
 CREATE PROC SP_SuaNhanVien(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @MaKhu VARCHAR(50), @GioiTinh NVARCHAR(10),@NgaySinh DATE,@DiaChi NVARCHAR(50),@Luong INT)
 AS 
 BEGIN
 UPDATE dbo.NhanVien
 SET Ten_NV=@TenNV,Ma_Khu=@MaKhu,Gioi_Tinh=@GioiTinh,Ngay_Sinh=@NgaySinh,DiaChi=@DiaChi,Luong=@Luong
 WHERE Ma_NV=@MaNV
 END
 GO 
 ---------------------------------------------------------
 --thủ tục xóa nhân viên
 CREATE PROC SP_XoaNhanVien(@MaNV VARCHAR(50))
 AS 
 BEGIN
 DELETE dbo.NhanVien
 WHERE Ma_NV=@MaNV
 END 
 SELECT * FROM dbo.NhanVien
 GO
 ---------------------------------------------------------
 --thủ tục khách hàng
 --xem khách hàng
 CREATE PROC SP_XemKhachHang
 AS
BEGIN
	SELECT * FROM dbo.KhachHang
END
 --thêm khách hàng
 ---------------------------------------------------------
 GO
CREATE PROC SP_ThemKhachHang(@MaKH VARCHAR(10), @TenKH NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),@SDT INT  )
 AS
 BEGIN
	INSERT dbo.KhachHang
	VALUES  ( @MaKH,@TenKH,@NamSinh,@GioiTinh,@SDT )
 END
 GO
 ---------------------------------------------------------
 --Sửa khách hàng
CREATE PROC SP_SuaKhachHang(@MaKH VARCHAR(10), @TenKH NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),@SDT INT ) 
 AS
 BEGIN
 	UPDATE dbo.KhachHang
	SET Ten_KH=@TenKH,Nam_Sinh=@NamSinh,Gioi_Tinh=@GioiTinh,SDT=@SDT
	WHERE Ma_KH=@MaKH
 END
 GO 
 ---------------------------------------------------------
 --Xóa khách hàng
 CREATE PROC SP_XoaKhachHang(@MaKH VARCHAR(10))
 AS
 BEGIN
 	DELETE dbo.KhachHang
	WHERE Ma_KH=@MaKH
 END
 GO 
 ---------------------------------------------------------
  --Thu tuc xem dich vu
 CREATE PROC SP_XemDichVu
 AS
 BEGIN
 	SELECT dv.Ma_DV,dv.Ten_DV,dv.Gia_DV,ctdv.Gio_Mo,ctdv.Gio_Dong,ctdv.MaKhu FROM dbo.DichVu AS dv JOIN dbo.ChiTietDV AS ctdv
	ON  dv.Ma_DV=ctdv.MaDV
 END
 GO
 ---------------------------------------------------------
 --thu tuc them dich vu
 CREATE PROC SP_ThemDichVu(@MaDV VARCHAR(10), @TenDV NVARCHAR(50), @GiaDV INT, @GioMo INT , @GioDong INT, @MaKhu VARCHAR(10) )
 AS
 BEGIN
 	INSERT dbo.DichVu
 	        ( Ma_DV, Ten_DV, Gia_DV )
 	VALUES  ( @MaDV, @TenDV, @GiaDV)
	INSERT ChiTietDV
	VALUES (@MaDV,@MaKhu,@GioMo,@GioDong)
 END
 GO 
 ---------------------------------------------------------
 --thu tuc sua dich vu
 CREATE PROC SP_SuaDichVu(@MaDV VARCHAR(10), @TenDV NVARCHAR(50), @GiaDV INT,@GioMo INT , @GioDong INT, @MaKhu VARCHAR(10))
 AS
 BEGIN
	UPDATE dbo.DichVu
	SET Ten_DV=@TenDV,Gia_DV=@GiaDV
	WHERE Ma_DV=@MaDV
	UPDATE ChiTietDV
	SET MaKhu=@MaKhu,Gio_Mo=@GioMo,Gio_Dong=@GioDong
	WHERE MaDV=@MaDV
 END
 GO 
 ---------------------------------------------------------
 --thu tuc xoa dich vu
 CREATE PROC SP_XoaDichVu(@MaDV VARCHAR(10))
 AS
 BEGIN
	DELETE dbo.ChiTietPhieuMua
	WHERE Ma_DV=@MaDV
 	DELETE dbo.DichVu
	WHERE Ma_DV=@MaDV
	DELETE ChiTietDV
	WHERE MaDV=@MaDV
 END
 GO 
 ---------------------------------------------------------
 CREATE TABLE TongTien
(
	SoVeNL INT,
	SoVeTE INT,
	GiaVeNL INT,
	GiaVeTE INT,
	TongTien INT 
)
GO 
---------------------------------------------------------
CREATE PROC SP_DoanhThuBanVe(@NgayBan1 DATETIME,@NgayBan2 DATETIME)
AS 
BEGIN
DELETE TongTien
	DECLARE a CURSOR FOR ( SELECT So_VeNL, Gia_NL, So_VeTE,Gia_TE FROM dbo.KhuVuc JOIN dbo.VeChoi ON VeChoi.Ma_Khu = KhuVuc.Ma_Khu  WHERE Ngay_Ban BETWEEN @NgayBan1 AND @NgayBan2  )
OPEN a
	DECLARE @SoVeNL INT
	DECLARE @GiaVeNL int 
	DECLARE @SoVeTE INT 
	DECLARE @GiaVeTE INT 
	DECLARE @TongTien INT
	FETCH NEXT FROM a INTO @SoVeNL,@GiaVeNL,@SoVeTE,@GiaVeTE
	WHILE @@FETCH_STATUS =0
	BEGIN
		SELECT  @TongTien = @SoVeNL*@GiaVeNL + @SoVeTE*@GiaVeTE
		INSERT TongTien
		VALUES(@SoVeNL,@GiaVeNL,@SoVeTE,@GiaVeTE,@TongTien)

		FETCH NEXT FROM a INTO @SoVeNL,@GiaVeNL,@SoVeTE,@GiaVeTE
	END
	
CLOSE a 
DEALLOCATE a
SELECT * FROM TongTien
END	
GO 
--------------------------------------------------------
CREATE TABLE DoanhThuDichVu
(
	TenDV NVARCHAR(50),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT
)
GO 
---------------------------------------------------------
CREATE PROC SP_DoanhThuDichVu(@NgayMua1 DATETIME,@NgayMua2 DATETIME)
AS 
BEGIN
DELETE DoanhThuDichVu
	DECLARE a CURSOR FOR ( SELECT Ten_DV,SoLuong,DonGia 
							FROM dbo.PhieuMua JOIN dbo.ChiTietPhieuMua
							ON ChiTietPhieuMua.Ma_Phieu = PhieuMua.Ma_Phieu
							JOIN dbo.DichVu ON DichVu.Ma_DV = ChiTietPhieuMua.Ma_DV  
							WHERE Ngay_Mua BETWEEN @NgayMua1 AND @NgayMua2  )
OPEN a
	DECLARE @TenDV NVARCHAR(50)
	DECLARE @SoLuong INT   
	DECLARE @DonGia INT 
	DECLARE @ThanhTien INT
	FETCH NEXT FROM a INTO @TenDV,@SoLuong,@DonGia
	WHILE @@FETCH_STATUS =0
	BEGIN
		SELECT  @ThanhTien = @SoLuong*@DonGia
		INSERT DoanhThuDichVu
		VALUES(@TenDV,@SoLuong,@DonGia,@ThanhTien)
		FETCH NEXT FROM a INTO @TenDV,@SoLuong,@DonGia
	END
	
CLOSE a 
DEALLOCATE a
SELECT * FROM DoanhThuDichVu
END	