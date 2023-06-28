CREATE PROCEDURE [dbo].[Ticket_Create]

	@Title VARCHAR(50),
	@Description VARCHAR(1000),
	@Attachment NVARCHAR(MAX),
	@TypeName VARCHAR(15),
	@StartDate DATETIME,
	@Id_User INT

AS

BEGIN 

DECLARE @Id_Ticket_Details INT
DECLARE @Id_Ticket_Type INT 
DECLARE @Id_Priorities INT = 4
DECLARE @Id_Settings INT = 1
DECLARE @Id_Status INT = 1

DECLARE @ID_Ticket INT 




INSERT INTO [dbo].[Ticket_Types]
(TypeName)

VALUES (@TypeName)

SET @Id_Ticket_Type = SCOPE_IDENTITY()

INSERT INTO [dbo].[Ticket_Details]
(Title, Description, Attachment, StartDate)

VALUES (

@Title,
@Description,
@Attachment,
@StartDate

)

SET @Id_Ticket_Details = SCOPE_IDENTITY()

 Insert INTO [dbo].[Tickets]
 (Id_Details, 
 Id_Priorities, 
 Id_Settings, 
 Id_Status, 
 Id_Type, 
 Id_User)
 
    
 VALUES (
 @Id_Ticket_Details, 
 @Id_Priorities,
 @Id_Settings,
 @Id_Status,
 @Id_Ticket_Type,
 @Id_User
 )
 
 SET @ID_Ticket = SCOPE_IDENTITY()

 SELECT Id, Title, [Description], StartDate FROM TicketView WHERE Id = @ID_Ticket

END 