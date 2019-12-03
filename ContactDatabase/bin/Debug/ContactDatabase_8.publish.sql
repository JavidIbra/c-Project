﻿/*
Deployment script for ContactHome

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ContactHome"
:setvar DefaultFilePrefix "ContactHome"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[Brands]...';


GO
CREATE TABLE [dbo].[Brands] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [CreateUserId] INT           NOT NULL,
    [CreateDate]   DATETIME      NOT NULL,
    [DeleteDate]   DATETIME      NULL,
    [DeleteId]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Models]...';


GO
CREATE TABLE [dbo].[Models] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [CreateUserId] INT           NOT NULL,
    [CreateDate]   DATETIME      NOT NULL,
    [DeleteDate]   DATETIME      NULL,
    [DeleteId]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[SubCategory]...';


GO
CREATE TABLE [dbo].[SubCategory] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [CategoryId]   INT           NOT NULL,
    [CreateUserId] INT           NOT NULL,
    [CreateDate]   DATETIME      NOT NULL,
    [DeleteDate]   DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Brands]...';


GO
ALTER TABLE [dbo].[Brands]
    ADD DEFAULT getDate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[Models]...';


GO
ALTER TABLE [dbo].[Models]
    ADD DEFAULT getDate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[SubCategory]...';


GO
ALTER TABLE [dbo].[SubCategory]
    ADD DEFAULT getDate() FOR [CreateDate];


GO
if not exists (select top(1) 0 from Roles)
begin
insert into [dbo].[Roles]([Name],[CreateUserId])
values(N'Adminstrator',1),(N'User',1)
end

if not exists (select top(1) 0 from Genders)
begin
insert into [dbo].[Genders]([Name],[CreateUserId])
values(N'Kişi',1),(N'Qadın',1)
end

if not exists (select top(1) 0 from Users)
begin
insert into [dbo].[Users]([Email],[Name],[Surname],[GenderId],[RoleId],[ActivationKey],[ActivateDate],[CreateUserId])
values(N'admin@mail.ru','Admin','Filankesov',1,1,replace(newid(),'-',''),getdate(),1)
end
GO

GO
PRINT N'Update complete.';


GO