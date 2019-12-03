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
/*
The column [dbo].[Brands].[ModelId] is being dropped, data loss could occur.
*/

IF EXISTS (select top 1 1 from [dbo].[Brands])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping unnamed constraint on [dbo].[Models]...';


GO
ALTER TABLE [dbo].[Models] DROP CONSTRAINT [DF__tmp_ms_xx__Creat__70DDC3D8];


GO
PRINT N'Altering [dbo].[Brands]...';


GO
ALTER TABLE [dbo].[Brands] DROP COLUMN [ModelId];


GO
PRINT N'Starting rebuilding table [dbo].[Models]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Models] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [BrandId]      INT           NULL,
    [CreateUserId] INT           NOT NULL,
    [CreateDate]   DATETIME      DEFAULT getDate() NOT NULL,
    [DeleteDate]   DATETIME      NULL,
    [DeleteId]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Models])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Models] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Models] ([Id], [Name], [CreateUserId], [CreateDate], [DeleteDate], [DeleteId])
        SELECT   [Id],
                 [Name],
                 [CreateUserId],
                 [CreateDate],
                 [DeleteDate],
                 [DeleteId]
        FROM     [dbo].[Models]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Models] OFF;
    END

DROP TABLE [dbo].[Models];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Models]', N'Models';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


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
