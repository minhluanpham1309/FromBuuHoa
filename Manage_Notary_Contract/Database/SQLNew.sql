USE [Notary_Contract]
GO
/****** Object:  StoredProcedure [dbo].[addCustomer]    Script Date: 5/17/2018 9:28:09 AM ******/
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
	/****** Object:  StoredProcedure [dbo].[sp_delete_customer]    Script Date: 5/17/2018 9:27:28 AM ******/
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
CREATE PROC Load_Employee_With_Stt 0
@stt BIT
AS
	SELECT * FROM dbo.Employee WHERE Is_Delete = @stt
GO
CREATE PROC sp_update_Stt
@id INT,
@stt BIT,
@stDay DATE
AS
	UPDATE dbo.Employee SET Is_Delete = @stt, Date_Start = @stDay WHERE ID_Employee = @id