CREATE TABLE [dbo].[Ticket_Settings] (
    [Id_Settings]  INT IDENTITY  NOT NULL,
    [Settings_Date] DATETIME2 (7) NOT NULL,
    [Settings_Name] VARCHAR(100) NOT NULL,

    [Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Settings] ASC),

    CONSTRAINT [FK_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Tickets] ([Id])
);

