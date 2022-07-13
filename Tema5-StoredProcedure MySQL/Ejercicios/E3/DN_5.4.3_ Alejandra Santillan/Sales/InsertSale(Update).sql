CREATE DEFINER=`root`@`localhost` PROCEDURE `insertSale`(in sk varchar(10), in idu int)
BEGIN
declare isd int;
declare pri float;
declare ts double;

insert into sales(iduser,orderdate,orderstatus)
values (idu,now(),'Processed');

select  max(sales.idsale) into isd from sales left join salesdetails on salesdetails.idsale = sales.idsale limit 1;

select  (inventory.price) into pri from inventory left join salesdetails on salesdetails.price = inventory.price where inventory.sku=sk limit 1;

insert into salesdetails(idsale,sku,quantity,price)
values (isd,sk,2,pri);



update sales  inner join salesdetails on salesdetails.idsale = sales.idsale set totalsale = totalforproduct where iduser=idu and orderdate = (SELECT MAX(orderdate));



END