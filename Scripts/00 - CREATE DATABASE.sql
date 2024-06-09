CREATE DATABASE ForLife;
GO

USE ForLife;
GO

CREATE LOGIN userForLifeDB WITH PASSWORD = 'F0rL!f&DB';
GO

CREATE USER userForLifeDB FOR LOGIN userForLifeDB;
GO

EXEC sp_addrolemember 'db_owner', 'userForLifeDB';
GO

GRANT SELECT ON SCHEMA :: dbo TO userForLifeDB;
GRANT INSERT ON SCHEMA :: dbo TO userForLifeDB;
GRANT UPDATE ON SCHEMA :: dbo TO userForLifeDB;
GRANT DELETE ON SCHEMA :: dbo TO userForLifeDB;
