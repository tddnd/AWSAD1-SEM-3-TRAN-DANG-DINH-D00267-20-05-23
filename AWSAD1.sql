drop database AWSAD1
create database AWSAD1
go
use AWSAD1
go

CREATE TABLE [USER] (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50),
    Password NVARCHAR(50),
    GroupId NVARCHAR(50),
)

go

CREATE TABLE [LISTMAIL] (
    id INT IDENTITY(1,1) PRIMARY KEY,
    reciverName NVARCHAR(50),
    senderTitle NVARCHAR(50),
    senderContent NVARCHAR(50),
	senderDate NVARCHAR(50),
	isRead BIT,
	senderName NVARCHAR(50),
)

go

INSERT INTO [USER] (Username,Password,GroupId) OUTPUT inserted.id
VALUES('admin@gmail.com', '123qwe', null)

go

INSERT INTO [USER] (Username,Password,GroupId) OUTPUT inserted.id
VALUES('user1@gmail.com', '123qwe', null)

go

INSERT INTO [USER] (Username,Password,GroupId) OUTPUT inserted.id
VALUES('user2@gmail.com', '123qwe', null)