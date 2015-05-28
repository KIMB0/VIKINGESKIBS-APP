CREATE DATABASE VikingeSkibsMuseet
GO

use VikingeSkibsMuseet;

CREATE TABLE Kunder(
     KundeID  int  NOT NULL PRIMARY KEY IDENTITY(1,1),
     Email      NvarChar(MAX)     NOT NULL,
     Navn   NvarChar(MAX)  NOT NULL,
	 Telefon NvarChar(MAX) NOT NULL
);

CREATE TABLE Priser(
	 PrisID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	 Pris money,
	 Gruppe NvarChar(MAX) NOT NULL
);

CREATE TABLE Billeter(
	 BilletID int  NOT NULL PRIMARY KEY IDENTITY(1,1),
	 KundeID int NOT NULL FOREIGN KEY REFERENCES Kunder(KundeID),
	 AntalBorn   int    NOT NULL,
	 AntalSuderende int NOT NULL,
     AntalVoksen  int    NOT NULL,
     Dato DATETIME NOT NULL,
     Pris money,
	 Sejltur bit
);

CREATE TABLE VikingeSkibe (
     VikingeSkibeID  int  NOT NULL PRIMARY KEY IDENTITY(1,1),
     Name      NvarChar(30)      NOT NULL,
     AntalPladser   int   NOT NULL,
	 Beskrivelse NvarChar(MAX)	NOT NULL,
	 YderligereInformationer NvarChar(MAX) NOT NULL,
	 Billede NvarChar(MAX) NOT NULL
);

GO
