alter VIEW view_ds
as
SELECT HO, NGAYSINH FROM dbo.NHANVIEN
go

SELECT * FROM view_ds
go