SELECT 	dp.EnglishProductName
		,dp.Color
		,frs.OrderDate
		,dr.ResellerName
		,dr.BusinessType
		,dc.CurrencyName
		,dst.SalesTerritoryCountry
		,dst.SalesTerritoryRegion
		,dst.SalesTerritoryGroup
		,frs.SalesOrderNumber
		,frs.SalesOrderLineNumber
		,frs.RevisionNumber
		,frs.OrderQuantity
		,frs.UnitPrice
		,frs.ExtendedAmount
		,frs.UnitPriceDiscountPct
		,frs.DiscountAmount
		,frs.TotalProductCost
		,frs.SalesAmount
		,frs.TaxAmt
		,frs.Freight
FROM	AdventureWorksDW2017.dbo.FactResellerSales AS frs
		INNER JOIN AdventureWorksDW2017.dbo.DimProduct AS dp
			ON frs.ProductKey = dp.ProductKey
		INNER JOIN AdventureWorksDW2017.dbo.DimReseller AS dr
			ON frs.ResellerKey = dr.ResellerKey
		INNER JOIN AdventureWorksDW2017.dbo.DimCurrency AS dc
			ON frs.CurrencyKey = dc.CurrencyKey
		INNER JOIN AdventureWorksDW2017.dbo.DimSalesTerritory AS dst
			ON frs.SalesTerritoryKey = dst.SalesTerritoryKey
