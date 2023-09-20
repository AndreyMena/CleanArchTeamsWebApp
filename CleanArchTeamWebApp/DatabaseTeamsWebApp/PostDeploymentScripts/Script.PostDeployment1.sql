/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO Team AS TARGET
USING (VALUES
    (1, 'Deportivo Saprissa', 'CONCACAF', 1935),
    (2, 'Liga Deportiva Alajuelense', 'CONCACAF', 1919),
    (3, 'Club Sport Cartaginés', 'CONCACAF', 1906),
    (4, 'Club Sport Herediano', 'CONCACAF', 1921),
    (5, 'Associazione Calcio Milan', 'UEFA', 1899)
    )
AS SOURCE ([Id], [Name], [Region], [Foundation]) ON TARGET.[Id] = Source.[Id]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Id], [Name], [Region], [Foundation]) VALUES ([Id], [Name], [Region], [Foundation]);
