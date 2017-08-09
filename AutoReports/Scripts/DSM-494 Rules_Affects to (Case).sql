Select  r.id as RuleId,r.name as RuleName, rt.name as RuleType, b.name as business, p.name as Product, pt.name as ProductType, pr.name as Promotion, rah.Name as Relationship, r.ConditionsQuery as ConditionQuery,
ConditionType = case when rct.RuleConditionType = 1 then 'GTM' 
                     when rct.RuleConditionType = 2 then 'CustomerType' 
					 when rct.RuleConditionType = 3 then 'DealType' 
					 when rct.RuleConditionType = 4 then 'SubRegion' 
					 when rct.RuleConditionType = 5 then 'PaymentMethod' 
					 when rct.RuleConditionType = 0 then 'None'end ,
ValueType = case when rct.Value = 0 then (case when rct.RuleConditionType = 0 then 'N/A' end)
				 when rct.Value = 1 then (case when rct.RuleConditionType = 1 then 'Direct' when rct.RuleConditionType = 2 then 'Net New' when rct.RuleConditionType = 3 then 'Press' end) 
                 when rct.value = 2 then (case when rct.RuleConditionType = 1 then 'Channel' when rct.RuleConditionType = 2 then 'Existing' when rct.RuleConditionType = 3 then 'Options' end)
				 when rct.value = 3 then (case when rct.RuleConditionType = 2 then 'New to series' end)
				 when rct.value = 38 then (case when rct.RuleConditionType = 4 then 'Iberia' end)
				 when rct.value = 39 then (case when rct.RuleConditionType = 4 then 'CEE' end)
				 when rct.value = 41 then (case when rct.RuleConditionType = 4 then 'DACH' end)
				 when rct.value = 42 then (case when rct.RuleConditionType = 4 then 'France' end)
				 when rct.value = 43 then (case when rct.RuleConditionType = 4 then 'Italy' end)
				 when rct.value = 44 then (case when rct.RuleConditionType = 4 then 'MEMA' end)
				 when rct.value = 45 then (case when rct.RuleConditionType = 4 then 'Northern' end)
				 when rct.value = 46 then (case when rct.RuleConditionType = 4 then 'UK&I' end)  end, rct.PositionId as Position,			 
				 r.ToUtc as RuleToUtc

from RuleAffectsTo raft 
INNER JOIN Rules r
ON r.id = raft.RuleId
INNER JOIN RuleTypes rt
ON r.RuleTypeId = rt.Id
INNER  JOIN Business b
ON b.id= r.BusinessId
FULL OUTER JOIN Products p
ON p.id = raft.ProductId
FULL OUTER JOIN ProductTypes pt
ON pt.id = raft.ProductTypeId
INNER JOIN RuleAffectsHow rah
ON rah.id = raft.RuleAffectsHowId
FULL OUTER JOIN Promotions pr
ON pr.id = PromotionId
Left JOIN RuleConditionGroups rcg
ON rcg.RuleId = raft.RuleId
Left JOIN RuleConditions rct
ON rct.RuleConditionGroupId = rcg.id 

where raft.IsDeleted = 0 and r.IsDeleted=0 




