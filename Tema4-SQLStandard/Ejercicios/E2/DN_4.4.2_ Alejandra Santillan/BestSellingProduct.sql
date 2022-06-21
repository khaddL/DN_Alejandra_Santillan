SELECT salesdetails.idorder,SUM(salesdetails.quantity) As SellingProduct, producttypes.name
FROM salesdetails
inner join inventory on inventory.idinventory = salesdetails.idinventory
inner join producttypes on producttypes.idproduct = inventory.idproduct
GROUP BY salesdetails.idorder
ORDER BY SUM(salesdetails.quantity)  DESC
limit 1
