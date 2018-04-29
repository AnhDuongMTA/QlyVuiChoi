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
--------------------------------------------------------
CREATE PROC DangNhap(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50))
 AS
 BEGIN
 SELECT * FROM dbo.NguoiDung 
 WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau AND PhanQuyen=@PhanQuyen
 END
 GO
 --thu tuc them nguoi dung-----------------------------------------------
 CREATE PROC SP_ThemNguoiDung(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50))
 AS
 BEGIN
 INSERT dbo.NguoiDung
 VALUES  (@TaiKhoan,@MatKhau,@PhanQuyen )
 END
 GO
 --thu thuc xem nhân viên----------------------------------------------------
 CREATE PROC SP_XemThongTinNhanVien
 AS 
 BEGIN
 SELECT * FROM dbo.NhanVien
 END 
 GO
 --thủ tục thêm nhân viên------------------------------------------
 CREATE PROC SP_ThemNhanVien(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @MaKhu VARCHAR(50), @GioiTinh NVARCHAR(10),@NgaySinh DATE,@DiaChi NVARCHAR(50),@Luong INT)
 AS 
 BEGIN
INSERT dbo.NhanVien
VALUES  ( @MaNV ,@TenNV ,@MaKhu,@GioiTinh,@NgaySinh,@DiaChi,@Luong)
 END
 GO
 
 --thủ tục sửa nhân viên----------------------------------
 CREATE PROC SP_SuaNhanVien(@MaNV VARCHAR(50), @TenNV NVARCHAR(50), @MaKhu VARCHAR(50), @GioiTinh NVARCHAR(10),@NgaySinh DATE,@DiaChi NVARCHAR(50),@Luong INT)
 AS 
 BEGIN
 UPDATE dbo.NhanVien
 SET Ten_NV=@TenNV,Ma_Khu=@MaKhu,Gioi_Tinh=@GioiTinh,Ngay_Sinh=@NgaySinh,DiaChi=@DiaChi,Luong=@Luong
 WHERE Ma_NV=@MaNV
 END
 GO 
 --thủ tục xóa nhân viên
 CREATE PROC SP_XoaNhanVien(@MaNV VARCHAR(50))
 AS 
 BEGIN
 DELETE dbo.NhanVien
 WHERE Ma_NV=@MaNV
 END 
 SELECT * FROM dbo.NhanVien
 GO
 --thủ tục khách hàng
 --xem khách hàng
 CREATE PROC SP_XemKhachHang
 AS
BEGIN
	SELECT * FROM dbo.KhachHang
END
 --thêm khách hàng
 GO
 ALTER PROC SP_ThemKhachHang(@MaKH VARCHAR(10), @TenKH NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),@SDT INT  )
 AS
 BEGIN
	INSERT dbo.KhachHang
	VALUES  ( @MaKH,@TenKH,@NamSinh,@GioiTinh,@SDT )
 END
 GO
 --Sửa khách hàng
 ALTER PROC SP_SuaKhachHang(@MaKH VARCHAR(10), @TenKH NVARCHAR(50), @NamSinh INT, @GioiTinh NVARCHAR(10),@SDT INT ) 
 AS
 BEGIN
 	UPDATE dbo.KhachHang
	SET Ten_KH=@TenKH,Nam_Sinh=@NamSinh,Gioi_Tinh=@GioiTinh,SDT=@SDT
	WHERE Ma_KH=@MaKH
 END
 GO 
 --Xóa khách hàng
 CREATE PROC SP_XoaKhachHang(@MaKH VARCHAR(10))
 AS
 BEGIN
 	DELETE dbo.KhachHang
	WHERE Ma_KH=@MaKH
 END
 GO 
 --Thu tuc xem dich vu
 CREATE PROC SP_XemDichVu
 AS
 BEGIN
 	SELECT * FROM dbo.DichVu
 END
 GO
 --thu tuc them dich vu
 CREATE PROC SP_ThemDichVu(@MaDV VARCHAR(10), @TenDV NVARCHAR(50), @GiaDV INT, @MaKhu VARCHAR(10))
 AS
 BEGIN
 	INSERT dbo.DichVu
 	VALUES  ( @MaDV,@TenDV,@GiaDV,@MaKhu)
 END
 GO 
 --thu tuc sua dich vu
 ALTER PROC SP_SuaDichVu(@MaDV VARCHAR(10), @TenDV NVARCHAR(50), @GiaDV INT, @MaKhu VARCHAR(10))
 AS
 BEGIN
	UPDATE dbo.DichVu
	SET Ten_DV=@TenDV,Gia_DV=@GiaDV,Ma_Khu=@MaKhu
	WHERE Ma_DV=@MaDV
 END
 GO 
 --thu tuc xoa dich vu
 CREATE PROC SP_XoaDichVu(@MaDV VARCHAR(10))
 AS
 BEGIN
	DELETE dbo.ChiTietPhieuMua
	WHERE Ma_DV=@MaDV
 	DELETE dbo.DichVu
	WHERE Ma_DV=@MaDV
 END