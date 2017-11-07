CREATE TABLE [dbo].[Movies]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NULL, 
    [ReleaseDate] DATETIME NULL, 
    [Genre] NCHAR(50) NULL, 
    [Price] MONEY NULL
)
