CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateCompany`(in _companyName varchar(100),
in _location char(2), in _adminEmail varchar(500), in _userEmail varchar(500))
Begin

declare _companyId int;

select _companyId = max(idcompany) + 1 from company;
insert into company (idcompany, companyname, location)
values (_companyId, _companyName, _location);

END