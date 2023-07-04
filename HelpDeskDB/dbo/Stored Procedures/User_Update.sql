CREATE PROCEDURE User_Update
    @id INT,
    @Email NVARCHAR(50),
    @Firstname NVARCHAR(50),
    @Lastname NVARCHAR(50),
    @Role NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN

DECLARE @salt VARCHAR(100), @passwordHash VARBINARY(64), @Pepper NVARCHAR(128) = '%1PepperBoy0%'

SET @salt = NEWID();

SET @passwordHash = HASHBYTES('SHA2_512', CONCAT(@salt, @Password, @Pepper))



    UPDATE Users
    SET 
        Email = @Email,
        Firstname = @Firstname,
        Lastname = @Lastname,
        Role = @Role,
        HashPsw = @passwordHash

    WHERE Id_User = @id

    SELECT * FROM Users WHERE Id_User = @id

END





