USE [Notary_Contract]
GO
/****** Object:  StoredProcedure [dbo].[GetServerName]    Script Date: 05/19/18 19:11:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetServerName]
AS
SELECT @@ServerName AS [SERVER NAME] 

GO
