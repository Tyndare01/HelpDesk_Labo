CREATE PROCEDURE [dbo].[User_Register]
	@Email NVARCHAR(50),
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR (50),
	@Passwd NVARCHAR(50)
AS
	
BEGIN

DECLARE @salt VARCHAR, @passwordHash VARBINARY(64), @Pepper NVARCHAR(128) = '%1PepperBoy0%'

SET @salt = NEWID();

SET @passwordHash = HASHBYTES('SHA2_512', @salt + @Passwd + @Pepper)

Insert INTO Users(Email, Firstname, Lastname, Role, SALT, HashPsw)

VALUES (@Email, @Firstname, @Lastname, 0, @salt, @passwordHash)

END 
