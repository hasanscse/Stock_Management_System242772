CREATE DATABASE CompanyUi

USE CompanyUi

CREATE TABLE Companys(
ID int IDENTITY (1,1),
CompanyName VARCHAR(100)
)

INSERT INTO Companys (CompanyName) VALUES ('Stationary')

SELECT * FROM Companys