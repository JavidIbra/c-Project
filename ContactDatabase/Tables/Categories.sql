CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(70) NOT NULL, 
    [CreateDate] DATETIME NOT NULL default getdate(),
	[DeletedDate] datetime ,
)
