CREATE TABLE MedicalRecord(
	Medical_ID INT IDENTITY (1,1) primary key,
	Doctor_ID int,
	Patient_ID int,
	Date date,
	Note varchar (255),
	Diagnosis varchar (255),
	Prescription varchar (255),
	Department varchar (255),
	Foreign key (Doctor_ID) references Doctor (Doctor_ID),
	Foreign key (Patient_ID) references Patient (Patient_ID)
);
INSERT INTO MedicalRecord
(Doctor_ID,Patient_ID,Date,Note,Diagnosis,Prescription,Department)VALUES

('1','1','2025-06-13','Patient complains of chest pain','Angina','Aspirin 75mg daily','CLINIC'),
('7','2','2025-06-20','Patient experienced recurrent seizures','Epilepsy','Levetiracetam 500mg',' OPD'),
('8','7','2025-06-28','Child with presistent cought and fever','Bronchitis','Amoxicillin Syrup','OPD'),
('6','10','2025-06-30','Fractured leg after fall','Bone Fracture','Cast and Calcium Suppliments','ICU')

SELECT * FROM MedicalRecord
