--stored procedures for getting the login details

create procedure GetLoginDetails(@UserEmail varchar(30))
as
begin
select UserType,UserEmail,UserPassword from [User] where UserEmail=@UserEmail
end

exec GetLoginDetails 'admin@gmail.com'

--stored procedure for adding user

create procedure AddingUser(@UserType varchar(20),@UserEmail varchar(30),@UserPassword varchar(30),@UserFirstName varchar(30),@UserLastName varchar(30),@Gender char)
as
begin
declare @UserId numeric(10)
select @UserId=MAX(UserId) from [User]
set @UserId=@UserId+1
insert into [User] values(@UserType,@UserId,@UserEmail,@UserPassword,@UserFirstName,@UserLastName,@Gender)
end

exec AddingUser 'Learner','sam@gmail.com','Sam1234+','sam','peter','M'

