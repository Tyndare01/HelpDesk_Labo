CREATE TABLE [dbo].[Ticket_Settings] (
    [Id_Settings]  INT IDENTITY  NOT NULL,
    [CreationDate] DATETIME2 (7) NULL,
    [UpdateDate]   DATETIME2 (7) NULL,
    [DeletionDate] DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id_Settings] ASC)
);

