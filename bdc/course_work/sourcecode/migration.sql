/* MSSQL Syntax */
CREATE NONCLUSTERED INDEX IX_Password_BusinessEntityID_PasswordHash_PasswordSalt
    ON Person.Password (BusinessEntityID) INCLUDE(PasswordHash,PasswordSalt)  

/* Oracle Syntax */
CREATE NONCLUSTERED INDEX IX_Password_BusinessEntityID_PasswordHash_PasswordSalt
    ON Person.Password (BusinessEntityID,PasswordHash,PasswordSalt)  