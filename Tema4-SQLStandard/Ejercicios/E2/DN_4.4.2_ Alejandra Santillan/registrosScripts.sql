insert into roles (idroles, rolname,permissions) values (1,'The Macho','Advanced :Access to all into the gym');
insert into roles (idroles, rolname,permissions) values (2,'The Thing','Beginner: Access limited');
insert into roles (idroles, rolname,permissions) values (3,'Pettit',': Childe: Access for kids');
insert into roles (idroles, rolname,permissions) values (4,'Le Mishi',': Only Girls: Access for Girls');
insert into roles (idroles, rolname,permissions) values (5,'Mamadisimooo','Coach: For all types');

insert into country (idcountry, name) values (1, 'United States');
insert into country (idcountry, name) values (2, 'Mexico');
insert into country (idcountry, name) values (3, 'Alemania');
insert into country (idcountry, name) values (4, 'Canada');
insert into country (idcountry, name) values (5, 'Cuba');

insert into cities (idcity, name,country_idcountry) values (1, 'Guadalajara', 2);
insert into cities (idcity, name,country_idcountry) values (2, 'Los Angeles', 1);
insert into cities (idcity, name,country_idcountry) values (3, 'Berlin', 3);
insert into cities (idcity, name,country_idcountry) values (4, 'Toronto', 4);
insert into cities (idcity, name,country_idcountry) values (5, 'La Habana', 5);

insert into membershiptypes (idmembershiptypes,name,cost,createdon,duration) values (1, 'Basic', 12.68,'2022-06-10 07:15:08', 1);
insert into membershiptypes (idmembershiptypes,name,cost,createdon,duration) values (2, 'Advanced', 130.86,'2022-06-10 07:15:10', 3);
insert into membershiptypes (idmembershiptypes,name,cost,createdon,duration) values (3, 'Premium', 200.15,'2022-06-10 07:13:00', 6);
insert into membershiptypes (idmembershiptypes,name,cost,createdon,duration) values (4, 'Children', 10.08,'2022-06-10 07:00:00', 1);
insert into membershiptypes (idmembershiptypes,name,cost,createdon,duration) values (5, 'Professional', 420.00,'2022-06-10 07:07:00', 12);

insert into members (idmembers,name,lastname,email,birthday,allownewsletter,idmembershiptypes, idcity) values (1,'Kate', 'Strong','katesst@gmail.com','2000-07-15',0,2,1);
insert into members (idmembers,name,lastname,email,birthday,allownewsletter,idmembershiptypes, idcity) values (2,'Montgomery','Freman','mntgom@gmail.com','1990-10-09',1,1,3);
insert into members (idmembers,name,lastname,email,birthday,allownewsletter,idmembershiptypes, idcity) values (3,'Pablo', 'Gomez','pablogz@gmail.com','1995-02-10',0,3,2);
insert into members (idmembers,name,lastname,email,birthday,allownewsletter,idmembershiptypes, idcity) values (4,'Caroline', 'Dree','carolree@gmail.com','2010-12-20',1,4,4);
insert into members (idmembers,name,lastname,email,birthday,allownewsletter,idmembershiptypes, idcity) values (5,'Willson', 'Grey','wilgry@gmail.com','1991-03-03',1,5,5);

insert into users (iduser,firstname,lastname,address,cities_idcity,email,phone,nickname,password) values (1,'Sarah','Martins','Vermont Vista W 108th St', 2, 'sarmt@gmail.com',6038012521, 'sarahM', 'lingthings');
insert into users (iduser,firstname,lastname,address,cities_idcity,email,phone,nickname,password) values (2,'Louis','Terrance','Schillerkiez Lichtenrader Str. 16A', 3, 'louter@gmail.com',2038501525, 'Loui', 'schrodnger');
insert into users (iduser,firstname,lastname,address,cities_idcity,email,phone,nickname,password) values (3,'Marco','Diaz','Jardines del Bosque Calz. Lázaro Cárdenas 2886', 1, 'mardi@gmail.com',3322551777, 'Marco', 'diazmarco1');
insert into users (iduser,firstname,lastname,address,cities_idcity,email,phone,nickname,password) values (4,'Sky','Voinroi','Ledbury Park 189 Haddington Ave', 4, 'skysky@gmail.com',4378863145, 'voisK', 'mapple');
insert into users (iduser,firstname,lastname,address,cities_idcity,email,phone,nickname,password) values (5,'Neil','Curtis','General Lacret Barbarita 115C', 5, 'neilcur@gmail.com',537856254, 'neilCur', 'habana');

insert into measuretype (idmeasuretype, measure) values (1, 'Pound');
insert into measuretype (idmeasuretype, measure) values (2, 'length');
insert into measuretype (idmeasuretype, measure) values (3, 'kilogram');
insert into measuretype (idmeasuretype, measure) values (4, 'height');
insert into measuretype (idmeasuretype, measure) values (5, 'volume');

insert into category (idcategory,category, description,idmeasuretype) values (1,'Supplements','Sports supplements are pills, powders, or drinks used to increase muscle, lose weight, or improve endurance.',3);
insert into category (idcategory,category, description,idmeasuretype) values (2,'Cardio','Platform that vibrates the entire body, which activates body flows, allowing their circulation more fluidly and allowing everything in our body to function correctly.',1);
insert into category (idcategory,category, description,idmeasuretype) values (3,'Bars and Discs','Bars and plates are great for targeting stabilizer muscles over major muscle groups',1);
insert into category (idcategory,category, description,idmeasuretype) values (4,'Dumbbells','The use of dumbbells provides you with many benefits by increasing the weight progressively in the loads, there is a wide variety of individual exercises with weights, it improves the integrity of the tendons, ligaments and joints, it favors fat loss.',1);
insert into category (idcategory,category, description,idmeasuretype) values (5,'Pews','Ideal support to perform your exercises in a more reliable and effective way.',3);

insert into equipmenttype (idequipment,name,type,description) values (1,'Multifunctional','Strength','Devices that serve as the basis for an effective gym routine.');
insert into equipmenttype (idequipment,name,type,description) values (2,'Integrated weights','Strength','Integrated tools with weight to work specific areas of the body.');
insert into equipmenttype (idequipment,name,type,description) values (3,'Handles','Strength','Additional tools to facilitate grip.');
insert into equipmenttype (idequipment,name,type,description) values (4,'Bikes','Spinning','Type of exercise bike that allows you to train both cardiovascular resistance and strength.');
insert into equipmenttype (idequipment,name,type,description) values (5,'Accessories','Gym components','Extra tools for multifunctional equipment, spinning, crossfit..');

insert into producttypes (idproduct,name,description,idequipment,category_idcategory) values (1,'Power Fitness Black Olympic Barc','Capacity 700 lbs',2,3);
insert into producttypes (idproduct,name,description,idequipment,category_idcategory) values (2,'Pair of discs Bumper','Weight 45lb',2,3);
insert into producttypes (idproduct,name,description,idequipment,category_idcategory) values (3,'Chest Bench','Declined Professional',1,5);
insert into producttypes (idproduct,name,description,idequipment,category_idcategory) values (4,'Pair Of Hex Dumbbells','Rubberized 03 Lbs',5,4);
insert into producttypes (idproduct,name,description,idequipment,category_idcategory) values (5,'Stages SC3','​Stages bikes feature a long-lasting, maintenance-free drivetrain',4,2);

insert into inventory (idinventory,sku,price,createdon,stock,idproduct) values (1,'ST0085993R',180.85,'2022-01-15 09:10:08',8,4);
insert into inventory (idinventory,sku,price,createdon,stock,idproduct) values (2,'DF8400245R',2250.90,'2022-01-15 11:25:08',4,1);
insert into inventory (idinventory,sku,price,createdon,stock,idproduct) values (3,'GG7784120R',11300.00,'2022-01-15 14:30:00',7,3);
insert into inventory (idinventory,sku,price,createdon,stock,idproduct) values (4,'DC8404951R',2780.75,'2022-01-15 11:55:02',6,2);
insert into inventory (idinventory,sku,price,createdon,stock,idproduct) values (5,'MT9561120R',53461.54,'2022-01-15 16:45:00',3,5);

insert into sales (idsale,iduser,ammount,shippingaddress,orderdate,orderstatus) values (1,2,5425.85,'Schillerkiez Lichtenrader Str. 16A','2022-07-03 11:55:02','Processed');
insert into sales (idsale,iduser,ammount,shippingaddress,orderdate,orderstatus) values (2,4,1115.96,'Ledbury Park 189 Haddington Ave','2022-10-14 15:12:00','Cancel');
insert into sales (idsale,iduser,ammount,shippingaddress,orderdate,orderstatus) values (3,1,15558.15,'Vermont Vista W 108th St','2022-07-03 23:55:41','On way');
insert into sales (idsale,iduser,ammount,shippingaddress,orderdate,orderstatus) values (4,3,1254.25,'Jardines del Bosque Calz. Lázaro Cárdenas 2886','2022-12-31 10:16:25','Processed');
insert into sales (idsale,iduser,ammount,shippingaddress,orderdate,orderstatus) values (5,5,1825.65,'Jardines hungaros Av.Plaza escondida 176','2022-11-13 06:12:50','Delivered');

insert into salesdetails (idorder,idinventory,quantity,price,sku,sales_idsale) values (1,2,2,5564.15,'001251A',1);
insert into salesdetails (idorder,idinventory,quantity,price,sku,sales_idsale) values (2,3,1,6541.25,'001253A',1);
insert into salesdetails (idorder,idinventory,quantity,price,sku,sales_idsale) values (3,1,1,9541.00,'000142A',4);
insert into salesdetails (idorder,idinventory,quantity,price,sku,sales_idsale) values (4,5,1,20054.4,'001445A',4);
insert into salesdetails (idorder,idinventory,quantity,price,sku,sales_idsale) values (5,4,1,1453.15,'001251A',3);

insert into usersinroles (idusersinroles,roles_idroles,users_iduser) values (1,1,2);
insert into usersinroles (idusersinroles,roles_idroles,users_iduser) values (2,3,1);
insert into usersinroles (idusersinroles,roles_idroles,users_iduser) values (3,4,5);
insert into usersinroles (idusersinroles,roles_idroles,users_iduser) values (4,5,3);
insert into usersinroles (idusersinroles,roles_idroles,users_iduser) values (5,2,4);
