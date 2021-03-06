  Select rat.RuleId as RuleId,r.name as RuleName, rt.name as RuleType,b.name as Business,p.name as Product, pt.name as ProducType,r.conditionsQuery as ConditionsQuery from RuleAppliesTo rat
  left outer JOIN Rules r
  ON r.id = rat.ruleid and r.isdeleted=0
  INNER JOIN RuleTypes rt
  ON r.RuleTypeId = rt.Id
  INNER JOIN Business b
  ON r.businessId = b.id
  Left Outer JOIN Products p
  ON p.id = rat.ProductId
  Left Outer JOIN ProductTypes pt
  ON pt.id = rat.ProductTypeId