CREATE TABLE [dbo].[Ticket_Details] (
    [Id_Details]  INT            NOT NULL,
    [Description] VARCHAR (500)  NULL,
    [StartDate]   DATETIME2 (7)  NULL,
    [EndDate]     DATETIME2 (7)  NULL,
    [Attachment]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Details] ASC)
);

