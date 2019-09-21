CREATE PROC sp_CapNhatChungTu
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
			--Cap chung tu
			UPDATE dbo.ChungTu
			SET TraTruoc = ISNULL(TraTruoc,0) + @SoTienThuCuaKH
			WHERE SoCT = @SoCT
			SET @Result =2
		END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
        ROLLBACK
	END CATCH
END