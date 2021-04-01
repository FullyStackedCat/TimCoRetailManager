CREATE PROCEDURE [dbo].[spSale_Lookup]
	@Cashierid nvarchar(128),
	@SaleDate datetime2
AS
begin
	set nocount on;

	select Id
	from dbo.Sale
	where CashierId = @Cashierid and SaleDate = @SaleDate
end
