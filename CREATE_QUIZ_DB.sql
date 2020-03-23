use master;
go

IF DB_ID('QuizDB')IS NULL
	CREATE DATABASE QuizDB
	GO

USE QuizDB
GO

IF OBJECT_ID('Player') IS NOT NULL
	DROP TABLE Player
	GO

IF OBJECT_ID('Results') IS NOT NULL
	DROP TABLE Results
	GO

IF OBJECT_ID('Questions') IS NOT NULL
	DROP TABLE Questions
	GO

CREATE TABLE Questions(
		qID INT PRIMARY KEY IDENTITY(0,1),
		questionTEXT NVARCHAR(250)
	)

CREATE TABLE Results(
		rID INT PRIMARY KEY IDENTITY(0,1),
		resultONE NVARCHAR(50),
		relultTWO NVARCHAR(50),
		resultTHREE NVARCHAR(50),
		trueRESULT NVARCHAR(50),
		qid int UNIQUE,
		CONSTRAINT fk_qid FOREIGN KEY (qid) REFERENCES Questions(qID)
	)

CREATE TABLE Player(
		pID INT PRIMARY KEY IDENTITY(0,1),
		playerNAME NVARCHAR(50),
		playerPUNKTE INT
	)

INSERT INTO Questions(questionTEXT) VALUES
	('Was sind die Vereinsfarben des 1. FC Saarbrückens?'),
	('Welches ist KEINE Programmiersprache?'),
	('Von welchem Entwicklerstudio wurde das Spiel "Skyrim" entwickelt?')

INSERT INTO Results(resultONE,relultTWO,resultTHREE,trueRESULT, qid) VALUES
	('Blau-Weiß', 'Schwarz-Weiß', 'Gelb', 'Blau-Schwarz',0),
	('Python', 'Ruby', 'Go', 'HTML',1),
	('Paradox', 'Ubisoft', 'Sega', 'Bethesda',2)