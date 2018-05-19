USE [Notary_Contract]
GO
/****** Object:  StoredProcedure [dbo].[addCustomer]    Script Date: 5/19/2018 1:13:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_delete_customer]    Script Date: 5/19/2018 1:13:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_edit_customer_info]    Script Date: 5/19/2018 1:13:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_edit_customer_info]
@id INT,
@lastname NVARCHAR(500),
@id_code VARCHAR(15),
@address VARCHAR(100),
@phone VARCHAR(15)
AS
BEGIN TRAN
	UPDATE dbo.TB_Notary_Person SET LastName = @lastname, NPerson_Address = @address, Phone_Number = @phone, ID_Code = @id_code
	WHERE ID_NPerson = @id
	IF(@@error>0)
	BEGIN 
		ROLLBACK TRAN 
	END 	
COMMIT
GO
