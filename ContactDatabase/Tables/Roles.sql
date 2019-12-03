CREATE TABLE [dbo].[Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NOT NULL,
	CreateUserId int not null,
	[CreateDate] datetime not null default getDate(),
	[DeleteDate] datetime
	)