CREATE PROCEDURE User_Update
    @Id INT,
    @Email NVARCHAR(50),
    @Firstname NVARCHAR(50),
    @Lastname NVARCHAR(50),
    @Role NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN



    UPDATE Users
    SET 
        Email = @Email,
        Firstname = @Firstname,
        Lastname = @Lastname,
        Role = @Role,
        HashPsw = HashPsw

    WHERE Id_User = @Id

    SELECT Id_User, Firstname, Lastname, Role, Email FROM Users WHERE Id_User = @Id

END





