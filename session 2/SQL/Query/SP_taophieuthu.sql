USE [QL_BanHang]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoPhieuThu]    Script Date: 9/18/2019 2:45:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_TaoPhieuThu]
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
			--UPDATE dbo.ChungTu
			--SET TraTruoc = ISNULL(TraTruoc,0) + @SoTienThuCuaKH
			--WHERE SoCT = @SoCT

			EXEC sp_CapNhatChungTu @SoCT, @SoTienThuCuaKH
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