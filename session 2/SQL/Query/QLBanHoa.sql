USE QLBanHoa

--Tạo bảng thông tin hoa
CREATE TABLE TTHoa
(
	ID INT IDENTITY,
	-- primare key Mã hoa
	MaHoa NCHAR(10) UNIQUE NOT NULL,
	TenHoa NVARCHAR(50),
	GioiThieu NVARCHAR(300),
	DongGia INT
);

-- Thêm primary key cho MaHoa trong bảng TThoa
ALTER TABLE TTHOA ADD primary key(MaHoa);

-- Tạo bảng nhập hoa
CREATE TABLE NhapHoa
(
	ID INT IDENTITY, 
	-- primare key mã nhập hoa
	MaNhap NCHAR(10)  UNIQUE NOT NULL,
	NgayNhap DATE,
	SL INT,
	NhapTu NVARCHAR(50),
	MaHoa NCHAR(10)
)
-- Thêm primary key cho MaNhap trong bảng NhapHoa
ALTER TABLE NhapHoa ADD primary key(MaNhap);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang
(
	ID INT IDENTITY,
	-- primare key mã khách hàng
	MaKH NCHAR(10)  UNIQUE NOT NULL,
	TenKH NVARCHAR(100),
	Tuoi INT,
	Gender BIT,
	DiaChi NVARCHAR(300),
	NhapTu NVARCHAR(50),
	SDT NCHAR(15)
)

-- Thêm primary key cho MaKH trong bảng KhachHang
ALTER TABLE KhachHang ADD primary key(MaKH);

-- Tạo bảng Khách hàng
CREATE TABLE HoaDon
(
	ID INT IDENTITY,
	-- primare key Mã hóa đơn
	MaHD NCHAR(10)  UNIQUE NOT NULL,
	MaKH NCHAR(10),
	NgayLap Date,
	TongTien INT
)

-- Thêm primary key cho MaHD trong bảng HoaDon
ALTER TABLE HoaDon ADD primary key(MaHD);


CREATE TABLE ChiTietHoaDon
(
	--primary key ID
	ID INT IDENTITY UNIQUE NOT NULL,
	MaHD NCHAR(10) UNIQUE NOT NULL,
	MaHoa NCHAR(10) UNIQUE NOT NULL,
	SoLuong INT
)
-- Thêm primary key cho ID trong bảng ChiTietHoaDon
ALTER TABLE ChiTietHoaDon ADD primary key(ID);

-- Tạo bảng cùng khóa chính
CREATE TABLE VanChuyen
(
	ID int PRIMARY KEY
)
