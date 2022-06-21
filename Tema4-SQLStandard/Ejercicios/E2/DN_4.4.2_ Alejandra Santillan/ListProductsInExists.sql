create view ListProductsInExists
As
SELECT inventory.idinventory, producttypes.name As Product_Type, inventory.stock
FROM inventory
JOIN producttypes ON producttypes.idproduct = inventory.idproduct
WHERE 
inventory.stock > 1