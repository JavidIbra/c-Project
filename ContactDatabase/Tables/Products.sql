CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[ModelId] int null,
	[CreateDate] DATETIME NOT NULL default getdate(),
)
