SELECT p.ProductID,
	   p.name, 
       pc.name AS category, 
       p.standardcost 
FROM   production.product p 
       INNER JOIN production.productcategory pc 
               ON p.productsubcategoryid = pc.productcategoryid 
WHERE  p.productid = 760 