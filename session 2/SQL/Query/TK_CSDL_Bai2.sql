use TK_CSDL_Bai2;

--Tao bang khach hang
CREATE TABLE KhachHang
(
	MaKhachHang Nvarchar(50) primary key,
	TenCongTy Nvarchar(255),
	TenGiaoDich Nvarchar(255),
	DiaChi Nvarchar(255),
	Email Nvarchar(255),
	SDT Nvarchar(50),
	Fax Nvarchar(25)
)

EXEC sp_rename 'khachhang.SDT', 'DienThoai','column',

--Tao bang nhan vien
Create Table NhanVien
(
	MaNhanVien Nvarchar(50) primary key,
	Ho nvarchar(20),
	Ten nvarchar(10) NULL,
	NgaySinh date NULL,
	NgayLamViec datetime NULL,
	DiaChi Nvarchar(255),
	DienThoai Nvarchar(255),
	LuongCoBan float,
	PhuCap float,
	
)

alter table NhanVien
alter column Dienthoai nvarchar(50)																		

--Tao bang Nha cung cap
Create Table NhaCungCap
(
	MaCongTy Nvarchar(50) primary key,
	Ten Nvarchar(10),
	NgaySinh Date,
	NgayLamViec DateTime,
	DiaChi Nvarchar(255),
	DienThoai Nvarchar(50),
	Fax Nvarchar(50),
	Email Nvarchar(255),
)

alter table NhaCungCap
drop column NgayLamViec

--Tao bang loai hang
Create table LoaiHang
(
	MaloaiHang Nvarchar(50) primary key,
	TenLoaiHang Nvarchar(255)
)

EXEC sp_rename 'LoaiHang.MaloaiHang', 'MaLoaiHang','column'
--Tao bang Mat Hang
Create Table MatHang
(
	MaHang Nvarchar(50) primary key,
	TenHang Nvarchar(10),
	MaCongTy Nvarchar(50) foreign key REFERENCES NhaCungcap(MaCongTy),
	MaLoaiHang Nvarchar(50) foreign key REFERENCES LoaiHang(MaLoaiHang),
	Soluong int,
	DonViting nvarchar(7),
	GiaHang Float
)

--Tao bang don dat hang
Create Table DonDatHang
(
	SoHoaDon Nvarchar(50) primary key,
	MaKhachHang Nvarchar(50) foreign key REFERENCES KhachHang(MaKhachHang),
	MaNhanVien Nvarchar(50) foreign key REFERENCES NhanVien(MaNhanVien),
	NgayDatHang Date,
	NgayGiaoHang Date,
	NgayChuyenHang Date,
	NoiGiaoHang Nvarchar(255)
)

--Tao bang chi tiet dat hang
Create Table ChiTietDatHang
(
	SoHoaDon Nvarchar(50) foreign key REFERENCES  DonDatHang(SoHoaDon),	
	MaHang Nvarchar(50)  foreign key REFERENCES MatHang(MaHang),
	GiaBan float,
	SoLuong int,
	MucGiamGia nvarchar(5),

	primary key (SoHoaDon,MaHang) 
)

--Cau1: Bổ sung ràng buộc thiết lập giá trị mặc định bằng 1 cho cột SOLUONG và bằng 0 cho
--		cột MUCGIAMGIA trong bảng CHITIETDATHANG
ALTER TABLE ChiTietDatHang
ADD DEFAULT ('1') FOR SoLuong ;

ALTER TABLE ChiTietDatHang
ADD DEFAULT ('0') FOR MucGiamGia ;

--Cau2: Bổ sung cho bảng DONDATHANG ràng buộc kiểm tra ngày giao hàng và ngày chuyển
--		hàng phải sau hoặc bằng với ngày đặt hàng.
ALTER TABLE DonDatHang
ADD check (NgayGiaoHang>=NgayDatHang and NgayChuyenHang>=NgayDatHang);

--
ALTER TABLE NhanVien
ADD check ();




