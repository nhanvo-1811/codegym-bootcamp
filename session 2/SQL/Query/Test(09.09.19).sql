-- tạo database test
--create database Test

-- sử dụng database ngay trong code.
use Test;
--- Tạo bảng GV
create table gv
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
-- rename tabale
EXEC sp_rename 'Hocsinh', 'Hocsinh2';
-- thêm cột ngày sinh cho bảng gv
alter table GV add ngaysinh Datetime;




--insert dữ liệu
insert 
--- 
--drop database Test;
--Desc gv;
