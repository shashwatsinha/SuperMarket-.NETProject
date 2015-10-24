CREATE TABLE [dbo].[Inv]
(
	[product_id] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [product_name] NCHAR(10) NOT NULL UNIQUE, 
    [product_type] NCHAR(10) NOT NULL UNIQUE, 
    [product_cost] INT NOT NULL UNIQUE, 
    [product_stock] INT NOT NULL UNIQUE
)
