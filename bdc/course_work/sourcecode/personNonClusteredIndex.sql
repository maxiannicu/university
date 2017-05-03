CREATE NONCLUSTERED INDEX IX_Person_BusinessEntityID_FirstName_LastName  
    ON Person.Person (BusinessEntityID) INCLUDE(FirstName,LastName)  

CREATE NONCLUSTERED INDEX IX_Password_BusinessEntityID_PasswordHash_PasswordSalt
    ON Person.Password (BusinessEntityID) INCLUDE(PasswordHash,PasswordSalt)  

CREATE NONCLUSTERED INDEX IX_EmailAddress_BusinessEntityID
    ON Person.EmailAddress (BusinessEntityID) INCLUDE(EmailAddress)

CREATE NONCLUSTERED INDEX IX_PersonPhone_BusinessEntityID_PhoneNumberTypeId_PhoneNumber
    ON Person.PersonPhone (BusinessEntityID,PhoneNumberTypeId) INCLUDE(PhoneNumber)   

CREATE NONCLUSTERED INDEX IX_PhoneNumberType_BusinessEntityID_Name
    ON Person.PhoneNumberType (PhoneNumberTypeId) INCLUDE(Name)   
