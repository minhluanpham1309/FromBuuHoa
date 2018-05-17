USE [Notary_Contract]
GO

/****** Object:  StoredProcedure [dbo].[Load_Data_Person]    Script Date: 05/17/18 09:45:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Load_Data_Person]
as
	select LastName, ID_Code, NPerson_Address, Phone_Number, Is_Delete from TB_Notary_Person
GO


