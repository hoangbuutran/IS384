USE [SHOPBONGDA]
GO
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADON](
	[IDCTHOADON] [int] IDENTITY(1,1) NOT NULL,
	[SOLUONG] [int] NULL,
	[GIA] [float] NULL,
	[IDHOADON] [int] NULL,
	[IDSANPHAM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCTHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHOADON] [int] IDENTITY(1,1) NOT NULL,
	[NGAYLAPHOADON] [datetime] NULL,
	[TRANGTHAI] [bit] NULL,
	[IDNGUOIDUNG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAINGUOIDUNG]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINGUOIDUNG](
	[IDLOAINGUOIDUNG] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAINGUOIDUNG] [nvarchar](50) NULL,
	[TRANGTHAI] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLOAINGUOIDUNG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[IDLOAISANPHAM] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAISANPHAM] [nvarchar](150) NULL,
	[TRANGTHAI] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLOAISANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[IDNGUOIDUNG] [int] IDENTITY(1,1) NOT NULL,
	[TENNGUOIDUNG] [nvarchar](100) NULL,
	[MATKHAU] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
	[EMAIL] [nvarchar](150) NULL,
	[TRANGTHAI] [bit] NULL,
	[IDLOAINGUOIDUNG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNGUOIDUNG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 2/5/2018 11:44:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[IDSANPHAM] [int] IDENTITY(1,1) NOT NULL,
	[TENSANPHAM] [nvarchar](150) NULL,
	[GIA] [int] NULL,
	[HINHANH] [nvarchar](100) NULL,
	[NGAY] [datetime] NULL,
	[MAUSAC] [nvarchar](50) NULL,
	[XUATXU] [nvarchar](150) NULL,
	[MIEUTA] [ntext] NULL,
	[TRANGTHAI] [bit] NULL,
	[IDLOAISANPHAM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CTHOADON] ON 

INSERT [dbo].[CTHOADON] ([IDCTHOADON], [SOLUONG], [GIA], [IDHOADON], [IDSANPHAM]) VALUES (1, 2, 200, 1, 1)
INSERT [dbo].[CTHOADON] ([IDCTHOADON], [SOLUONG], [GIA], [IDHOADON], [IDSANPHAM]) VALUES (2, 3, 300, 2, 1)
SET IDENTITY_INSERT [dbo].[CTHOADON] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([IDHOADON], [NGAYLAPHOADON], [TRANGTHAI], [IDNGUOIDUNG]) VALUES (1, CAST(N'2018-02-05 23:39:39.500' AS DateTime), 1, 1)
INSERT [dbo].[HOADON] ([IDHOADON], [NGAYLAPHOADON], [TRANGTHAI], [IDNGUOIDUNG]) VALUES (2, CAST(N'2018-02-05 23:40:11.263' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[LOAINGUOIDUNG] ON 

INSERT [dbo].[LOAINGUOIDUNG] ([IDLOAINGUOIDUNG], [TENLOAINGUOIDUNG], [TRANGTHAI]) VALUES (1, N'Admin', 1)
INSERT [dbo].[LOAINGUOIDUNG] ([IDLOAINGUOIDUNG], [TENLOAINGUOIDUNG], [TRANGTHAI]) VALUES (2, N'Khach Hang', 1)
SET IDENTITY_INSERT [dbo].[LOAINGUOIDUNG] OFF
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] ON 

INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (1, N'Áo Bóng Đá', 1)
INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (2, N'Quần Bóng Đá', 1)
INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (3, N'Giày Bóng Đá', 1)
INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (4, N'Găng Tay', 1)
INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (5, N'Vớ - Tất', 1)
INSERT [dbo].[LOAISANPHAM] ([IDLOAISANPHAM], [TENLOAISANPHAM], [TRANGTHAI]) VALUES (6, N'Trái Bóng', 1)
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] OFF
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 

INSERT [dbo].[NGUOIDUNG] ([IDNGUOIDUNG], [TENNGUOIDUNG], [MATKHAU], [SDT], [EMAIL], [TRANGTHAI], [IDLOAINGUOIDUNG]) VALUES (1, N'buu', N'123', N'01266625412', N'tranhoangbuu66@gmail.com', 1, 1)
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([IDSANPHAM], [TENSANPHAM], [GIA], [HINHANH], [NGAY], [MAUSAC], [XUATXU], [MIEUTA], [TRANGTHAI], [IDLOAISANPHAM]) VALUES (1, N'Áo Đấu Barcelona 2014-2015', 100, N'~/image/ao_barcelona_2015_2016.jpg', CAST(N'2018-02-04 11:52:39.117' AS DateTime), N'Xanh - Đỏ', N'Laliga', N'Lộ diện áo đấu mới của Barcelona mùa giải 2017-2018 Các trang mạng xã hội và nhiều tờ báo điện tử ở Tây Ban Nha hôm 5-12 đã đồng loạt cho công bố mẫu trang phục mà Barcelona dự kiến sẽ sử dụng ở mùa giải năm sau, tất nhiên, trên ngực áo có chạy dòng chữ Rakuten. Đây là thương hiệu của nhà tài trợ dự kiến mang lại cho Barcelona khoản thu cực lớn, lên đến xấp xỉ 200 triệu bảng trong vòng 4 mùa giải tiếp theo (chính xác là 48 triệu bảng/mùa và CLB này có thể nhận thêm 5 triệu bảng/mùa nếu thành tích thi đấu đạt mức khả quan). Ngoài ra, Rakuten còn đồng ý điều khoản có thể gia hạn hợp đồng thêm 1 năm nếu Barcelona gặt hái được nhiều thành công.', 1, 1)
INSERT [dbo].[SANPHAM] ([IDSANPHAM], [TENSANPHAM], [GIA], [HINHANH], [NGAY], [MAUSAC], [XUATXU], [MIEUTA], [TRANGTHAI], [IDLOAISANPHAM]) VALUES (2, N'Áo đấu Barcelona 2015-2016', 100, N'~/image/ao_barcelona_2015_2016.jpg', CAST(N'2018-02-02 15:39:21.187' AS DateTime), N'Xanh - Đỏ', N'Tây Ban Nha', N'Lộ diện áo đấu mới của Barcelona mùa giải 2017-2018 Các trang mạng xã hội và nhiều tờ báo điện tử ở Tây Ban Nha hôm 5-12 đã đồng loạt cho công bố mẫu trang phục mà Barcelona dự kiến sẽ sử dụng ở mùa giải năm sau, tất nhiên, trên ngực áo có chạy dòng chữ Rakuten. Đây là thương hiệu của nhà tài trợ dự kiến mang lại cho Barcelona khoản thu cực lớn, lên đến xấp xỉ 200 triệu bảng trong vòng 4 mùa giải tiếp theo (chính xác là 48 triệu bảng/mùa và CLB này có thể nhận thêm 5 triệu bảng/mùa nếu thành tích thi đấu đạt mức khả quan). Ngoài ra, Rakuten còn đồng ý điều khoản có thể gia hạn hợp đồng thêm 1 năm nếu Barcelona gặt hái được nhiều thành công.', 1, 1)
INSERT [dbo].[SANPHAM] ([IDSANPHAM], [TENSANPHAM], [GIA], [HINHANH], [NGAY], [MAUSAC], [XUATXU], [MIEUTA], [TRANGTHAI], [IDLOAISANPHAM]) VALUES (3, N'Áo đấu Barcelona 2015-2016', 100, N'~/image/ao_barcelona_2015_2016.jpg', CAST(N'2018-02-02 15:39:21.187' AS DateTime), N'Xanh - Đỏ', N'Tây Ban Nha', N'Lộ diện áo đấu mới của Barcelona mùa giải 2017-2018 Các trang mạng xã hội và nhiều tờ báo điện tử ở Tây Ban Nha hôm 5-12 đã đồng loạt cho công bố mẫu trang phục mà Barcelona dự kiến sẽ sử dụng ở mùa giải năm sau, tất nhiên, trên ngực áo có chạy dòng chữ Rakuten. Đây là thương hiệu của nhà tài trợ dự kiến mang lại cho Barcelona khoản thu cực lớn, lên đến xấp xỉ 200 triệu bảng trong vòng 4 mùa giải tiếp theo (chính xác là 48 triệu bảng/mùa và CLB này có thể nhận thêm 5 triệu bảng/mùa nếu thành tích thi đấu đạt mức khả quan). Ngoài ra, Rakuten còn đồng ý điều khoản có thể gia hạn hợp đồng thêm 1 năm nếu Barcelona gặt hái được nhiều thành công.', 1, 1)
INSERT [dbo].[SANPHAM] ([IDSANPHAM], [TENSANPHAM], [GIA], [HINHANH], [NGAY], [MAUSAC], [XUATXU], [MIEUTA], [TRANGTHAI], [IDLOAISANPHAM]) VALUES (4, N'Áo đấu Barcelona 2015-2016', 100, N'~/image/ao_barcelona_2015_2016.jpg', CAST(N'2018-02-03 10:42:06.143' AS DateTime), N'Xanh - Đỏ', N'Tây Ban Nha', N'Lộ diện áo đấu mới của Barcelona mùa giải 2017-2018 Các trang mạng xã hội và nhiều tờ báo điện tử ở Tây Ban Nha hôm 5-12 đã đồng loạt cho công bố mẫu trang phục mà Barcelona dự kiến sẽ sử dụng ở mùa giải năm sau, tất nhiên, trên ngực áo có chạy dòng chữ Rakuten. Đây là thương hiệu của nhà tài trợ dự kiến mang lại cho Barcelona khoản thu cực lớn, lên đến xấp xỉ 200 triệu bảng trong vòng 4 mùa giải tiếp theo (chính xác là 48 triệu bảng/mùa và CLB này có thể nhận thêm 5 triệu bảng/mùa nếu thành tích thi đấu đạt mức khả quan). Ngoài ra, Rakuten còn đồng ý điều khoản có thể gia hạn hợp đồng thêm 1 năm nếu Barcelona gặt hái được nhiều thành công.', 1, 1)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD FOREIGN KEY([IDHOADON])
REFERENCES [dbo].[HOADON] ([IDHOADON])
GO
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD FOREIGN KEY([IDSANPHAM])
REFERENCES [dbo].[SANPHAM] ([IDSANPHAM])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([IDNGUOIDUNG])
REFERENCES [dbo].[NGUOIDUNG] ([IDNGUOIDUNG])
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD FOREIGN KEY([IDLOAINGUOIDUNG])
REFERENCES [dbo].[LOAINGUOIDUNG] ([IDLOAINGUOIDUNG])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([IDLOAISANPHAM])
REFERENCES [dbo].[LOAISANPHAM] ([IDLOAISANPHAM])
GO
