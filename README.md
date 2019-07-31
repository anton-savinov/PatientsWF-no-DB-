# PatientsWF-no-DB-

WinForm, C#, Exception Handling, Streams, 

Simple Windows Form of Patients database with CRUD functions and Save/Load options to/from .txt and .bin. Database is not connected


!{}(https://github.com/anton-savinov/PatientsWF-no-DB-/blob/master/PatientDatabaseUI%20(WinForm%2C%20No%20DBConn).PNG)

+ Clear Form - Clears the form, all fields become empty
+ Fill Form - Fills the form with random data from the predefined lists (demontration purpose)
+ Add Patient - Retrieves data from fields, creates Patient object and adds this object to the list of Patiens
+ Save to .txt - Saves the list of patients into the .txt file
+ Save to .bin - Saves the list of patients into the .bin file
+ Load from .txt - Loads the list of patients from the .txt file
+ Save from .bin - Loads the list of patients from the .bin file
+ Sort - Sorts the list of patients based on checked condition (radiobutton)
+ Edit Patient - Opens new WinForm, allows to edit any property of the chosen patient
+ Delete Patient - Deletes chosen patient
+ Display All Patients - Displays all patients in the list
+ Delete All Patients - Deletes all patients in the list

![](https://github.com/anton-savinov/PatientsWF-no-DB-/blob/master/PatientDatabaseUI%20(WinForm%2C%20No%20DBConn)2.PNG)

+ Shows chosen patient for editing
+ Allows changing any patient`s property (SIN, FName, LName, Age)
+ Fields are enabled/disabled based on checked conditions (checkbuttons)
+ Save Changes - Changes edited property of the chosen patient in the list of patients
