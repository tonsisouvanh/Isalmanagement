--Them hoa don moi
create PROC usp_ThemHoaDon @SalesOrderID int,
							@RevisionNumber tinyint,
							@DueDate datetime,
							@ShipDate datetime,
							@Status tinyint,
							@OnlineOrderFlag bit,
							@PurchaseOrderNumber nvarchar(25),
							@AccountNumber nvarchar(15), 
							@CustomerID int,
							@SalesPersonID int,
							@TerritoryID int,
							@BillToAddressID int,
							@ShipToAddressID int, 
							@ShipMethodID int,
							@CreditCardID int,
							@CreditCardApprovalCode varchar(15),
							@CurrencyRateID int,
							@SubTotal money,
							@TaxAmt money, 
							@Freight money,
							@Comment nvarchar(128)
AS
BEGIN
		declare @OrderDate datetime
		set @OrderDate = GETDATE()

		declare @saleOdrID nvarchar(20)
		set @saleOdrID = CONVERT(nvarchar(20),@SalesOrderID)

		declare @SalesOrderNumber varchar(20)
		set @SalesOrderNumber = isnull(N'SO'+@saleOdrID, N'*** ERROR ***')

		declare @TotalDue money
		set @totalDue = isnull(@SubTotal+@TaxAmt+@Freight,(0))

		declare @rowguid uniqueidentifier
		set @rowguid = newid()

		declare  @ModifiedDate datetime
		set @ModifiedDate = GETDATE()

		insert into n_SalesOrderHeader(SalesOrderID,RevisionNumber, OrderDate, DueDate, ShipDate,Status, 
										OnlineOrderFlag ,SalesOrderNumber, PurchaseOrderNumber, AccountNumber,
										CustomerID, SalesPersonID, TerritoryID, BillToAddressID,
										ShipToAddressID,ShipMethodID,CreditCardID,
										CreditCardApprovalCode,CurrencyRateID,SubTotal,
										TaxAmt,Freight,TotalDue,Comment,rowguid, ModifiedDate)
		values( @SalesOrderID,@RevisionNumber, @OrderDate, @DueDate,
				@ShipDate,@Status,@OnlineOrderFlag,@SalesOrderNumber,
				@PurchaseOrderNumber , @AccountNumber , @CustomerID ,@SalesPersonID ,
				@TerritoryID ,@BillToAddressID , @ShipToAddressID , @ShipMethodID , @CreditCardID , 
				@CreditCardApprovalCode ,@CurrencyRateID, @SubTotal,@TaxAmt , @Freight ,
				@TotalDue , @Comment, @rowguid , @ModifiedDate)
END
GO	

--Them chi tiet hoa don
create proc usp_ThemHoaDonCT	@SalesOrderID int, 
								@SalesOrderDetailID int, 
								@CarrierTrackingNumber nvarchar(25),
								@OrderQty smallint, 
								@ProductID int,
								@SpecialOfferID int, 
								@UnitPrice money,
								@UnitPriceDiscount int
as
begin

	declare @LineTotal decimal(18,0)
	set @LineTotal = isnull(@UnitPrice * (1-@UnitPriceDiscount) * @OrderQty,0.0)

	declare @rowguid uniqueidentifier
	set @rowguid = newid()

	declare @ModifiedDate datetime
	set @ModifiedDate = GETDATE()

	insert into n_SalesOrderDetail(SalesOrderID, SalesOrderDetailID, CarrierTrackingNumber, 
									OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, 
									LineTotal, rowguid, ModifiedDate)
	values(@SalesOrderID,@SalesOrderDetailID, @CarrierTrackingNumber,
			@OrderQty, @ProductID,@SpecialOfferID, @UnitPrice,
			@UnitPriceDiscount, @LineTotal, @rowguid, @ModifiedDate)
end

--Them khach hang
create proc usp_ThemCustomer @CustomerID int,
							 @PersonID int,
							 @StoreID int,
							 @TerritoryID int
as
begin

	declare @AccountNumber varchar(20)
	set @AccountNumber = isnull('AW'+cast(@CustomerID as varchar(20)),'')

	declare @rowguid uniqueidentifier
	set @rowguid = newid()

	declare @ModifiedDate datetime
	set @ModifiedDate = GETDATE()

	insert into n_Customer(CustomerID, PersonID, StoreID,TerritoryID,AccountNumber,rowguid,ModifiedDate )
	values(@CustomerID, @PersonID,@StoreID,@TerritoryID, @AccountNumber, @rowguid, @ModifiedDate)
end

CREATE PROCEDURE usp_TimKiemHoaDon @personID int,@tu datetime,@den datetime
AS
BEGIN
	IF (NOT EXISTS (SELECT PersonID FROM n_Customer where PersonID = @personID))
	BEGIN
		ROLLBACK TRAN
		RETURN
	END
	IF (@tu > @den)
	BEGIN
		ROLLBACK TRAN
		RETURN
	END


	select s.SalesOrderID, s.RevisionNumber, s.OrderDate, s.DueDate, s.ShipDate, s.Status, 
										s.OnlineOrderFlag, s.SalesOrderNumber, s.PurchaseOrderNumber, s.AccountNumber,
										s.CustomerID, s.SalesPersonID, s.TerritoryID, s.BillToAddressID,
										s.ShipToAddressID,s.ShipMethodID,s.CreditCardID,s.CreditCardApprovalCode,s.CurrencyRateID, s.SubTotal,
										s.TaxAmt,s.Freight,s.TotalDue,s.Comment,s.rowguid, s.ModifiedDate
	from n_SalesOrderHeader s inner join n_Customer c on c.CustomerID = s.CustomerID
	where c.PersonID = @personID and s.OrderDate between @tu and @den
END

--trigger xoa hoa don
CREATE TRIGGER ustr_XoaHoaDon on n_SalesOrderHeader for delete
as
begin
	print N'Không cho phép xóa hóa đơn'
	rollback tran
end
--trigger xoa chi tiet hoa don
CREATE TRIGGER ustr_XoaHoaDonCT on n_SalesOrderDetail for delete
as
begin
	print N'Không cho phép xóa hóa đơn chi tiết'
	rollback tran
end
