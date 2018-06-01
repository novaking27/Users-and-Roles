BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `users` (
	`userID`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`username`	TEXT NOT NULL UNIQUE,
	`password`	TEXT NOT NULL
);
INSERT INTO `users` VALUES (1,'dev','dev');
INSERT INTO `users` VALUES (2,'manager','manager');
INSERT INTO `users` VALUES (3,'staff','staff');
INSERT INTO `users` VALUES (4,'teacher','teacher');
INSERT INTO `users` VALUES (5,'student','student');

CREATE TABLE IF NOT EXISTS `roles` (
	`roleID`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`roleName`	TEXT NOT NULL UNIQUE
);
INSERT INTO `roles` VALUES (1,'developer');
INSERT INTO `roles` VALUES (2,'management');
INSERT INTO `roles` VALUES (3,'admin');
INSERT INTO `roles` VALUES (4,'teacher');
INSERT INTO `roles` VALUES (5,'student');


CREATE TABLE IF NOT EXISTS `user_roles` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`user`	INTEGER NOT NULL,
	`role`	INTEGER NOT NULL,
	FOREIGN KEY(`role`) REFERENCES `roles`(`roleID`),
	FOREIGN KEY(`user`) REFERENCES `users`(`userId`)
);
INSERT INTO `user_roles` VALUES (1,1,1);
INSERT INTO `user_roles` VALUES (2,2,2);
INSERT INTO `user_roles` VALUES (3,3,3);
INSERT INTO `user_roles` VALUES (4,4,4);
INSERT INTO `user_roles` VALUES (5,5,5);
INSERT INTO `user_roles` VALUES (6,1,2);
INSERT INTO `user_roles` VALUES (7,1,3);
INSERT INTO `user_roles` VALUES (8,1,4);
INSERT INTO `user_roles` VALUES (9,1,5);

CREATE VIEW userRolesView AS
SELECT userID, userName, roleID, roleName
FROM users
INNER JOIN user_roles ON user_roles.user = users.userID
INNER JOIN roles ON roles.roleID = user_roles.role;
COMMIT;
