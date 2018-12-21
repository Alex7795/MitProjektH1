CREATE DATABASE H1Project;

USE H1Project;

CREATE TABLE Cars (
ID INT PRIMARY KEY AUTO_INCREMENT,
CarName TEXT,
PackingSpace INT,
ComfortFront INT,
ComfortBack INT,
Acceleration INT,
TopSpeed INT,
GasTank INT,
Safety INT,
Handling INT,
CREATED DATETIME DEFAULT CURRENT_TIMESTAMP,
MODIFIED DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

INSERT INTO Cars(CarName, PackingSpace, ComfortFront, ComfortBack, Acceleration, TopSpeed, GasTank, Safety, Handling) 
VALUES('Kia', 75, 70, 60, 40, 40, 60, 75, 70);

INSERT INTO Cars(CarName, PackingSpace, ComfortFront, ComfortBack, Acceleration, TopSpeed, GasTank, Safety, Handling)
VALUES('Porsche', 20, 80, 20, 90, 100, 35, 45, 100);

INSERT INTO Cars(CarName, PackingSpace, ComfortFront, ComfortBack, Acceleration, TopSpeed, GasTank, Safety, Handling) 
VALUES('Tesla', 100, 80, 80, 95, 85, 100, 90, 45);