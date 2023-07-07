
    CREATE PROCEDURE [dbo].[User_CheckPassword]
    @Id int,
    @actualpasswd NVARCHAR(50),
    @newpasswd NVARCHAR(50)
AS
BEGIN
    DECLARE @Pepper NVARCHAR(128) = '%1PepperBoy0%'


    IF EXISTS (
        SELECT 1
        FROM Users
        WHERE Id_User = @id
            AND HashPsw = HASHBYTES('SHA2_512', salt + @actualpasswd + @Pepper)
    )
    BEGIN

        UPDATE Users
        SET HashPsw = HASHBYTES('SHA2_512', salt + @newpasswd + @Pepper)
        WHERE Id_User = @Id;

        Print 'Ca a fonctionné!'
        RETURN 0
    END
    ELSE
    BEGIN
        Print 'Ca a foiré!'
        Return 1
    END
END
