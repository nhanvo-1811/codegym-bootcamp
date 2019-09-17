
--Câu 2 : Sp_MatHang
ALTER PROC SP_MatHang
(
	@MaMH int,
	@TenMH nvarchar(250),
	@LH nvarchar(50),
	@QC nvarchar(50),
	@GB decimal(18, 0),
	@SLHC int
)
AS
BEGIN
	IF(EXISTS(SELECT * FROM dbo.MATHANG WHERE MaMH=@MaMH AND TenMH = @TenMH))
	BEGIN
		UPDATE dbo.MATHANG
		SET LoaiHang =@LH,
			QuyCach = @QC,
			GiaBan = @GB,
			SoLuongHienCo = @SLHC
		WHERE MaMH = @MaMH AND TenMH = @TenMH
    END
    ELSE 
	BEGIN
		INSERT INTO dbo.MATHANG
		        ( TenMH ,
		          LoaiHang ,
		          QuyCach ,
		          GiaBan ,
		          SoLuongHienCo
		        )
		VALUES  ( N''+@TenMH+'' , -- TenMH - nvarchar(250)
		          N''+@LH+'' , -- LoaiHang - nvarchar(50)
		          N''+@QC+'' , -- QuyCach - nvarchar(50)
		          @GB, -- GiaBan - decimal
		          @SLHC  -- SoLuongHienCo - int
		        )
		        --( [MALOAIHANG], [TENLOAIHANG] )
	END

END
EXEC SP_MatHang '3','BLUETOOTH REMAX RB-T8 BLACK', 'Tai Nghe','','250000','10'

--SP_KhachHang
CREATE PROC SP_KhachHang
(
	@MaKH int,
	@TenKH nvarchar(70),
	@DC nvarchar(250),
	@DT nchar(11),
	@Email nvarchar(50)
)
AS
BEGIN
	IF(EXISTS(SELECT * FROM dbo.KHACHHANG WHERE MaKH=@MaKH AND HoTen = @TenKH))
	BEGIN
		UPDATE dbo.KHACHHANG
		SET HoTen =@TenKH,
			DiaChi = @DC,
			DienThoai = @DT,
			Email = @Email
		WHERE  MaKH=@MaKH AND HoTen = @TenKH
    END
    ELSE 
	BEGIN
		INSERT INTO dbo.KHACHHANG
		        (	HoTen, 
					DiaChi, 
					DienThoai, 
					Email )
		VALUES  ( N''+@TenKH+'', -- HoTen - nvarchar(70)
		          N''+@DC+'', -- DiaChi - nvarchar(250)
		          N''+@DT+'', -- DienThoai - nchar(11)
		          N''+@Email+''  -- Email - nvarchar(50)
		          )
	END

END

--SP_ChungTu

--SP_PhieuThu

--SP_ChiTietChungTu

--Cau 3:
CREATE VIEW view_AllChungTu 
AS
SELECT	ChungTu.SoCT,
		NgayLapCT,

		KhachHang.HoTen ,
		KhachHang.DiaChi ,
		KhachHang.DienThoai ,
		KhachHang.Email,

		MatHang.TenMH ,
		MatHang.LoaiHang ,
		MatHang.QuyCach ,
		MatHang.GiaBan ,
		ChiTietChungTu.SoLuong ,
		ChiTietChungTu.Dongia,

		ChungTu.SoTien,
		ChungTu.TraTruoc ,
		ChungTu.ConNo
FROM dbo.ChungTu
JOIN dbo.KhachHang ON KhachHang.MaKH = ChungTu.MaKH
JOIN dbo.ChiTietChungTu ON ChiTietChungTu.SoCT = ChungTu.SoCT
JOIN dbo.MatHang ON MatHang.MaMH = dbo.ChiTietChungTu.MaMH

SELECT * FROM view_AllChungTu


--Cau 4: 

CREATE PROC SP_viewMatHang
AS
BEGIN
SELECT * FROM dbo.MATHANG
END

EXEC SP_viewMatHang

--Cau 5:

ALTER PROC SP_ChungTu
(
	@MaCT int
)
AS
BEGIN
	SELECT * FROM dbo.ChungTu 
	JOIN dbo.ChiTietChungTu ON ChiTietChungTu.SoCT = ChungTu.SoCT
	WHERE dbo.ChungTu.SoCT = @MaCT 
END

EXEC SP_ChungTu 6