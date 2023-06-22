CREATE TABLE [dbo].[Ticket_Details]
(
	[Id_Details] INT NOT NULL PRIMARY KEY,
	[Description] VARCHAR(500),
	[StartDate] DATETIME2,
	[EndDate] DATETIME2,
	[Attachment] NVARCHAR(MAX)
)
