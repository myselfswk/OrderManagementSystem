CREATE PROCEDURE dbo.AddAssetUser
	@name nvarchar,
	@password nvarchar,
	@confirmpass nvarchar,
	@email nvarchar,
	@userId INT = NULL OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[RegisterUser] values(@name, @password, @confirmpass, @email)
	SET @userId = SCOPE_IDENTITY();

END
GO