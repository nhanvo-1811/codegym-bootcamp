
--Cau1: Bổ sung ràng buộc thiết lập giá trị mặc định bằng 1 cho cột SOLUONG và bằng 0 cho
--		cột MUCGIAMGIA trong bảng CHITIETDATHANG

ALTER TABLE ChiTietDonHang
ADD DEFAULT (1) FOR SoLuong ;

ALTER TABLE ChiTietDonHang
ADD DEFAULT (0) FOR MucGiamGia ;

--Cau2: Bổ sung cho bảng DONDATHANG ràng buộc kiểm tra ngày giao hàng và ngày chuyển
--		hàng phải sau hoặc bằng với ngày đặt hàng.
ALTER TABLE DonDatHang
ADD CHECK (NgayGiaoHang>=NgayDatHang and NgayChuyenHang>=NgayDatHang);
-- (DAY(NgayGiaoHang)>=DAY(NgayDatHang) and DAY(NgayChuyenHang)>=DAY(NgayDatHang));

--Cau 3: Bổ sung ràng buộc cho bảng NHANVIEN để đảm bảo rằng một nhân viên chỉ có thể
--làm việc trong công ty khi đủ 18 tuổi và không quá 60 tuổi.
ALTER TABLE dbo.NHANVIEN
ADD CHECK (datediff(yyyy,NGAYSINH,NGAYLAMVIEC)
BETWEEN 18 AND 60)

--Cau 4: Cho biết danh sách các đối tác cung cấp hàng cho công ty.
SELECT * 
FROM dbo.NHACUNGCAP

--Cau 5: Mã hàng, tên hàng và số lượng của các mặt hàng hiện có trong công
SELECT MAHANG, TENHANG, SOLUONG 
FROM dbo.MATHANG

--Cau 6: Họ tên và địa chỉ và năm bắt đầu làm việc của các nhân viên trong công ty
SELECT HO,TEN, DIACHI, NGAYLAMVIEC 
FROM dbo.NHANVIEN

--Cau 7: Địa chỉ và điện thoại của nhà cung cấp có tên giao dịch VINAMI	
SELECT DIACHI, DIENTHOAI 
FROM dbo.NHACUNGCAP
WHERE TENGIAODICH = 'VINAMILK'

--kt tồn tại
IF (EXISTS(SELECT DIACHI, DIENTHOAI 
FROM dbo.NHACUNGCAP
WHERE TENGIAODICH = 'VINAMILK'))
    BEGIN
        SELECT DIACHI, DIENTHOAI 
		FROM dbo.NHACUNGCAP
		WHERE TENGIAODICH = 'VINAMILK'
    END
    ELSE
    BEGIN
        PRINT ' not ';
    END
--Cau 8: Cho biết mã và tên của các mặt hàng có giá lớn hơn 100000 và số lượng hiệ
--ít hơn 50.
SELECT MAHANG, TENHANG
FROM dbo.MATHANG
WHERE GIAHANG > 100000 AND SOLUONG <50

--Câu 9: Cho biết mỗi mặt hàng trong công ty do ai cung cấp
SELECT MAHANG, TENHANG, TENCONGTI, TENGIAODICH
FROM dbo.MATHANG
INNER JOIN dbo.NHACUNGCAP ON MATHANG.MACONGTI = NHACUNGCAP.MACONGTI

--Câu 10: Công ty Ban hoa2 cung cấp mặt hàng nào
SELECT MAHANG, TENHANG, TENCONGTI, TENGIAODICH
FROM dbo.MATHANG
INNER JOIN dbo.NHACUNGCAP ON MATHANG.MACONGTI = NHACUNGCAP.MACONGTI
WHERE TENCONGTI = 'Ban Hoa2'

--Câu 11: Loại hàng thực phẩm do những công ty nào cung cấp và địa chỉ 
--của công ty đó là gì?
SELECT MAHANG, TENHANG, TENCONGTI, DIACHI, TENLOAIHANG
FROM dbo.MATHANG
INNER JOIN dbo.NHACUNGCAP ON MATHANG.MACONGTI = NHACUNGCAP.MACONGTI
INNER JOIN dbo.LOAIHANG ON LOAIHANG.MALOAIHANG = MATHANG.MALOAIHANG
--Câu 12: Những khách hàng nào (tên giao dịch) đã đặt mua mặt hàng Sữa hộp XYZ của công ty?
SELECT DISTINCT kh.MAKHACHHANG, kh.TENGIAODICH, mh.TENHANG
FROM dbo.CHITIETDONHANG ctdh
INNER JOIN dbo.DONDATHANG ddh ON ctdh.SOHOADON = ddh.SOHOADON
INNER JOIN dbo.MATHANG mh ON mh.MAHANG = ctdh.MAHANG
INNER JOIN dbo.KHACHHANG kh ON kh.MAKHACHHANG = ddh.MAKHACHHANG
WHERE TENHANG = 'HOA' 


SELECT DISTINCT kh.MAKHACHHANG, kh.TENGIAODICH
FROM dbo.KHACHHANG kh JOIN  (
SELECT ctdh.MAHANG, mh.TENHANG, ddh.MAKHACHHANG FROM dbo.CHITIETDONHANG ctdh
INNER JOIN dbo.DONDATHANG ddh ON ctdh.SOHOADON = ddh.SOHOADON
INNER JOIN dbo.MATHANG mh ON mh.MAHANG = ctdh.MAHANG
--INNER JOIN dbo.KHACHHANG kh ON kh.MAKHACHHANG = ddh.MAKHACHHANG
WHERE TENHANG = 'HOA' ) AS cthd1

ON cthd1.MAKHACHHANG = kh.MAKHACHHANG




-- cau 17
SELECT v1.MANHANVIEN,v1.HO, v1.TEN, v1.NGAYSINH
FROM dbo.NHANVIEN v1, dbo.NHANVIEN v2
WHERE DAY(v1.NGAYSINH) = DAY(v2.NGAYSINH) AND v1.MANHANVIEN <> v2.MANHANVIEN 




--RETURNS @NV TABLE (ngaysinh DATE)
--AS

--BEGIN 
--	INSERT INTO @NV
	
--	RETURN
--END
