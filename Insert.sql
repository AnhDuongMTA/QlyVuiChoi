USE QuanLyKhuVuiChoi
------INSERT-----
-- Khu vực
INSERT dbo.KhuVuc( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV001',N'Khu Thủy Cung',N'NV005',N'Ngắm cảnh đại dương',N'vị trí 1',150000,100000 )

INSERT dbo.KhuVuc( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV002',N'Khu Nghệ Thuật',N'NV002',N'Khám phá văn hóa, nghệ thuật',N'',200000 ,150000 )

INSERT dbo.KhuVuc( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV003',N'Khu Làng Nghề',N'NV018',N'Học hỏi làng các làng nghề VN',N'',80000 ,30000 )

INSERT dbo.KhuVuc( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV004',N'Khu Rạp Xiếc',N'NV019',N'',N'',170000,120000 )

INSERT dbo.KhuVuc ( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV005',N'Khu Trò Chơi',N'NV008',N'',N'',200000, 100000)
INSERT dbo.KhuVuc ( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV006',N'Khu Vườn Thú',N'NV010',N'',N'',150000, 50000)
INSERT dbo.KhuVuc ( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV007',N'Khu Vui Chơi Mạo Hiểm',N'NV006',N'',N'',200000, NULL)

INSERT dbo.KhuVuc ( Ma_Khu,Ten_Khu,Ma_TruongKhu,Chuc_Nang,Vi_Tri,Gia_NL,Gia_TE )
VALUES  (N'KV008',N'Khu Vui Chơi Dưới Nước',N'NV010',N'',N'',150000, 50000)

SELECT * FROM dbo.NhanVien

-- Nhân viên
INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV001' ,N'Nguyễn Tuấn Anh' ,'1980/11/20',N'Hà Nội' ,N'Nam' ,  6000000 ,N'KV001')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV002' ,N'Nguyễn Văn Tính' ,'1981/12/21',N'Hà Nam'  ,N'Nam' ,  7000000 ,N'KV004')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV003' ,N'Hồ Quang Hiếu' ,'1982/01/22',N'Thanh Hóa'  ,N'Nam' ,  5000000 ,N'KV002')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV004' ,N'Nguyễn Tự Long' ,'1983/02/23',N'Hải Phòng'  ,N'Nam' ,  7000000 ,N'KV001')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV005' ,N'Nguyễn Thị Hương' ,'1984/03/24',N'Hải Dương'  ,N'Nữ' ,  8000000 ,N'KV005')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV006' ,N'Vương Văn Thanh' ,'1985/04/25',N'Bắc Ninh'  ,N'Nam' ,  7000000 ,N'KV007')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV007' ,N'Nguyễn Thị Nhung' ,'1986/05/26',N'Bắc Giang'  ,N'Nữ' ,  6000000 ,N'KV001')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV008' ,N'Đỗ Thị Hằng' ,'1987/06/27',N'Lào Cai'  ,N'Nữ' ,  7000000 ,N'KV005')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV009' ,N'Ngô Thị Ánh' ,'1988/07/28',N'Vĩnh Phúc'  ,N'Nữ' ,  8000000 ,N'KV003')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV010' ,N'Cao Thái Sơn' ,'1989/08/29',N'Nghệ An'  ,N'Nam' ,  5000000 ,N'KV008')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV011' ,N'Cao Tùng Anh' ,'1990/09/30',N'Ninh Bình'  ,N'Nam' ,  6000000 ,N'KV002')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV012' ,N'Vương Thị Tâm' ,'1991/10/01',N'Hà Nội'  ,N'Nữ' ,  6000000 ,N'KV002')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV013' ,N'Lê Thị Trang' ,'1992/11/02',N'Thanh Hóa'  ,N'Nữ' ,  5000000 ,N'KV003')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV014' ,N'Nguyễn Tùng Lâm' ,'1993/03/03',N'Quảng Ninh'  ,N'Nam' ,  6500000 ,N'KV005')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV015' ,N'Nguyễn Thị Hà' ,'1994/04/04',N'Vĩnh Phúc'  ,N'Nữ' ,  5500000 ,N'KV004')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV016' ,N'Vương Văn Long' ,'1995/05/05',N'Bắc Ninh'  ,N'Nam' ,  6700000 ,N'KV001')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV017' ,N'Trần Văn Hiếu' ,'1996/06/06',N'Hài Phòng'  ,N'Nam' ,  7700000 ,N'KV002')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV018' ,N'TRịnh Định Quang' ,'1997/07/07',N'Hà Nội'  ,N'Nam' ,  6000000 ,N'KV003')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV019' ,N'Nguyễn Công Phượng' ,'1995/08/08',N'Nghệ An'  ,N'Nam' ,  7000000 ,N'KV004')

INSERT dbo.NhanVien( Ma_NV ,Ten_NV ,Ngay_Sinh,DiaChi ,Gioi_Tinh ,Luong , Ma_Khu    )
VALUES  ( N'NV020' ,N'Nguyễn Hữu Thắng' ,'1998/09/20',N'Hà Nội'  ,N'Nam' ,  8000000 ,N'KV002')
----- --------------------Trò chơi 

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC001', N'Tàu lượn siêu tốc', N'KV007' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC002', N'Leo núi ', N'KV007' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC003', N'Trượt patin', N'KV005' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC004', N'Du quay', N'KV005' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC005', N'Lái ô tô', N'KV005' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC006', N'Đạp vịt', N'KV008' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC007', N'Chèo thuyền', N'KV008' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC008', N'Bơi', N'KV008' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC009', N'Bóng nước', N'KV008' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC010', N'Trượt ống nước', N'KV008' )

INSERT dbo.TroChoi( Ma_TroChoi, Ten_TroChoi, Ma_Khu )
VALUES  (N'TC011', N'Máng trượt', N'KV008' )
         

----------------------KHACH HANG

INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH001', N'Lê Như Quỳnh',1980,0975141782,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH003', N'Phạm Thanh Vân',1982,0983355888,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH004', N'Phan Anh Tuấn',1983,0983730318,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH005', N'Dương Huyền Trang',1984,0914761817,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH006', N'Nguyễn Tài Đức',1985,0976736328,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH007', N'Nguyễn Thị Bích Ngọc',1986,0984298866,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH008', N'Nguyễn Hằng Nga',1987,0912446579,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH009', N'Cao Xuân Kiên',1988,0964118885,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH010', N'Trần Đức Việt',1989,0985021978,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH011', N'Nguyễn Bảo Ngọc	',1990,0979490666,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH012', N'Phạm Quang Thắng',1991,0906040677,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH013', N'Nguyễn Ngọc Mai',1992,0983907167,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH014', N'Nguyễn Việt Anh',1993,0985299118,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH015', N'Uông Thanh Hằng',1994,0982527982,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH016', N'Lê Trường Giang',1996,0973776072,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH017', N'Phạm Mai Trang',1996,0917749254,N'Nữ')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH018', N'Nguyễn Anh Huy',1997,0904770053,N'Nam')
INSERT dbo.KhachHang(Ma_KH, Ten_KH,Nam_Sinh, SDT, Gioi_Tinh)
VALUES	(N'KH019', N'Nguyễn Thị Thu Hương',1998,0974880788,N'Nữ')



-------------------------------DICH VU--------------------
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV001', N'Y tế',5000,N'KV006')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV002', N'Quay phim',10000,N'KV003')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV003', N'Nghỉ ngơi',2000,N'KV002')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV004', N'Ăn Uống',20000,N'KV003')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV005', N'Chụp Ảnh',15000,N'KV004')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV006', N'Mua sắm',30000,N'KV003')
INSERT dbo.DichVu
		(Ma_DV, Ten_DV, Gia_DV, Ma_Khu)
VALUES	(N'DV007', N'Xe bus nhanh',30000,N'KV006')

--Thiết Bị--

INSERT ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB001',N'Đèn Chiếu Sáng', '2017/05/12', 'TC004')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB002',N'Loa Đài', '2017/05/12', 'TC003')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB003',N'Dây Cáp', '2017/12/13', 'TC002')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB004',N'Thuyền', '2017/01/12', 'TC007')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB005',N'Thiết bị Bảo hiểm', '2017/08/24', 'TC003')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB006',N'Ô tô', '2017/07/24', 'TC005')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB007',N'Mái chèo', '2017/01/12', 'TC007')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB008',N'Tàu lượn', '2017/05/12', 'TC001')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB009',N'Đu quay', '2017/12/30', 'TC004')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB010',N'Giày Patin', '2017/06/24', 'TC003')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB011',N'Mũ bảo hiểm', '2017/12/13', 'TC002')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB012',N'Đồ bơi', '2017/03/11', 'TC008')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB013',N'Bóng', '2017/03/11', 'TC009')
insert ThietBi (Ma_TB,Ten_TB,Ngay_BD,Ma_TroChoi)
	values (N'TB014',N'Áo phao', '2017/05/12', 'TC006')

--Phiếu Mua--

insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM001', '2017/12/24', 'KH001')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM002', '2017/12/24', 'KH005')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM003', '2017/12/24', 'KH003')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM004', '2018/01/01', 'KH002')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM005', '2018/01/01', 'KH004')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM006', '2018/01/01', 'KH005')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM007', '2018/01/08', 'KH018')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM008', '2018/01/07', 'KH012')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM009', '2018/01/07', 'KH019')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM010', '2018/01/10', 'KH009')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM011', '2018/01/02', 'KH008')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM012', '2018/01/02', 'KH009')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM013', '2018/01/10', 'KH011')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM014', '2018/01/10',  'KH012')
insert PhieuMua(Ma_Phieu,Ngay_Mua,Ma_KH)
	values (N'PM015', '2017/12/30', 'KH008')