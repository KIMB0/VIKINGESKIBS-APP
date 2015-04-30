CREATE DATABASE VikingeSkibsMuseet
GO

use VikingeSkibsMuseet;

CREATE TABLE Kunder(
     KundeID  int  NOT NULL PRIMARY KEY IDENTITY(1,1),
     Email      NvarChar(MAX)     NOT NULL,
     Navn   NvarChar(MAX)  NOT NULL,
	 Telefon int NOT NULL
);

CREATE TABLE Billeter(
	 BilletID int  NOT NULL PRIMARY KEY IDENTITY(1,1),
	 KundeID int NOT NULL FOREIGN KEY REFERENCES Kunder(KundeID),
	 AntalBorn   int    NOT NULL,
     AntalVoksen  int    NOT NULL,
     Dato DATETIME NOT NULL,
     Price     FLOAT,
	 Sejltur bit
);

CREATE TABLE VikingeSkibe (
     VikingeSkibeID  int  NOT NULL PRIMARY KEY,
     Name      NvarChar(30)      NOT NULL,
     AntalPladser   int   NOT NULL
);

CREATE TABLE Booking(
     BookingID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	 KundeID  int   NOT NULL FOREIGN KEY REFERENCES Kunder(KundeID),
     BilletID  int   NOT NULL FOREIGN KEY REFERENCES Billeter(BilletID)
);

GO
