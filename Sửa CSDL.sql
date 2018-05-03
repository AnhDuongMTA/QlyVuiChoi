USE QuanLyKhuVuiChoi
GO
ALTER TABLE dbo.DichVu DROP CONSTRAINT FK__DichVu__Ma_Khu__2C3393D0
ALTER TABLE dbo.DichVu DROP COLUMN Ma_Khu

ALTER TABLE dbo.ThietBi DROP CONSTRAINT FK__ThietBi__Ma_TroC__29572725
ALTER TABLE dbo.ThietBi DROP COLUMN Ma_TroChoi

CREATE TABLE ChiTietDV (
MaDV VARCHAR(10) REFERENCES dbo.DichVu(Ma_DV),
MaKhu VARCHAR(10) REFERENCES dbo.KhuVuc(Ma_Khu),
Gio_Mo TIME,
Gio_Dong TIME
)
CREATE TABLE ChiTietThietBi (
MaTC VARCHAR(10) REFERENCES dbo.TroChoi(Ma_TroChoi),
MaTB VARCHAR(10) REFERENCES dbo.ThietBi(Ma_TB),
SoLuong INT
)

ALTER TABLE dbo.ChiTietDV DROP COLUMN Gio_Mo
ALTER TABLE dbo.ChiTietDV DROP COLUMN Gio_Dong

ALTER TABLE dbo.ChiTietDV ADD  Gia INT

ALTER TABLE dbo.NguoiDung ADD MaNV VARCHAR(10) REFERENCES dbo.NhanVien(Ma_NV)
INSERT INTO dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen ,MaNV)
VALUES  ( N'NV001', -- TaiKhoan - nvarchar(50)
          N'Admin', -- MatKhau - nvarchar(50)
          'Admin',  -- PhanQuyen - varchar(20)
		  'NV001'
          )
--thu tuc them nguoi dung-----------------------------------------------
 ALTER PROC SP_ThemNguoiDung(@TaiKhoan NVARCHAR(50),@MatKhau NVARCHAR(50), @PhanQuyen NVARCHAR(50),@MaNV VARCHAR(10))
 AS
 BEGIN
 INSERT dbo.NguoiDung
 VALUES  (@TaiKhoan,@MatKhau,@PhanQuyen,@MaNV)
 END
 GO