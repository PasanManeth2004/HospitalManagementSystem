CREATE TABLE TreatmentRecord (
	Record_ID INT IDENTITY(1,1)primary key,
	Treatments varchar (255),
	Date date,
	Doctor_ID int,
	Patient_ID int,
	Foreign key (Doctor_ID) references Doctor (Doctor_ID),
	Foreign key (Patient_ID) references Patient (Patient_ID)
	);
	INSERT INTO TreatmentRecord
	(Treatments,Date,Doctor_ID,Patient_ID)VALUES
	('Nitrates','2025-06-13','1','1'),
	('MRI/CT Scan','2025-06-20','7','2'),
    ('Pulse Oximetry','2025-06-28','8','7'),
	('Surgery','2025-06-30','6','10')

	SELECT * FROM  TreatmentRecord




