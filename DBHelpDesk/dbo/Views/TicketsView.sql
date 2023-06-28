CREATE VIEW [dbo].[TicketsView]
	AS SELECT 
	
    T.Id,            
    T.Id_Type,      
    T.Id_User,      
    T.Id_Status,     
    T.Id_Settings,  
    T.Id_Details,    
    T.Id_Priorities
	
	FROM Tickets T

	JOIN Ticket_Details D ON T.Id_Details = D.Id_Details
    JOIN Ticket_Priorities P ON T.Id_Priorities = P.Id_Priorities
    JOIN Ticket_Settings S ON T.Id_Settings = S.Id_Settings
    JOIN Ticket_Statuses ST ON T.Id_Status = ST.Id_Status
    JOIN Ticket_Types TY ON T.Id_Status = TY.Id_Type

