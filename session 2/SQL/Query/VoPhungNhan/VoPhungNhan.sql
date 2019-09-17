USE [QL_BanHang]
GO
/****** Object:  Table [dbo].[ChiTietChungTu]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChungTu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoCT] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Dongia] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ChiTietChungTu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChungTu]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChungTu](
	[SoCT] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapCT] [datetime] NOT NULL,
	[HoTenKH] [nvarchar](70) NOT NULL,
	[DiaChiKH] [nvarchar](250) NOT NULL,
	[MaKH] [int] NOT NULL,
	[SoTien] [decimal](18, 0) NULL,
	[TraTruoc] [decimal](18, 0) NULL,
	[ConNo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ChungTu] PRIMARY KEY CLUSTERED 
(
	[SoCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](70) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [nchar](11) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MATHANG]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATHANG](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](250) NOT NULL,
	[LoaiHang] [nvarchar](50) NOT NULL,
	[QuyCach] [nvarchar](50) NULL,
	[GiaBan] [decimal](18, 0) NOT NULL,
	[SoLuongHienCo] [int] NOT NULL,
 CONSTRAINT [PK_MATHANG] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[SoPT] [int] IDENTITY(1,1) NOT NULL,
	[SoCT] [int] NOT NULL,
	[NgayThuTien] [datetime] NOT NULL,
	[SoTienThuCuaKH] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[SoPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_AllChungTu]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_AllChungTu] 
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


GO
SET IDENTITY_INSERT [dbo].[ChiTietChungTu] ON 

INSERT [dbo].[ChiTietChungTu] ([ID], [SoCT], [MaMH], [SoLuong], [Dongia]) VALUES (1, 5, 5, 1, CAST(1750000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietChungTu] ([ID], [SoCT], [MaMH], [SoLuong], [Dongia]) VALUES (2, 6, 8, 1, CAST(3699000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ChiTietChungTu] OFF
SET IDENTITY_INSERT [dbo].[ChungTu] ON 

INSERT [dbo].[ChungTu] ([SoCT], [NgayLapCT], [HoTenKH], [DiaChiKH], [MaKH], [SoTien], [TraTruoc], [ConNo]) VALUES (5, CAST(N'2019-09-16 00:00:00.000' AS DateTime), N'Võ Phụng Nhân', N'Phú Thượng - Phú Vang - TT-Huế', 1, NULL, NULL, NULL)
INSERT [dbo].[ChungTu] ([SoCT], [NgayLapCT], [HoTenKH], [DiaChiKH], [MaKH], [SoTien], [TraTruoc], [ConNo]) VALUES (6, CAST(N'2019-09-16 00:00:00.000' AS DateTime), N'Phước Thành', N'Đào Tấn - TT-Huế', 2, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ChungTu] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [DienThoai], [Email]) VALUES (1, N'Võ Phụng Nhân', N'Phú Thượng - Phú Vang - TT-Huế', N'0935488044 ', N'shadowin1811@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [DienThoai], [Email]) VALUES (2, N'Phước Thành ', N'Đào Tấn - TT-Huế', N'02453215789', N'NPT1978@gmail.com')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [DienThoai], [Email]) VALUES (3, N'Hổ Báo', N'Quảng Nam', N'23546879541', N'HoBao879@gmail.com')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[MATHANG] ON 

INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (2, N'DAREU EH925 RGB', N'Tai Nghe', N'', CAST(990000 AS Decimal(18, 0)), 100)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (3, N'BLUETOOTH REMAX RB-T8 BLACK', N'Tai Nghe', N'', CAST(250000 AS Decimal(18, 0)), 10)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (5, N' KEYBOARD GAMESIR Z1 ', N'Bàn Phím Cơ', NULL, CAST(1750000 AS Decimal(18, 0)), 50)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (7, N'NEWMEN E335 - CỔNG PS/2 MÀU ĐEN', N'Bàn Phím Gaming', NULL, CAST(130000 AS Decimal(18, 0)), 100)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (8, N'LOGITECH G900 CHAOS SPECTRUM', N'Chuột Gaming', NULL, CAST(3699000 AS Decimal(18, 0)), 5)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (9, N'XC X5 BO VIỀN KHÍT (300X250X2.5MM)', N'Tấm lót chuột', NULL, CAST(25000 AS Decimal(18, 0)), 300)
INSERT [dbo].[MATHANG] ([MaMH], [TenMH], [LoaiHang], [QuyCach], [GiaBan], [SoLuongHienCo]) VALUES (13, N'BLUETOOTH REMAX RB-T8 BLACK', N'Tai Nghe', N'', CAST(250000 AS Decimal(18, 0)), 10)
SET IDENTITY_INSERT [dbo].[MATHANG] OFF
SET IDENTITY_INSERT [dbo].[PhieuThu] ON 

INSERT [dbo].[PhieuThu] ([SoPT], [SoCT], [NgayThuTien], [SoTienThuCuaKH]) VALUES (1, 5, CAST(N'2019-09-16 00:00:00.000' AS DateTime), CAST(20000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PhieuThu] OFF
ALTER TABLE [dbo].[ChiTietChungTu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietChungTu_ChungTu] FOREIGN KEY([SoCT])
REFERENCES [dbo].[ChungTu] ([SoCT])
GO
ALTER TABLE [dbo].[ChiTietChungTu] CHECK CONSTRAINT [FK_ChiTietChungTu_ChungTu]
GO
ALTER TABLE [dbo].[ChiTietChungTu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietChungTu_MATHANG] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MATHANG] ([MaMH])
GO
ALTER TABLE [dbo].[ChiTietChungTu] CHECK CONSTRAINT [FK_ChiTietChungTu_MATHANG]
GO
ALTER TABLE [dbo].[ChungTu]  WITH CHECK ADD  CONSTRAINT [FK_ChungTu_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[ChungTu] CHECK CONSTRAINT [FK_ChungTu_KHACHHANG]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_ChungTu] FOREIGN KEY([SoCT])
REFERENCES [dbo].[ChungTu] ([SoCT])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_ChungTu]
GO
/****** Object:  StoredProcedure [dbo].[SP_ChungTu]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ChungTu]
(
	@MaCT int
)
AS
BEGIN
	SELECT * FROM dbo.ChungTu 
	JOIN dbo.ChiTietChungTu ON ChiTietChungTu.SoCT = ChungTu.SoCT
	WHERE dbo.ChungTu.SoCT = @MaCT 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KhachHang]
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

GO
/****** Object:  StoredProcedure [dbo].[SP_MatHang]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MatHang]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_viewMatHang]    Script Date: 9/16/2019 4:02:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_viewMatHang]
AS
BEGIN
SELECT * FROM dbo.MATHANG
END
GO
