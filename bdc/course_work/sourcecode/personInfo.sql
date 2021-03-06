SELECT p.BusinessEntityID, 
       p.FirstName, 
       p.LastName, 
       ea.EmailAddress, 
       pwd.PasswordHash, 
       pwd.PasswordSalt, 
       phone.PhoneNumber, 
       phoneType.Name as PhoneType 
FROM   person.person p 
       INNER JOIN Person.Password pwd 
               ON p.BusinessEntityID = pwd.BusinessEntityID 
       INNER JOIN Person.emailaddress ea 
               ON p.BusinessEntityID = ea.BusinessEntityID 
       INNER JOIN Person.PersonPhone phone 
               ON p.BusinessEntityID = phone.BusinessEntityID 
       INNER JOIN Person.PhoneNumberType phoneType 
               ON phone.PhoneNumberTypeID = phoneType.PhoneNumberTypeID