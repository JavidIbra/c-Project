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
The column [dbo].[Users].[Password] on table [dbo].[Users] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[Users])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping unnamed constraint on [dbo].[Users]...';


GO
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [DF__Users__RoleId__403A8C7D];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Users]...';


GO
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [DF__Users__CreateDat__412EB0B6];


GO
PRINT N'Starting rebuilding table [dbo].[Users]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Users] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Email]         NVARCHAR (70) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Surname]       NVARCHAR (70) NOT NULL,
    [Password]      VARCHAR (40)  NOT NULL,
    [GenderId]      INT           NOT NULL,
    [RoleId]        INT           DEFAULT 2 NOT NULL,
    [ActivationKey] CHAR (32)     NULL,
    [ActivateDate]  DATETIME      NULL,
    [CreateUserId]  INT           NOT NULL,
    [CreateDate]    DATETIME      DEFAULT getDate() NOT NULL,
    [DeleteDate]    DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Users])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Users] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Users] ([Id], [Email], [Name], [Surname], [GenderId], [RoleId], [ActivationKey], [ActivateDate], [CreateUserId], [CreateDate], [DeleteDate])
        SELECT   [Id],
                 [Email],
                 [Name],
                 [Surname],
                 [GenderId],
                 [RoleId],
                 [ActivationKey],
                 [ActivateDate],
                 [CreateUserId],
                 [CreateDate],
                 [DeleteDate]
        FROM     [dbo].[Users]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Users] OFF;
    END

DROP TABLE [dbo].[Users];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Users]', N'Users';

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
insert into [dbo].[Users]([Email],[Password],[Name],[Surname],[GenderId],[RoleId],[ActivationKey],[ActivateDate],[CreateUserId])
values(N'admin@mail.ru','40BD001563085FC35165329EA1FF5C5ECBDBBEEF','Admin','Filankesov',1,1,replace(newid(),'-',''),getdate(),1)
end
GO

GO
PRINT N'Update complete.';


GO
