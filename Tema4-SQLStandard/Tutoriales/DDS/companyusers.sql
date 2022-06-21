create view companyusers
as
select c.idcompany, u.iduser, u.email, c.location from users u
inner join company c on u.idcompany = c.idcompany