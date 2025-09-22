CREATE TABLE Appointment(
	Appointment_ID INT IDENTITY (1,1) Primary key,
	Doctor_ID int,
	Patient_ID int,
	Date date,
	Appointment_Number int,
	Department varchar (100),
	Status varchar (100),
	Time time,
	Foreign key (Doctor_ID) references Doctor (Doctor_ID),
	Foreign key (Patient_ID) references Patient (Patient_ID)
	);
	INSERT INTO Appointment
	(Doctor_ID,Patient_ID,Date,Appointment_Number,Department,Status,Time)VALUES
	('1','1','2025-06-27','01','CLINIC','confirm','07:00:00'),
	('2','2','2025-06-28','02','CLINIC','confirm','07:00:00'),
	('3','3','2025-06-28','02','CLINIC','pending','08:30:00'),
	('4','4','2025-06-13','04','CLINIC','confirm','09:00:00'),
	('5','5','2025-07-02','05','CLINIC','cancelled','07:30:00')
SELECT * FROM Appointment


