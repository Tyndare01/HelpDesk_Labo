CREATE PROCEDURE [dbo].[User_Register]
	@Email NVARCHAR(100),
	@Firstname NVARCHAR(50),
	@Lastname NVARCHAR (50),
	@Passwd NVARCHAR(50),
	@Role NVARCHAR(15)
AS
	
BEGIN

DECLARE @salt VARCHAR(100), @passwordHash VARBINARY(64), @Pepper NVARCHAR(128) = '%1PepperBoy0%'

SET @salt = NEWID();

SET @passwordHash = HASHBYTES('SHA2_512', CONCAT(@salt, @Passwd, @Pepper))

Insert INTO Users(Email, Firstname, Lastname, Role, SALT, HashPsw)

VALUES (@Email, @Firstname, @Lastname, @Role, @salt, @passwordHash)

END