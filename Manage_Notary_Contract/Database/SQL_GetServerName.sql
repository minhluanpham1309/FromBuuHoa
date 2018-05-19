ALTER PROCEDURE [GetServerName]
AS
SELECT @@ServerName AS [SERVER NAME] 
GO

EXEC [GetServerName]