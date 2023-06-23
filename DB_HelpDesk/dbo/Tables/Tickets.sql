CREATE TABLE [dbo].[Tickets]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Id_Type] INT,
	[Id_User] INT,
	[Id_Status] INT,
	[Id_Settings] INT,
	[Id_Details] INT,
	[Id_Priorities] INT,


	CONSTRAINT [FK_Id_Type] FOREIGN KEY ([Id_Type]) REFERENCES [dbo].[Ticket_Types] ([Id_Type]),
	CONSTRAINT [FK_Id_User] FOREIGN KEY ([Id_User]) REFERENCES [dbo].[Users] ([Id_User]),
	CONSTRAINT [FK_Id_Status] FOREIGN KEY ([Id_Status]) REFERENCES [dbo].[Ticket_Statuses] ([Id_Status]),
	CONSTRAINT [FK_Id_Settings] FOREIGN KEY ([Id_Settings]) REFERENCES [dbo].[Ticket_Settings] ([Id_Settings]),
	CONSTRAINT [FK_Id_Details] FOREIGN KEY ([Id_Details]) REFERENCES [dbo].[Ticket_Details] ([Id_Details]),
	CONSTRAINT [FK_Id_Priorities] FOREIGN KEY ([Id_Priorities]) REFERENCES [dbo].[Ticket_Priorities] ([Id_Priorities])
	
	


)
