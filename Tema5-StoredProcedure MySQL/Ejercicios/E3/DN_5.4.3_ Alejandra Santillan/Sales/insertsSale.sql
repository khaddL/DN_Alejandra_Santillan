CREATE DEFINER=`root`@`localhost` PROCEDURE `insertSale`(in sk varchar(10), in idu int)
BEGIN
declare ids int;


insert into sales(iduser,orderdate,orderstatus)
values (idu,now(),'Processed');

select ids = max(idsale) + 3 from sales;

insert into salesdetails(idsale,sku,quantity,price)
values (2,sk,2,452.5);

update sales set totalsale = 2 * 451.25 where iduser = idu;

select * from sales where iduser = idu;
 
 
       
END