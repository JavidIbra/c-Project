CREATE TABLE [dbo].[Models]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] nvarchar(50) not null,
	[BrandId] int ,
	CreateUserId int not null,
	[CreateDate] datetime not null default getDate(),
	[DeleteDate] datetime,
	[DeleteId] datetime
)
