insert into country(idcountry, name) values (1,'USA');
insert into country(idcountry, name) values (2,'Argentina');
insert into country(idcountry, name) values (3,'Colombia');
insert into country(idcountry, name) values (4,'Mexico');
insert into country(idcountry, name) values (5,'Cuba');

insert into company (idcompany, companyname, location) values (1, 'Company Test', 'Su');
insert into company (idcompany, companyname, location) values (2, 'Cece', 'No');
insert into company (idcompany, companyname, location) values (3, 'Teska', 'TM');

insert into users (iduser, username,email, idcompany) values (1, 'admin','admin@cece.com', 2);
insert into users (iduser, username,email, idcompany) values (2, 'admin','admin@test.com', 1);
insert into users (iduser, username,email, idcompany) values (3, 'admin','admin@tska.com', 3);

insert into city (idcity, name, idcountry) values (1, 'CDMX', 4);
insert into city (idcity, name, idcountry) values (2, 'Guadalajara', 4);
insert into city (idcity, name, idcountry) values (3, 'Monterrey', 4);

insert into city (idcity, name, idcountry) values (4, 'Los Angeles', 1);
insert into city (idcity, name, idcountry) values (5, 'New York', 1);
insert into city (idcity, name, idcountry) values (6, 'Washington DC', 1);

insert into city (idcity, name, idcountry) values (7, 'Buenos Aires', 2);

insert into city (idcity, name, idcountry) values (8, 'La Habana', 5);