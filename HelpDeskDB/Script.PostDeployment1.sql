/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


INSERT INTO Ticket_Priorities([Level]) VALUES 
('Low'),('Medium'),('High'),('Undefined')


INSERT INTO Ticket_Statuses(StatusCode) VALUES
('OpenTicket'),('AssignedTicket'), ('PendingTicket'), ('CloseTicket')

INSERT INTO Ticket_Types(TypeName) VALUES
('Technical'), ('Functionnal'), ('CrashReport'), ('Internet'), ('Other')  

EXEC User_Register

'lecomtejason@gmail.com',
'Jason',
'Lecomte',
'Test1234=',
'Admin'

GO

EXEC Ticket_Create 
'Probleme connexion messagerie',
'Big issue',
'MonBeauFichier',
'Technical',
'2020-08-21',
'1'

GO

