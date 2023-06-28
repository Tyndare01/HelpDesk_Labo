CREATE VIEW [dbo].[TicketView]
	AS SELECT  

	T.Id,
	D.Title,
	D.Description,
	D.Attachment,
	D.StartDate,
	P.Level,
	S.CreationDate,
	S.UpdateDate,
	S.DeletionDate,
	ST.StatusCode,
	TY.TypeName


	

	FROM Tickets T

	JOIN Ticket_Details D ON T.Id_Details = D.Id_Details
	JOIN Ticket_Priorities P ON T.Id_Priorities = P.Id_Priorities
	JOIN Ticket_Settings S ON T.Id_Settings = S.Id_Settings
	JOIN Ticket_Statuses ST ON T.Id_Status = ST.Id_Status
	JOIN Ticket_Types TY ON T.Id_Type = TY.Id_Type 

