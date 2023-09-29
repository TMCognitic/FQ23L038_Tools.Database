CREATE PROCEDURE [dbo].[CSP_AddContact]
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Anniversaire DATE
AS
BEGIN
	INSERT INTO Contact (Nom, Prenom, Anniversaire) VALUES (@Nom, @Prenom, @Anniversaire);
	RETURN 0
END
