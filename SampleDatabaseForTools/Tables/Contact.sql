CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [Anniversaire] DATE NOT NULL, 
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]) 
)
