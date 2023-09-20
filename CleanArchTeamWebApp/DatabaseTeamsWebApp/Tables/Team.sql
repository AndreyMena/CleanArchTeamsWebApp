CREATE TABLE [dbo].[Team]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(20) NULL, 
    [Region] NVARCHAR(20) NULL, 
    [Foundation] INT NULL,
)
