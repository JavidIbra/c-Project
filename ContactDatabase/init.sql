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