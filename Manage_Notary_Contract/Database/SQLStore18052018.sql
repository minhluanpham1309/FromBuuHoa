USE [Notary_Contract]
GO

/****** Object:  StoredProcedure [dbo].[sp_update_Stt]    Script Date: 5/18/2018 11:30:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_update_Stt]
@id INT,
@stt BIT,
@stDay DATE
AS
	UPDATE dbo.Employee SET Is_Delete = @stt, Date_Start = @stDay WHERE ID_Employee = @id
GO
/****** Object:  StoredProcedure [dbo].[Load_Employee_With_Stt]    Script Date: 5/18/2018 11:31:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Load_Employee_With_Stt]
@stt BIT
AS
	SELECT * FROM dbo.Employee WHERE Is_Delete = @stt
GO


