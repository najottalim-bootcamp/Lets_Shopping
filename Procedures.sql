USE LetsShopDb;
GO

CREATE PROCEDURE GetAll 
@TableName NVARCHAR(128) 
AS 
BEGIN 
  SET NOCOUNT ON;
  DECLARE @Sql NVARCHAR(MAX);

SET @Sql = N'SELECT  *  
              FROM ' + QUOTENAME(@TableName)
          + N' ; '

 EXECUTE sp_executesql @Sql

END
GO

CREATE PROCEDURE GetAById 
@TableName NVARCHAR(128) ,
@Id INT
AS 
BEGIN 
  SET NOCOUNT ON;
  DECLARE @Sql NVARCHAR(MAX);

SET @Sql = N'SELECT  *  
              FROM ' + QUOTENAME(@TableName)
          + N' WHERE Id = '+Cast(@Id AS varchar)+'; ';

 EXECUTE sp_executesql @Sql

END

GO