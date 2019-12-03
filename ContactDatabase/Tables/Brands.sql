CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] nvarchar(50) not null,

	CreateUserId int not null,
	[CreateDate] datetime not null default getDate(),
	[DeleteDate] datetime,
	[DeleteId] datetime
)
