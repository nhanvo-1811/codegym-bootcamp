
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
	DECLARE @Result INT = 0
	BEGIN TRAN
	BEGIN TRY

	IF(EXISTS(SELECT * FROM dbo.MATHANG WHERE MaMH=@MaMH AND TenMH = @TenMH))
	BEGIN
		SET @Result =2
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
		VALUES  ( @TenMH , -- TenMH - nvarchar(250)
		          @LH , -- LoaiHang - nvarchar(50)
		          @QC, -- QuyCach - nvarchar(50)
		          @GB, -- GiaBan - decimal
		          @SLHC  -- SoLuongHienCo - int
		        )
		        --( [MALOAIHANG], [TENLOAIHANG] )

		SET @Result =1
	END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
	SELECT @Result AS Result
END
EXEC SP_MatHang 55, N'BLUETOOTH REMAX RB-T8 BLACK', N'Tai Nghe','','350000','10'

SELECT * FROM dbo.MATHANG

--SP_KhachHang
ALTER PROC SP_KhachHang
(
	@MaKH int,
	@TenKH nvarchar(70),
	@DC nvarchar(250),
	@DT nchar(11),
	@Email nvarchar(50)
)
AS
BEGIN
DECLARE @Result INT = 0
	BEGIN TRAN
	BEGIN TRY
	IF(EXISTS(SELECT * FROM dbo.KHACHHANG WHERE MaKH=@MaKH AND HoTen = @TenKH))
	BEGIN
		SET @Result =2
		UPDATE dbo.KHACHHANG
		SET HoTen =@TenKH,
			DiaChi = @DC,
			DienThoai = @DT,
			Email = @Email
		WHERE  MaKH=@MaKH AND HoTen = @TenKH
    END
    ELSE 
	BEGIN
		SET @Result = 1
		INSERT INTO dbo.KHACHHANG
		        (	HoTen, 
					DiaChi, 
					DienThoai, 
					Email )
		VALUES  ( @TenKH, -- HoTen - nvarchar(70)
		          @DC, -- DiaChi - nvarchar(250)
		          @DT, -- DienThoai - nchar(11)
		          @Email  -- Email - nvarchar(50)
		          )
		SET @Result =1
	END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
	SELECT @Result AS Result
END 



--SP_ChungTu
ALTER PROC sp_TaoChungTu
(
	@SoCT INT,
	@HoTenKH nvarchar(70),
	@DiaChiKH nvarchar(250),
	@MaKH int	
)
AS
BEGIN
	DECLARE @Result INT = 0
	BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS(SELECT * FROM dbo.ChungTu WHERE SoCT = @SoCT))
		BEGIN
			SET @Result = 1
		END
		ELSE
		BEGIN
			--Them phieu thu
			INSERT INTO [dbo].ChungTu
				   (
					NgayLapCT,
					HoTenKH,
					DiaChiKH,
					MaKH)
			 VALUES
				   (
					GETDATE(),
					@HoTenKH,
					@DiaChiKH,
					@MaKH)
		
			SET @Result =2
		END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
	SELECT @Result AS Result
END

sp_TaoChungTu 6,N'Nhân',N'Phú Thượng',1

SELECT * FROM dbo.ChungTu

--SP_PhieuThu
ALTER PROC dbo.sp_TaoPhieuThu
(
	@SoCT INT,
	@SoTienThuCuaKH DECIMAL(18,0)
)
AS
BEGIN
	DECLARE @Result INT = 0
	BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS(SELECT * FROM dbo.ChungTu WHERE SoCT = @SoCT))
		BEGIN
			SET @Result = 1
		END
		ELSE
		BEGIN
			--Them phieu thu
			INSERT INTO [dbo].[PhieuThu]
				   ([SoCT]
				   ,[NgayThuTien]
				   ,[SoTienThuCuaKH])
			 VALUES
				   (@SoCT
				   ,GETDATE()
				   ,@SoTienThuCuaKH)
			--Cap chung tu
			UPDATE dbo.ChungTu
			SET TraTruoc = ISNULL(TraTruoc,0) + @SoTienThuCuaKH,
			ConNo = ISNULL(SoTien,0) - (ISNULL(TraTruoc,0)+@SoTienThuCuaKH)
			WHERE SoCT = @SoCT
			SET @Result =2
		END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
	SELECT @Result AS Result
END

sp_TaoPhieuThu 9,200000

SELECT * FROM dbo.PhieuThu

SELECT * FROM dbo.ChungTu

--SP_ChiTietChungTu
alter PROC dbo.sp_taochitietchungtu
(
	@SoCT int,
	@MAMH INT,
	@Soluong int
)
AS
BEGIN
	DECLARE @Result INT = 0
	BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS(SELECT * FROM dbo.ChungTu WHERE SoCT = @SoCT) OR NOT EXISTS(SELECT * FROM dbo.MATHANG WHERE MaMH= @MAMH))
		BEGIN
			SET @Result = 1
		END
		ELSE
		BEGIN
			DECLARE @sotien INT = @soluong * (SELECT GiaBan FROM dbo.MATHANG WHERE MaMH = @MaMH)
			--Them chitietchungtu
			INSERT INTO dbo.ChiTietChungTu
			        ( SoCT, MaMH, SoLuong, SoTien )
		
			     
			 VALUES
				   (@SoCT,
					@MaMH,
					@Soluong,
					@sotien
					)
			--Cap chung tu
			UPDATE dbo.ChungTu
			SET SoTien = ISNULL(SoTien,0) + @sotien,
			ConNo = (ISNULL(SoTien,0) + @sotien) - ISNULL(TraTruoc,0)
			WHERE SoCT = @SoCT
			SET @Result =2
		END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
	SELECT @Result AS Result
END

EXEC sp_taochitietchungtu 6,3,3

SELECT * FROM dbo.ChungTu

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