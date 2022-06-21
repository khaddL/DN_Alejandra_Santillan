create view UsersAndRoles
As
SELECT usersinroles.idUsersInRoles , users.firstname , roles.rolname  
FROM usersinroles
JOIN roles ON roles.idroles = usersinroles.Roles_idroles
JOIN users ON users.iduser = usersinroles.Users_iduser