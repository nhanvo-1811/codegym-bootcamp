-- tạo database test
CREATE DATABASE Test

-- drop database Test
DROP DATABASE Test;

-- sử dụng database ngay trong code.
USE Test;

--- Tạo bảng GV
CREATE TABLE gv
(
	Magv char(5),
	Tengv nvarchar(50),
)

--- Tạo bảng HS
create table HocSinh
(
	MaHS char(5),
	TenHS nvarchar(50),
)
use Test
-- rename tabale


EXEC sp_rename 'HocSinh', 'HS';

select * from hs
--
EXEC sp_rename 'hs.MAHS2', 'MAHS22.3';

ALTER TABLE hs
DROP COLUMN [MAHS22.3];


SELECT * FROM ;
-- thêm cột ngày sinh cho bảng gv
ALTER TABLE GV  ADD ngaysinh DATETIME;

-- thêm cột ngày sinh cho bảng gv
ALTER TABLE HS  ADD ngaysinh DATETIME;
ALTER TABLE HS  ADD ngaysinh DATETIME;




--insert dữ liệu

--- 
drop database [Test];


drop database [T];
go
--Desc gv;
use master;