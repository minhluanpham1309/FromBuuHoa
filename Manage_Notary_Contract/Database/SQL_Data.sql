USE [Notary_Contract]
GO
SET IDENTITY_INSERT [dbo].[Notary_Book] ON 
GO
INSERT [dbo].[Notary_Book] ([ID_Notary_Book], [Number_Of_Book], [Year_Book]) VALUES (1, 1, 2018)
GO
SET IDENTITY_INSERT [dbo].[Notary_Book] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Notary_Person] ON 
GO
INSERT [dbo].[TB_Notary_Person] ([ID_NPerson], [LastName], [ID_Code], [NPerson_Address], [Phone_Number]) VALUES (2, N'Phạm Minh Luân', N'271870144', N'bien hoa', N'')
GO
INSERT [dbo].[TB_Notary_Person] ([ID_NPerson], [LastName], [ID_Code], [NPerson_Address], [Phone_Number]) VALUES (6, N'Phạm Minh Luân', N'271870155', N'Bửu Long, Biên Hòa, Đồng Nai', N'')
GO
INSERT [dbo].[TB_Notary_Person] ([ID_NPerson], [LastName], [ID_Code], [NPerson_Address], [Phone_Number]) VALUES (9, N'Phạm Minh Luân', N'2255998800', N'Bửu Long, Biên Hòa, Đồng Nai', N'')
GO
INSERT [dbo].[TB_Notary_Person] ([ID_NPerson], [LastName], [ID_Code], [NPerson_Address], [Phone_Number]) VALUES (10, N'đinh huy hoàng', N'2788888888', N'biên hòa', N'')
GO
SET IDENTITY_INSERT [dbo].[TB_Notary_Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (1, 1, N'tang')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (2, 2, N'mua ban xe may')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (3, 3, N'hduq')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (4, 4, N'vay tien')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (5, 5, N'the chap ')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (6, 6, N'vay tien va the chap')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (7, 7, N'c')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (8, 8, N'van ban thoa thuan')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (9, 9, N'vbpctk')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (10, 10, N'thue')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (11, 11, N'the chap')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (12, 12, N'ô tô mua bán')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (13, 13, N'huy')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (14, 14, N'giay uy quyen')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (15, 15, N'tang ')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (16, 16, N'cam ket')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (17, 17, N'di chuc')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (18, 18, N'ô tô mua bán ')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (19, 19, N'vb nhan tai san thua ke')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (20, 20, N'van ban thu uy quyen')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (21, 21, N'van ban cu dai dien thua ke')
GO
INSERT [dbo].[Type] ([ID], [ID_Type], [Name_Type]) VALUES (22, 22, N'mua ban xe may ')
GO
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[Type_Contract] ON 
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (1, N'Hợp đồng tặng cho quyền sử dụng đất', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (2, N'Hợp đồng mua bán mô tô xe máy ', 0, 2)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (3, N'Hợp đồng ủy quyền', 0, 3)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (4, N'Hợp đồng vay tiền', 0, 4)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (5, N'Hợp đồng thế chấp quyền sử dụng đất', 0, 5)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (6, N'Hợp đồng vay tiền và thế chấp tài sản', 0, 6)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (7, N'Hợp đồng chuyển nhượng quyền sử dụng đất và tài sản gắn liền với đất ', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (8, N'Hợp đồng chuyển nhượng quyền sử dụng đất ', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (9, N'Văn bản thỏa thuận nhập tài sản riêng vào tài sản chung vợ chồng', 0, 8)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (10, N'Văn bản thỏa thuận phân chia di sản thừa kế', 0, 9)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (11, N'Hợp đồng tặng cho quyền sử dụng đất ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (12, N'Hợp đồng thuê quyền sử dụng đất và tài sản gắn liền với đất ', 0, 10)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (13, N'Hợp đồng thế chấp quyền sử dụng đất ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (14, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (15, N'Hợp đồng tặng cho quyền sử dụng đất và tài sản gắn liền với đất ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (16, N'Hợp đồng mua bán xe ô tô', 0, 12)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (17, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (18, N'Hợp đồng thế chấp quyền sử dụng đất', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (19, N'Hợp đồng hủy bỏ hợp đồng chuyển nhượng quyền sử dụng đất', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (20, N'Hợp đồng thế chấp tài sản', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (21, N'Hợp đồng mua bán mô tô, xe máy', 0, 2)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (22, N'hợp đồng thế chấp quyền sử dụng đất sửa đổi bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (23, N'Hợp đồng thế chấp quyền sử dụng đất của bên thứ ba', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (24, N'hợp đồng thế chấp phương tiện giao thông mô tô xe máy ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (25, N'giấy ủy quyền ', 0, 14)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (26, N'Văn bản chấm dứt hợp đồng ủy quyền', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (27, N'Phụ lục hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (28, N'Hợp đồng thuê quyền sử dụng đất ', 0, 10)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (29, N'Hợp đồng sửa đổi, bổ sung hợp đồng thế chấp quyền sử dụng đất ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (30, N'Hợp đồng chuyển nhượng căn hộ, nhà chung cư', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (31, N'Hợp đồng chuyển nhượng quyền sử dụng đất', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (32, N'Văn bản sửa đổi, bổ sung Hợp đồng thế chấp', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (33, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất của bên thứ ba', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (34, N'Hợp đồng thuê tài sản', 0, 10)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (35, N'hợp đồng tặng cho tài sản', 0, 15)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (36, N'Văn bản cam kết tài sản riêng', 0, 16)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (37, N'Hợp đồng sửa đổi bổ sung hợp đồng thế chấp quyền sử dụng đất của bên thứ ba ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (38, N'Hợp đồng thế chấp tài sản gắn liền với đất', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (39, N'Giấy ủy quyền', 0, 14)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (40, N'Hợp đồng mua bán xe ô tô ', 0, 12)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (41, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất sửa đổi bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (42, N'Hợp đồng hủy bỏ hợp đồng mua bán xe ô tô ', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (43, N'Hợp đồng ủy quyền ', 0, 3)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (44, N'Hợp đồng tăng cho quyền sử dụng đất ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (45, N'Văn bản chăm dứt hợp đồng thuê quyền sử dụng đất ', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (46, N'Hợp đồng thế chấp quyền sử dụng đất ccủa bên thứ 3 sửa đổi, bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (47, N'di chúc', 0, 17)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (48, N'hợp đồng hủy bỏ quyền sử dụng đất', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (49, N'hợp đồng chuyển nhượng  quyền sử dụng đất', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (50, N'Hợp đồng thế chấp sửa đổi bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (51, N'hợp đồng mua bán mô tô xe máy', 0, 2)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (52, N'hợp đồng hủy bỏ hợp đồng chuyển nhượng quyền sử dụng đất ', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (53, N'Hợp đồng sửa đổi, bổ sung hợp đồng thế chấp tài sản', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (54, N'hợp đồng mua bán xe ô tô', 0, 18)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (55, N'Văn bản hủy bỏ di chúc', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (56, N'Hợp đồng hủy bỏ hợp đồng tặng cho quyền sử dụng đất và tài sản gắn liền với đất ', 0, 13)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (57, N'hợp đồng thế chấp quyền sử dụng đất sửa đổi, bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (58, N'Hợp đồng thế chấp quyền sử dụng đất của bên thứ 3 sửa đổi, bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (59, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất của bên thứ 3 ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (60, N'Hợp đồng thế chấp phương tiện giao thông mô tô, xe máy', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (61, N'Hợp đồng  mua bán xe ô tô', 0, 12)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (62, N'Hợp đồng thế chấp quyền sử dụng đất của bên thứ 3 sửa đổi bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (63, N'Hợp đồng tặng cho quyền sử dụng đất và tài sản gắn liền với đất  ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (64, N'Văn bản thỏa thuận phân chia di sản thừa kế ', 0, 9)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (65, N'Phụ lục hợp đồng thế chấp quyền sử dụng đất ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (66, N'Hợp đồng thế chấp quyền sử dụng đất của bên thứ 3 ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (67, N'Văn bản thỏa thuận cử người đại diện nhận tài sản thừa kế', 0, 19)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (68, N'Văn bản phân chia tài sản thừa kế', 0, 9)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (69, N'Hợp đồng thuê nhà', 0, 10)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (70, N'Hợp đồng thế chấp tài sản đảm bảo khoản vay', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (71, N'hợp đồng chuyển nhượng quyền sử dụng đất và tài sản gắn liền với đất', 0, 7)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (72, N'Hợp đồng thế chấp quyền sử dụng đất của bên thứ 3  sửa đổi bổ sung', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (73, N'Hợp đồng mua bán mô tô, xe may', 0, 2)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (74, N'Văn bản thụ ủy quyền', 0, 20)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (75, N'Văn bản thỏa thuận cử đại diện đứng tên di sản thừa kế', 0, 21)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (76, N'Hơp đồng tặng cho quyền sử dụng đất ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (77, N'Văn bản nhận tài sản thừa kế theo di chúc', 0, 19)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (78, N'Hợp tặng cho quyền sử dụng đất ', 0, 1)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (79, N'Phụ lục hợp đồng thế chấp quyền sử dụng đất  ', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (80, N'Hợp đồng thế chấp quyền sử dụng đất và tài sản gắn liền với đất  của bên thứ ba', 0, 11)
GO
INSERT [dbo].[Type_Contract] ([ID_TContract], [Type_Name_Contract], [Number_Side], [ID_Type]) VALUES (81, N'Hợp đồng thuê quyền sử dụng đất', 0, 10)
GO
SET IDENTITY_INSERT [dbo].[Type_Contract] OFF
GO
SET IDENTITY_INSERT [dbo].[Notary] ON 
GO
INSERT [dbo].[Notary] ([ID_NoTary], [Name_Notary], [Regency], [IS_Delect]) VALUES (1, N'Lê Thị Ngọc hiêp', N'TVP', 0)
GO
SET IDENTITY_INSERT [dbo].[Notary] OFF
GO
SET IDENTITY_INSERT [dbo].[Notary_Contract] ON 
GO
INSERT [dbo].[Notary_Contract] ([ID_NotaryContract], [Notary_Number], [Description], [ID_Contract_Type], [ID_Notary_Person], [Notary_Date], [Sign_Date], [Note], [Notary_Price], [ID_Notary_Book], [Contract_Image_Scan], [Signed_Person]) VALUES (6, N'1', N'Ông phạm minh luân mua chiếc xe máy bks 52988', 21, 6, CAST(N'2018-05-15' AS Date), CAST(N'2018-05-15' AS Date), N'', 150000, 1, N'', 1)
GO
INSERT [dbo].[Notary_Contract] ([ID_NotaryContract], [Notary_Number], [Description], [ID_Contract_Type], [ID_Notary_Person], [Notary_Date], [Sign_Date], [Note], [Notary_Price], [ID_Notary_Book], [Contract_Image_Scan], [Signed_Person]) VALUES (13, N'2', N'Ông phạm minh luân mua chiếc xe máy bks 52988', 21, 9, CAST(N'2018-05-13' AS Date), CAST(N'2018-05-13' AS Date), N'', 150000, 1, N'', 1)
GO
INSERT [dbo].[Notary_Contract] ([ID_NotaryContract], [Notary_Number], [Description], [ID_Contract_Type], [ID_Notary_Person], [Notary_Date], [Sign_Date], [Note], [Notary_Price], [ID_Notary_Book], [Contract_Image_Scan], [Signed_Person]) VALUES (14, N'3', N'', 18, 2, CAST(N'2018-05-15' AS Date), CAST(N'2018-05-15' AS Date), N'', 0, 1, N'', 1)
GO
INSERT [dbo].[Notary_Contract] ([ID_NotaryContract], [Notary_Number], [Description], [ID_Contract_Type], [ID_Notary_Person], [Notary_Date], [Sign_Date], [Note], [Notary_Price], [ID_Notary_Book], [Contract_Image_Scan], [Signed_Person]) VALUES (16, N'4', N'', 54, 2, CAST(N'2018-05-15' AS Date), CAST(N'2018-05-15' AS Date), N'', 0, 1, N'', 1)
GO
INSERT [dbo].[Notary_Contract] ([ID_NotaryContract], [Notary_Number], [Description], [ID_Contract_Type], [ID_Notary_Person], [Notary_Date], [Sign_Date], [Note], [Notary_Price], [ID_Notary_Book], [Contract_Image_Scan], [Signed_Person]) VALUES (20, N'5', N'sdasdasdasa', 39, 10, CAST(N'2018-05-16' AS Date), CAST(N'2018-05-16' AS Date), N'', 7000000, 1, N'', 1)
GO
SET IDENTITY_INSERT [dbo].[Notary_Contract] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([ID_Employee], [Employee_Name], [Birth_Day], [Date_Start], [Salary], [Is_Delete]) VALUES (1, N'Lê Thị Ngọc Hiệp', CAST(N'1973-08-19' AS Date), CAST(N'2010-05-19' AS Date), NULL, 0)
GO
INSERT [dbo].[Employee] ([ID_Employee], [Employee_Name], [Birth_Day], [Date_Start], [Salary], [Is_Delete]) VALUES (2, N'Nguyễn Đình Tân', CAST(N'1987-02-14' AS Date), CAST(N'2010-10-19' AS Date), NULL, 0)
GO
INSERT [dbo].[Employee] ([ID_Employee], [Employee_Name], [Birth_Day], [Date_Start], [Salary], [Is_Delete]) VALUES (3, N'Lê Viết Tường', CAST(N'1987-07-19' AS Date), CAST(N'2010-09-19' AS Date), 0, 1)
GO
INSERT [dbo].[Employee] ([ID_Employee], [Employee_Name], [Birth_Day], [Date_Start], [Salary], [Is_Delete]) VALUES (5, N'long', CAST(N'1988-09-13' AS Date), CAST(N'2013-06-01' AS Date), 4000000, 1)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
