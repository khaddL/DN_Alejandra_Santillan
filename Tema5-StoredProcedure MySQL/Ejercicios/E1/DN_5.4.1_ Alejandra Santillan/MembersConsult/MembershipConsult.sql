delimiter //
create procedure MembersProcedure()
Begin
SELECT members.idmembers,members.name,members.registrationdate,membershiptypes.name
FROM members
join membershiptypes on membershiptypes.idmembershiptypes = members.idmembershiptypes
WHERE registrationdate between SUBDATE(curdate(),INTERVAL 1 week) and curdate() and dayofweek(registrationdate)=2;
end//
delimiter ;

call MembersProcedure();
