CREATE PROCEDURE dbo.AddAssetOrder
	@orderDate datetime,
	@customerID int,
	@OrderId INT = NULL OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Order] values(@orderDate, @customerID)
	SET @OrderId = SCOPE_IDENTITY();

END
GO