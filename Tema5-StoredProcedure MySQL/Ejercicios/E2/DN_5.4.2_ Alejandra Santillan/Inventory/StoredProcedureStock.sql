delimiter //
create procedure products (in idp int)
begin
select producttypes.name , inventory.stock
from inventory
inner join producttypes on producttypes.idproduct = inventory.idproduct
where producttypes.idproduct like (idp);
end//
delimiter ;
