CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllUsers`()
BEGIN
	select * from users;
END