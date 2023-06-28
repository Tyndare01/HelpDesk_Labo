CREATE TABLE [dbo].[Ticket_Details] (
    [Id_Details]  INT IDENTITY NOT NULL,
    [Title] VARCHAR (50) NOT NULL, 
    [Description] VARCHAR (500)  NULL,
    [StartDate]   DATETIME2 (7)  NULL,
    [EndDate]     DATETIME2 (7)  NULL,
    [Attachment]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Details] ASC)
);

