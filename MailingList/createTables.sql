create table Users (Email nvarchar(100) primary key,Password nvarchar(100) not null, Firstname nvarchar(30) not null, Lastname nvarchar(30) not null , 
	PhoneNumber nvarchar(14), RegisterDate date not null,Gender int not null, BirthDate date not null)


create table Groups (GroupId int primary key identity(1,1), GroupName nvarchar(100) not null,
	 Admin nvarchar(100) foreign key references Users(Email) on delete cascade,
	 CreateDate date not null)

create table Emails (EmailId int primary key identity(1,1), Sender nvarchar(100) foreign key references Users(Email),
	Subject nvarchar(100), Body nvarchar, Attachment varbinary(8000), CreateDate date not null, SendDate date )

create table Notifications( NotifId int primary key identity(1,1), Body nvarchar(200), Subject nvarchar(50), 
	CreateDate date not null, Receiver nvarchar(100) foreign key references Users(Email), SeenDate date)

--creating many to many relations

create table Group_Emails (GroupId int  foreign key references Groups(GroupId) , EmailId int foreign key references Emails(EmailId),
	Primary key(GroupId,EmailId))

create table Group_Users (UserEmail nvarchar(100) foreign key references Users(Email), GroupId int  foreign key references Groups(GroupId),
	RegisterDate date not null, ReceiveHTML bit not null, ReceiveSMS bit not null, Visible bit not null,
	Primary key(UserEmail,GroupId))

create table Email_Users (UserEmail nvarchar(100) foreign key references Users(Email), EmailId int foreign key references Emails(EmailId),
	ReceiveDate date , ReceiveSMS bit not null, ReceiveHTML bit not null, UnRead bit not null,
	Primary key(UserEmail,EmailId))


