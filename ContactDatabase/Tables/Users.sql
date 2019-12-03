CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(70) NOT NULL,
	[Name] nvarchar(50) not null,
	Surname NVARCHAR(70) not null,
	[Password] varchar(40) not null,
	[GenderId] int not null,
	[RoleId] int not null default 2,
	ActivationKey char(32),
	ActivateDate datetime,
	CreateUserId int not null,
	[CreateDate] datetime not null default getDate(),
	[DeleteDate] datetime
)
