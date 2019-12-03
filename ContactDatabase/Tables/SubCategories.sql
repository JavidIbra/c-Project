CREATE TABLE [dbo].[SubCategory]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] nvarchar(50) not null,
	[CategoryId] int not null,	
	CreateUserId int not null,
	[CreateDate] datetime not null default getDate(),
	[DeleteDate] datetime
)
