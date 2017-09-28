 select p.id, p.PartNumber, p.Name, pt.Name as ProductTypeName, p.ToUtc as ExpirationDate, pl.Name as ProductLineName, plt.Name as ProductLineTypeName, prdprc.Euro as LstPriceEur, prdPrc.Dollar as LstPriceDollar, 
prdPrc.Pound as LstPricePound, prdPrc.AttachedDiscount, prdPrc.ChannelDiscount, prdprc.FromUtc, prdprc.ToUtc
 ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='ESC' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'ESC'
 ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='Royalties' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'Royalties'
 ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='Press inbound' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'Press inbound'
 ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='Local purchasing' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'Local purchasing'
  ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='Warranty direct' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'Warranty direct'
  ,(Select top(1) esc.Value from Costs esc inner join CostConcepts cc on cc.id = esc.CostConceptid and cc.name ='Warranty indirect' where esc.ProductId = p.id and esc.isdeleted = 0 and (esc.ToUtc is null OR  esc.ToUtc > GETUTCDATE()) 
 ) as 'Warranty indirect',
  ProductType = case when p.ProductTypeId = 1599 then 'Option Service Fee'---
                           when p.ProductTypeId = 1600 then 'Special Inks'-----
						   when p.ProductTypeId = 1601 then 'Printhead'
						   when p.ProductTypeId = 1602 then 'Clicks'------
						   when p.ProductTypeId = 1603 then 'Prepaid clicks'------
						   when p.ProductTypeId = 1604 then 'Entitlements'-----
						   when p.ProductTypeId = 1605 then 'Trade-in'-----
						   when p.ProductTypeId = 1606 then 'Specials'----
						   when p.ProductTypeId = 1607 then 'Promotion'---
						   when p.ProductTypeId = 1611 then 'Press' -----
						   when p.ProductTypeId > 1611 and p.ProductTypeId < 1664 then 'Press'
						   when p.ProductTypeId = 1664 then 'Services'---
						   when p.ProductTypeId > 1664 and p.ProductTypeId < 1744 then 'Services'
						   when p.ProductTypeId = 1744 then 'Workflow Solutions'----
						   when p.ProductTypeId > 1744 and p.ProductTypeId < 1762 then 'Workflow Solutions'
						   when p.ProductTypeId = 1762 then 'HW Options'----
						   when p.ProductTypeId > 1762 and p.ProductTypeId < 1815 then 'HW Options'----
						   when p.ProductTypeId = 1815 then 'Special fees'-----
						   when p.ProductTypeId > 1815 and p.ProductTypeId < 1818 then 'Prepaid clicks'
						   when p.ProductTypeId > 1817 and p.ProductTypeId < 1870 then 'Clicks'
						   when p.ProductTypeId = 1870 then 'Special colors'----
						   when p.ProductTypeId > 1870 and p.ProductTypeId < 1885 then 'Special colors'
						   when p.ProductTypeId = 1885 then 'Delivery, Installation & Rampup'-----
						   when p.ProductTypeId > 1885 and p.ProductTypeId < 1908 then 'Delivery, Installation & Rampup'
						   when p.ProductTypeId = 1908 then 'Promotions' ----
						   when p.ProductTypeId > 1908 and p.ProductTypeId < 1915 then 'Promotions'
						   when p.ProductTypeId > 1914 and p.ProductTypeId < 1918 then 'Delivery, Installation & Rampup'
						   when p.ProductTypeId > 1917 and p.ProductTypeId < 1947 then 'Press'
						   when p.ProductTypeId > 1951 and p.ProductTypeId < 1956 then 'Special fees'
						   when p.ProductTypeId > 2168 and p.ProductTypeId < 2186 then 'Services'
						   when p.ProductTypeId > 2185 and p.ProductTypeId < 2276 then 'Services'
	end,ProductTypeID = p.ProductTypeId,
	pt.Name as 'ProductName',
	IsWhite = case when p.ProductUse = 2 then 'Yes'---
                           when p.ProductUse = 1 then 'No'-----						   
	end
from Products p
inner join productTypes pt on pt.id = p.producttypeId and pt.isdeleted=0
inner join productLines pl on pl.id = p.productlineid and pl.isdeleted=0
inner join productLineTypes plt on plt.id = pl.ProductLinetypeId and plt.isdeleted=0
left outer join prices prdprc on prdPrc.Discriminator = 'PROD' and prdprc.productId = p.id and prdPrc.Isdeleted = 0 and (prdprc.ToUtc is null OR  prdprc.ToUtc > GETUTCDATE())
where p.isdeleted = 0