USE [Notary_Contract]
GO
/****** Object:  StoredProcedure [dbo].[add_contract]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[add_contract] 
@no_num VARCHAR(20),
@name_per NVARCHAR(100),
@address NVARCHAR(100),
@phone VARCHAR(20),
@no_day DATE,
@sign_day DATE,
@nu_book INT,
@des NTEXT,
@ty_name NVARCHAR(100),
@type NVARCHAR(50),
@price INT ,
@sig_person NVARCHAR(100),
@note NVARCHAR(100), 
@year_bo INT
AS
	BEGIN TRAN
			DECLARE @co int;
			SELECT @co = dbo.fun_Check_id_code(@id_code)
			DECLARE @id_con_ty INT;
			DECLARE @id_no_pe INT;
			DECLARE @id_no_bo INT;
			DECLARE @id_sig_pe INT;
			SELECT @id_con_ty = ID_TContract FROM dbo.Type_Contract WHERE Type_Name_Contract = @ty_name
			SELECT @id_no_pe = ID_NPerson FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code
			SELECT @id_sig_pe = ID_NoTary FROM dbo.Notary WHERE Name_Notary = @sig_person 
			SELECT @id_no_bo = ID_Notary_Book FROM dbo.Notary_Book WHERE Number_Of_Book = @nu_book AND Year_Book = @year_bo
		IF(@co > 0)
		BEGIN
			
			EXEC dbo.insert_contract @no_num, @des, @id_con_ty, @id_no_pe, @no_day,@sign_day, @note,@price,@id_no_bo, @id_sig_pe
		END 
		ELSE 
		BEGIN 
			INSERT dbo.TB_Notary_Person
			(
			    LastName,
			    ID_Code,
			    NPerson_Address,
			    Phone_Number
			)
			VALUES
			(   @name_per, -- LastName - nvarchar(100)
			    @id_code,  -- ID_Code - varchar(10)
			    @address, -- NPerson_Address - ntext
			    ''   -- Phone_Number - varchar(15)
			    )
			SELECT @id_no_pe = ID_NPerson FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code
			EXEC dbo.insert_contract @no_num, @des, @id_con_ty, @id_no_pe, @no_day,@sign_day, @note,@price,@id_no_bo, @id_sig_pe 
		END 
			IF(@@ERROR>0)
				ROLLBACK TRAN
	COMMIT

GO
/****** Object:  StoredProcedure [dbo].[addCustomer]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[addCustomer] 
@lastName varchar(100),
@id_code varchar(10),
@address varchar(100),
@phoneNumber varchar(15)
AS
	INSERT INTO dbo.TB_Notary_Person( LastName ,ID_Code ,NPerson_Address ,Phone_Number, Is_Delete)
	VALUES  ( @lastName, @id_code, @address, @phoneNumber, 0)

GO
/****** Object:  StoredProcedure [dbo].[check_id_code]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[check_id_code]
@id_code VARCHAR(10)
AS
	SELECT  * FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code

GO
/****** Object:  StoredProcedure [dbo].[check_id_code_count]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[check_id_code_count]
@id_code VARCHAR(10)
AS
	SELECT  COUNT(*) FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code

GO
/****** Object:  StoredProcedure [dbo].[insert_contract]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_contract]( @no_num VARCHAR(10),
				@des NTEXT,       
				@id_con_ty int,         
				@id_no_pe int,        
				@no_day DATE, 
				@sign_day DATE, 
				@note NVARCHAR(200),       
				@price int,       
				@id_no_bo int,              
				@id_sig_pe INT)
AS
BEGIN
	INSERT dbo.Notary_Contract
			(
				Notary_Number,
				[Description],
				ID_Contract_Type,
				ID_Notary_Person,
				Notary_Date,
				Sign_Date,
				Note,
				Notary_Price,
				ID_Notary_Book,
				Contract_Image_Scan,
				Signed_Person
			)
			VALUES
			(   @no_num,        -- Notary_Number - varchar(20)
				@des,       -- Description - ntext
				@id_con_ty,         -- ID_Contract_Type - int
				@id_no_pe,         -- ID_Notary_Person - int
				@no_day, -- Notary_Date - date
				@sign_day, -- Sign_Date - date
				@note,       -- Note - nvarchar(500)
				@price,       -- Notary_Price - float
				@id_no_bo,         -- ID_Notary_Book - int
				'',        -- Contract_Image_Scan - varchar(100)
				@id_sig_pe          -- Signed_Person - int
				)	
END

GO
/****** Object:  StoredProcedure [dbo].[load_data_all_controll_with_noNum]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_all_controll_with_noNum]
 @no_num VARCHAR(10)
 AS
	SELECT dbo.Notary_Contract.Notary_Number, ID_Code, LastName, NPerson_Address, Notary_Date, Sign_Date, Number_Of_Book, [Description], Type_Name_Contract, Name_Type, Notary_Price, Name_Notary , Note, Year_Book 
	FROM 
	dbo.Notary_Contract INNER JOIN dbo.Notary_Book ON Notary_Book.ID_Notary_Book = Notary_Contract.ID_Notary_Book INNER JOIN dbo.Type_Contract ON Type_Contract.ID_TContract = Notary_Contract.ID_Contract_Type INNER JOIN dbo.TB_Notary_Person ON TB_Notary_Person.ID_NPerson = Notary_Contract.ID_Notary_Person INNER JOIN dbo.[Type] ON Type.ID_Type = Type_Contract.ID_Type INNER JOIN dbo.Notary ON Notary.ID_NoTary = Notary_Contract.Signed_Person
	 WHERE Notary_Number = @no_num

GO
/****** Object:  StoredProcedure [dbo].[load_data_name_contract]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_name_contract]
AS
	SELECT ID_TContract, Type_Name_Contract, Number_Side FROM dbo.Type_Contract

GO
/****** Object:  StoredProcedure [dbo].[load_data_nameCon_tyCon]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_nameCon_tyCon]
AS
	SELECT Type_Name_Contract, Name_Type FROM dbo.Type_Contract INNER JOIN dbo.Type ON Type.ID = Type_Contract.ID_Type

GO
/****** Object:  StoredProcedure [dbo].[load_data_nobo]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_nobo]
AS
	SELECT Number_Of_Book, Year_Book FROM dbo.Notary_Book

GO
/****** Object:  StoredProcedure [dbo].[load_data_notary]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_notary]
AS
	SELECT  Name_Notary FROM dbo.Notary

GO
/****** Object:  StoredProcedure [dbo].[Load_Data_Person]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Load_Data_Person]
AS
	SELECT LastName, ID_Code, NPerson_Address, Phone_Number, Is_Delete FROM dbo.TB_Notary_Person

GO
/****** Object:  StoredProcedure [dbo].[load_data_typeCon]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[load_data_typeCon]
AS
	SELECT Name_Type FROM dbo.Type

GO
/****** Object:  StoredProcedure [dbo].[sp_add_em]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_add_em]
@name NVARCHAR(500),
@bday DATE,
@stday DATE,
@salary FLOAT
AS
BEGIN TRAN
	INSERT dbo.Employee
	(
	    Employee_Name,
	    Birth_Day,
	    Date_Start,
	    Salary,
	    Is_Delete
	)
	VALUES
	(   @name,       -- Employee_Name - nvarchar(100)
	    @bday, -- Birth_Day - date
	    @stday, -- Date_Start - date
	    @salary,       -- Salary - float
	    0       -- Is_Delete - bit
	    )
		SELECT * FROM dbo.Employee
		IF(@@ERROR>0)
			ROLLBACK TRAN
COMMIT

GO
/****** Object:  StoredProcedure [dbo].[sp_create_NPerson]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_create_NPerson]
@name NVARCHAR(100),
@id_code VARCHAR(10),
@address NTEXT,
@phone VARCHAR(15)
AS
BEGIN TRAN
	INSERT dbo.TB_Notary_Person
	(
	    LastName,
	    ID_Code,
	    NPerson_Address,
	    Phone_Number
	)
	VALUES
	(   @name, -- LastName - nvarchar(100)
	    @id_code,  -- ID_Code - varchar(10)
	    @address, -- NPerson_Address - ntext
	    @phone   -- Phone_Number - varchar(15)
	    )
		SELECT * FROM dbo.TB_Notary_Person
	IF(@@ERROR>0)
		ROLLBACK TRAN
COMMIT

GO
/****** Object:  StoredProcedure [dbo].[sp_del_em]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[sp_del_em] 
@id INT
AS
BEGIN TRAN
	UPDATE dbo.Employee SET Is_Delete = 1 WHERE ID_Employee = @id  
	SELECT * FROM Employee
	IF(@@ERROR >0)
		ROLLBACK;
COMMIT 

GO
/****** Object:  StoredProcedure [dbo].[sp_delete_customer]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_delete_customer] 
@id_code varchar(10)
AS
	 UPDATE dbo.TB_Notary_Person SET is_Delete = 1
	WHERE ID_Code = @id_code

GO
/****** Object:  StoredProcedure [dbo].[sp_get_info_employ]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_get_info_employ]
as
	SELECT * FROM [dbo].[Employee]

GO
/****** Object:  StoredProcedure [dbo].[sp_getdata_contract_view]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getdata_contract_view]
AS
	SELECT * FROM dbo.vw_contract_book

GO
/****** Object:  StoredProcedure [dbo].[sp_getdata_contract_view_]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getdata_contract_view_]
AS
	SELECT * FROM dbo.vw_contract_book

GO
/****** Object:  StoredProcedure [dbo].[sp_getdata_contract_view_top]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getdata_contract_view_top]
AS
	SELECT TOP (1) Notary_Number, LastName, NPerson_Address, Notary_Date, Sign_Date, Number_Of_Book, [Description], Type_Name_Contract, Name_Type,Notary_Price, Name_Notary , Note FROM  dbo.Notary_Contract INNER JOIN dbo.Notary_Book ON Notary_Book.ID_Notary_Book = Notary_Contract.ID_Notary_Book INNER JOIN dbo.Type_Contract ON Type_Contract.ID_TContract = Notary_Contract.ID_Contract_Type INNER JOIN dbo.TB_Notary_Person ON TB_Notary_Person.ID_NPerson = Notary_Contract.ID_Notary_Person INNER JOIN dbo.[Type] ON Type.ID_Type = Type_Contract.ID_Type INNER JOIN dbo.Notary ON Notary.ID_NoTary = Notary_Contract.Signed_Person
	ORDER BY Notary_Number DESC

GO
/****** Object:  StoredProcedure [dbo].[sp_load_data_type_no]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_load_data_type_no]
AS 		
	INSERT dbo.Type
	(
	    ID_Type,
	    Name_Type
	)
	SELECT ID_Type, Name_Type FROM BuuHoaNotaryOffice.dbo.[Type]

GO
/****** Object:  StoredProcedure [dbo].[sp_update_contract]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_update_contract] 
@no_num VARCHAR(20),
@name_per NVARCHAR(100),
@id_code VARCHAR(10),
@address NVARCHAR(100),
@phone VARCHAR(20),
@no_day DATE,
@sign_day DATE,
@nu_book INT,
@des NTEXT,
@ty_name NVARCHAR(100),
@type NVARCHAR(50),
@price INT ,
@sig_person NVARCHAR(100),
@note NVARCHAR(100), 
@year_bo INT
AS
	BEGIN TRAN
			DECLARE @co int;
			SELECT @co = dbo.fun_Check_id_code(@id_code)
			DECLARE @id_con_ty INT;
			DECLARE @id_no_pe INT;
			DECLARE @id_no_bo INT;
			DECLARE @id_sig_pe INT;
			SELECT @id_con_ty = ID_TContract FROM dbo.Type_Contract WHERE Type_Name_Contract = @ty_name
			SELECT @id_no_pe = ID_NPerson FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code
			SELECT @id_sig_pe = ID_NoTary FROM dbo.Notary WHERE Name_Notary = @sig_person 
			SELECT @id_no_bo = ID_Notary_Book FROM dbo.Notary_Book WHERE Number_Of_Book = @nu_book AND Year_Book = @year_bo
		IF(@co > 0)
		BEGIN
			
			EXEC update_contract @no_num, @des, @id_con_ty, @id_no_pe, @no_day,@sign_day, @note,@price,@id_no_bo, @id_sig_pe
		END 
		ELSE 
		BEGIN 
			INSERT dbo.TB_Notary_Person
			(
			    LastName,
			    ID_Code,
			    NPerson_Address,
			    Phone_Number
			)
			VALUES
			(   @name_per, -- LastName - nvarchar(100)
			    @id_code,  -- ID_Code - varchar(10)
			    @address, -- NPerson_Address - ntext
			    ''   -- Phone_Number - varchar(15)
			    )
			SELECT @id_no_pe = ID_NPerson FROM dbo.TB_Notary_Person WHERE ID_Code = @id_code
			EXEC update_contract @no_num, @des, @id_con_ty, @id_no_pe, @no_day,@sign_day, @note,@price,@id_no_bo, @id_sig_pe 
		END 
			IF(@@ERROR>0)
				ROLLBACK TRAN
	COMMIT

GO
/****** Object:  StoredProcedure [dbo].[sp_update_em]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[sp_update_em] 
@id INT,
@name NVARCHAR(500),
@bday DATE,
@stday DATE,
@salary FLOAT
AS
BEGIN TRAN
	UPDATE dbo.Employee SET Employee_Name = @name, Birth_Day = @bday, Date_Start = @stday, Salary = @salary 
	WHERE ID_Employee = @id
	IF(@@error>0)
	BEGIN 
		ROLLBACK TRAN 
	END 	
COMMIT

GO
/****** Object:  StoredProcedure [dbo].[sp_update_noperson]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_update_noperson]
@id_code VARCHAR(10),
@name NVARCHAR(100),
@address NVARCHAR(100),
@phone NVARCHAR(20)
AS
	UPDATE dbo.TB_Notary_Person SET NPerson_Address = @address, Phone_Number = @phone, LastName = @name WHERE ID_Code = @id_code 

GO
/****** Object:  StoredProcedure [dbo].[update_contract]    Script Date: 5/17/2018 8:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[update_contract]( @no_num VARCHAR(10),
				@des NTEXT,       
				@id_con_ty int,         
				@id_no_pe int,        
				@no_day DATE, 
				@sign_day DATE, 
				@note NVARCHAR(200),       
				@price int,       
				@id_no_bo int,              
				@id_sig_pe INT)
AS
BEGIN
		UPDATE dbo.Notary_Contract SET Notary_Number = @no_num,
				[Description] = @des,
				ID_Contract_Type = @id_con_ty,
				ID_Notary_Person = @id_no_pe,
				Notary_Date = @no_day,
				Sign_Date = @sign_day,
				Note = @note,
				Notary_Price =@price,
				ID_Notary_Book =@id_no_bo,
				Contract_Image_Scan ='',
				Signed_Person = @id_sig_pe
		WHERE Notary_Number = @no_num; 
END

GO
alter table [dbo].[TB_Notary_Person] add Is_Delete bit null default 1
go
update [dbo].[TB_Notary_Person] set Is_Delete = 0 
create proc Load_Data_Person
as
	select LastName, ID_Code, NPerson_Address, Phone_Number, Is_Delete from TB_Notary_Person