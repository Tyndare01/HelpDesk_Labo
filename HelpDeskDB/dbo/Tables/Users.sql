CREATE TABLE [dbo].[Users] (
    [Id_User]   INT IDENTITY  NOT NULL,
    [Firstname] VARCHAR (50)  NOT NULL,
    [Lastname]  VARCHAR (50)  NOT NULL,
    [Email]     VARCHAR (50)  NOT NULL,
    [Role]      BIT           NOT NULL,
    [SALT]      VARCHAR (1)   NOT NULL,
    [HashPsw]   VARBINARY (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_User] ASC)
);

