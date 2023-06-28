CREATE TABLE [dbo].[Ticket_Statuses] (
    [Id_Status]  INT IDENTITY NOT NULL,
    [StatusCode] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Status] ASC)
);

