CREATE TABLE [dbo].[FootballTeam]
(
	[Id] INT NOT NULL,
	[StadiumName] VARCHAR(30) NULL,
	CONSTRAINT [PK_FootballTeam] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_FootbalTeam_Team] FOREIGN KEY 
    ([Id]) REFERENCES [Team]([Id])
)
