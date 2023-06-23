CREATE PROCEDURE [dbo].[User_Connection]
	@Email NVARCHAR(30),
	@Passwd NVARCHAR(50)
AS

BEGIN

DECLARE @Peper NVARCHAR(128) = '%1PepperBoy0%'

SELECT Id_User, Firstname, Lastname, Email 
FROM Users
Where Email = @Email AND HashPsw = HASHBYTES('SHA2_512', Salt + @Passwd + @Peper)

END
