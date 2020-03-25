-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================
ALTER PROCEDURE spAddCustomer
(
    -- Add the parameters for the stored procedure here
     @FullName NVARCHAR(100)='demo',
    @orderid int=1
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Insert statements for procedure here
   INSERT INTO Customer(FullName,orderid )
    VALUES ('Alliance',1)  
END
GO
