Select pr.id as productid,o.name as Opportunity, o.Code as OPPId, o.CustomerName as Customer, cu.Name as Currency, q.name as ART, qs.name as Status,
 q.CreatedUtc as CreationDate, pt.name as ProductType,sr.Name as Subregion, g.name as GoToMarket, ct.Name as CustomerType, pr.name as Product,pr.PartNumber as PartNumber, 
 pri.Euro,pri.dollar,pri.Pound,--Prices de Products 
 Tiers.rangefrom, tiers.rangeto, pritier.Euro,pritier.dollar,pritier.Pound, --Prices de Tiers 
 ql.Value as ContractValue, pm.name as Promotion from quotelines ql
  INNER JOIN quotes q
  ON q.id = ql.quoteid
  INNER JOIN Opportunities o
  ON o.id = q.opportunityId
  LEFT JOIN SubRegions sr
  ON sr.Id = o.SubRegionId
  INNER JOIN Currencies cu
  ON cu.id = o.CurrencyId 
  INNER JOIN ProductTypes pt
  ON pt.id = o.ProductTypeId
  INNER JOIN quoteStatus qs
  ON qs.id = q.QuoteStatusId
  INNER JOIN gotomarket g
  ON g.id = o.GotoMarketId
  LEFT JOIN CustomerTypes ct
  ON ct.id = o.CustomerTypeId   
  INNER JOIN Products pr
  ON pr.id = ql.ProductId
  LEFT JOIN Prices pri
  ON ql.ProductId = pri.ProductId and pri.ToUtc is null
  LEFT JOIN Tiers
  ON Tiers.QuoteId is null and tiers.ProductId = ql.ProductId
  LEFT JOIN Prices pritier
  ON Tiers.id = pritier.tierId and pritier.ToUtc is null
  FULL OUTER JOIN Promotions pm
  ON pm.id = ql.PromotionId
  where ((q.isdeleted=0) and (o.isdeleted=0) and (ql.isdeleted=0) and (q.EditingQuoteId is null))
  order by ql.QuoteId asc  