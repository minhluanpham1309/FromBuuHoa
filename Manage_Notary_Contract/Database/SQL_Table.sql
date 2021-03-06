CREATE DATABASE [Notary_Contract]
go
USE [Notary_Contract]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID_Employee] [int] IDENTITY(1,1) NOT NULL,
	[Employee_Name] [nvarchar](100) NULL,
	[Birth_Day] [date] NULL,
	[Date_Start] [date] NULL,
	[Salary] [float] NULL,
	[Is_Delete] [bit] NULL,
 CONSTRAINT [PK_ID_Employee] PRIMARY KEY CLUSTERED 
(
	[ID_Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notary]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notary](
	[ID_NoTary] [int] IDENTITY(1,1) NOT NULL,
	[Name_Notary] [nvarchar](100) NOT NULL,
	[Regency] [nvarchar](50) NULL,
	[IS_Delect] [bit] NOT NULL,
 CONSTRAINT [PK_ID_Notary] PRIMARY KEY CLUSTERED 
(
	[ID_NoTary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notary_Book]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notary_Book](
	[ID_Notary_Book] [int] IDENTITY(1,1) NOT NULL,
	[Number_Of_Book] [int] NOT NULL,
	[Year_Book] [int] NOT NULL,
 CONSTRAINT [PK_ID_Book] PRIMARY KEY CLUSTERED 
(
	[ID_Notary_Book] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notary_Contract]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notary_Contract](
	[ID_NotaryContract] [int] IDENTITY(1,1) NOT NULL,
	[Notary_Number] [varchar](20) NOT NULL,
	[Description] [ntext] NULL,
	[ID_Contract_Type] [int] NOT NULL,
	[ID_Notary_Person] [int] NOT NULL,
	[Notary_Date] [date] NOT NULL,
	[Sign_Date] [date] NOT NULL,
	[Note] [nvarchar](500) NULL,
	[Notary_Price] [float] NOT NULL,
	[ID_Notary_Book] [int] NOT NULL,
	[Contract_Image_Scan] [varchar](100) NULL,
	[Signed_Person] [int] NOT NULL,
 CONSTRAINT [PK_Notary_Contract] PRIMARY KEY CLUSTERED 
(
	[ID_NotaryContract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Notary_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Notary_Person]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Notary_Person](
	[ID_NPerson] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[ID_Code] [varchar](10) NOT NULL,
	[NPerson_Address] [ntext] NULL,
	[Phone_Number] [varchar](15) NULL,
 CONSTRAINT [PK_ID_NPerson] PRIMARY KEY CLUSTERED 
(
	[ID_NPerson] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uni_id_code] UNIQUE NONCLUSTERED 
(
	[ID_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Type] [int] NULL,
	[Name_Type] [varchar](50) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Contract]    Script Date: 5/17/2018 12:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Contract](
	[ID_TContract] [int] IDENTITY(1,1) NOT NULL,
	[Type_Name_Contract] [nvarchar](100) NULL,
	[Number_Side] [int] NOT NULL,
	[ID_Type] [int] NULL,
 CONSTRAINT [PK_ID_TContract] PRIMARY KEY CLUSTERED 
(
	[ID_TContract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((1)) FOR [Is_Delete]
GO
ALTER TABLE [dbo].[Notary] ADD  DEFAULT ((1)) FOR [IS_Delect]
GO
ALTER TABLE [dbo].[Type_Contract] ADD  CONSTRAINT [DF_Type_Contract_Number_Side]  DEFAULT ((1)) FOR [Number_Side]
GO
ALTER TABLE [dbo].[Notary_Contract]  WITH CHECK ADD  CONSTRAINT [fk_NoCon_Book] FOREIGN KEY([ID_Notary_Book])
REFERENCES [dbo].[Notary_Book] ([ID_Notary_Book])
GO
ALTER TABLE [dbo].[Notary_Contract] CHECK CONSTRAINT [fk_NoCon_Book]
GO
ALTER TABLE [dbo].[Notary_Contract]  WITH CHECK ADD  CONSTRAINT [fk_NoCon_Notary] FOREIGN KEY([Signed_Person])
REFERENCES [dbo].[Notary] ([ID_NoTary])
GO
ALTER TABLE [dbo].[Notary_Contract] CHECK CONSTRAINT [fk_NoCon_Notary]
GO
ALTER TABLE [dbo].[Notary_Contract]  WITH CHECK ADD  CONSTRAINT [fk_NoCon_NPer] FOREIGN KEY([ID_Notary_Person])
REFERENCES [dbo].[TB_Notary_Person] ([ID_NPerson])
GO
ALTER TABLE [dbo].[Notary_Contract] CHECK CONSTRAINT [fk_NoCon_NPer]
GO
ALTER TABLE [dbo].[Notary_Contract]  WITH CHECK ADD  CONSTRAINT [fk_NoCon_Type] FOREIGN KEY([ID_Contract_Type])
REFERENCES [dbo].[Type_Contract] ([ID_TContract])
GO
ALTER TABLE [dbo].[Notary_Contract] CHECK CONSTRAINT [fk_NoCon_Type]
GO
ALTER TABLE [dbo].[Type_Contract]  WITH CHECK ADD  CONSTRAINT [fk_TContract] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[Type] ([ID])
GO
ALTER TABLE [dbo].[Type_Contract] CHECK CONSTRAINT [fk_TContract]
GO
