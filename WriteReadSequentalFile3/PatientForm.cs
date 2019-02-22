using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteReadSequentalFile3
{
    public partial class PatientForm : Form
    {
        public static Patient patientForEdit;
        Patient newPatient;
        public static List<Patient> listOfPatient = new List<Patient>();
        string[] anyFirstName = { "Anton", "Mark", "John", "Liza" };
        string[] anyLastName = { "Savinov", "Smith", "Wong", "Raj" };
        Random randomGenerator = new Random();
        FileStream outfile;
        FileStream infile;
        StreamWriter writer;
        StreamReader reader;
        BinaryFormatter binaryFormatter;
        public static char DELIM = '|';
        string recordLine;
        string[] patientRecord;
        ToolTip ToolTip1;

        public PatientForm()
        {
            InitializeComponent();
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            sinTextBox.Text = (randomGenerator.Next(1, 10)).ToString();
            fNameTextBox.Text = anyFirstName[randomGenerator.Next(anyFirstName.Length)];
            lNameTextBox.Text = anyLastName[randomGenerator.Next(anyLastName.Length)];
            ageTextBox.Text = (randomGenerator.Next(18, 100)).ToString();
        }

        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string exceptionMessage = "";
            if (CheckEmptyfields(sinTextBox.Text, fNameTextBox.Text,
                    lNameTextBox.Text, ageTextBox.Text, ref exceptionMessage))
            {
                if (CheckDataType(sinTextBox.Text, fNameTextBox.Text,
                       lNameTextBox.Text, ageTextBox.Text, ref exceptionMessage))
                    throw new Exception(exceptionMessage);
                else
                    throw new Exception(exceptionMessage);
            }
            else
            {
                if (!(CheckUniqueSIN(sinTextBox.Text)))
                {
                    throw new Exception($"Patient with SIN {sinTextBox.Text} is already exist in the list\nSIN must be unique");
                }
                newPatient = new Patient(Convert.ToInt32(sinTextBox.Text), fNameTextBox.Text,
                    lNameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
                listOfPatient.Add(newPatient);
                DisplayAllListBox.Items.Add(newPatient);
            }
        }

        void ClearForm()
        {
            sinTextBox.Text = null;
            fNameTextBox.Text = null;
            lNameTextBox.Text = null;
            ageTextBox.Text = null;
        }

        bool CheckDataType(string f1, string f2, string f3, string f4, ref string exceptionMessage)
        {
            Boolean Exception = false;
            if (!(Int32.TryParse(f1, out int intNumber1)) && f1 != "")
            {
                exceptionMessage += "SIN must be whole number\n";
                Exception = true;
            }
            if (!(f2.All(Char.IsLetter)))
            {
                exceptionMessage += "First Name must be letters only";
                Exception = true;
            }
            if ((!f3.All(Char.IsLetter)))
            {
                exceptionMessage += "Last Name must be letters only";
                Exception = true;
            }
            if (!(Int32.TryParse(f4, out int intNumber2)) && f4 != "")
            {
                exceptionMessage += "Age must be whole number\n";
                Exception = true;
            }
            return Exception;
        }

        bool CheckEmptyfields(string f1, string f2, string f3, string f4, ref string exceptionMessage)
        {
            Boolean Exception = false;
            exceptionMessage = "";
            if (f1 == "")
            {
                exceptionMessage += "Enter SIN\n";
                Exception = true;
            }
            if (f2 == "")
            {
                exceptionMessage += "Enter First Name\n";
                Exception = true;
            }
            if (f3 == "")
            {
                exceptionMessage += "Enter Last Name\n";
                Exception = true;
            }
            if (f4 == "")
            {
                exceptionMessage += "Enter Age\n";
                Exception = true;
            }
            return Exception;
        }

        bool CheckUniqueSIN(string ssn)
        {
            bool uniqueSIN = true;
            foreach (var item in listOfPatient)
            {
                if (listOfPatient.Any(pp => pp.SIN == Convert.ToInt32(ssn)))
                {
                    uniqueSIN = false;
                }
            }
            return uniqueSIN;
        }

        void CheckIsListEmpty()
        {
            if (DisplayAllListBox.Items.Count == 0)
            {
                throw new Exception("List of patients is empty\nPlease Add a new Patient");
            }
        }

        void CheckRadioBtnsChoice()
        {
            if (!sinRadioBtn.Checked && !fNameRadioBtn.Checked && !lNameRadioBtn.Checked && !ageRadioBtn.Checked)
            {
                throw new Exception("Choose the condition to Sort");
            }
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            CheckIsListEmpty();
            DisplayAllListBox.Items.Clear();
            DisplayPatientsInListBoxArea(listOfPatient);
            displayAllBtn.Text = "Display All";
        }

        private void deleteAllPatsBtn_Click(object sender, EventArgs e)
        {
            DisplayAllListBox.Items.Clear();
            listOfPatient.Clear();
        }

        private void deletePatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listOfPatient.Remove(listOfPatient[DisplayAllListBox.SelectedIndex]);
                DisplayAllListBox.Items.Remove(DisplayAllListBox.SelectedItem);
            }
            catch (Exception)
            {
                throw new Exception("Select the patient to Delete");
            }
        }

        private void sortBySINBtn_Click(object sender, EventArgs e)
        {
            CheckIsListEmpty();
            CheckRadioBtnsChoice();
            DisplayAllListBox.Items.Clear();
            if (sinRadioBtn.Checked)
            {
                listOfPatient.Sort(delegate (Patient x, Patient y)
                                {
                                    if (x.SIN == null && y.SIN == null) return 0;
                                    else if (x.SIN == null) return -1;
                                    else if (y.SIN == null) return 1;
                                    else return x.SIN.CompareTo(y.SIN);
                                });
            }

            if (ageRadioBtn.Checked)
            {
                listOfPatient.Sort(delegate (Patient x, Patient y)
                {
                    if (x.Age == null && y.Age == null) return 0;
                    else if (x.Age == null) return -1;
                    else if (y.Age == null) return 1;
                    else return x.Age.CompareTo(y.Age);
                });
            }

            if (lNameRadioBtn.Checked)
            {
                listOfPatient.Sort(delegate (Patient x, Patient y)
                {
                    if (x.LastName == null && y.LastName == null) return 0;
                    else if (x.LastName == null) return -1;
                    else if (y.LastName == null) return 1;
                    else return x.LastName.CompareTo(y.LastName);
                });
            }

            if (fNameRadioBtn.Checked)
            {
                listOfPatient.Sort(delegate (Patient x, Patient y)
                {
                    if (x.FirstName == null && y.FirstName == null) return 0;
                    else if (x.FirstName == null) return -1;
                    else if (y.FirstName == null) return 1;
                    else return x.FirstName.CompareTo(y.FirstName);
                });
            }
            DisplayPatientsInListBoxArea(listOfPatient);
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                patientForEdit = listOfPatient[DisplayAllListBox.SelectedIndex];
                EditPatientForm newPatientForm = new EditPatientForm();
                newPatientForm.Show();
                displayAllBtn.Text = "Refresh the list";
            }
            catch (Exception)
            {
                throw new Exception("Select the patient to Edit");
            }
        }

        private void saveTXTBtn_Click(object sender, EventArgs e)
        {
            CheckIsListEmpty();
            outfile = new FileStream("ListOfPatients.txt", FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(outfile);
            foreach (var item in listOfPatient)
            {
                writer.WriteLine($"{item.SIN}{DELIM}{item.FirstName}{DELIM}{item.LastName}{DELIM}{item.Age}");
            }
            writer.Close();
            outfile.Close();
            DisplayAllListBox.Items.Clear();
            loadTXTBtn.Text = "Load current list from .txt";
        }

        private void loadTXTBtn_Click(object sender, EventArgs e)
        {
            DisplayAllListBox.Items.Clear();
            infile = new FileStream("ListOfPatients.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(infile);
            listOfPatient = new List<Patient>();
            recordLine = reader.ReadLine();
            while (recordLine != null)
            {
                patientRecord = recordLine.Split(DELIM);
                newPatient = new Patient(Convert.ToInt32(patientRecord[0]), patientRecord[1], patientRecord[2], Convert.ToInt32(patientRecord[3]));
                listOfPatient.Add(newPatient);
                recordLine = reader.ReadLine();
            }
            DisplayPatientsInListBoxArea(listOfPatient);
            reader.Close();
            infile.Close();
        }

        private void saveXMLBtn_Click(object sender, EventArgs e)
        {
            CheckIsListEmpty();
            outfile = new FileStream("ListOfPatients.bin", FileMode.Create, FileAccess.Write);
            binaryFormatter = new BinaryFormatter();
            foreach (var item in listOfPatient)
            {
                binaryFormatter.Serialize(outfile, item);
            }
            DisplayAllListBox.Items.Clear();
            outfile.Close();
            loadBINBtn.Text = "Load current list from .bin";
        }

        private void loadXMLBtn_Click(object sender, EventArgs e)
        {
            DisplayAllListBox.Items.Clear();
            listOfPatient = new List<Patient>();
            infile = new FileStream("ListOfPatients.bin", FileMode.Open, FileAccess.Read);
            binaryFormatter = new BinaryFormatter();
            while (infile.Position < infile.Length)
            {
                newPatient = (Patient)binaryFormatter.Deserialize(infile);
                listOfPatient.Add(newPatient);
            }
            DisplayPatientsInListBoxArea(listOfPatient);
            infile.Close();
        }

        void DisplayPatientsInListBoxArea(List<Patient> listOfPatient)
        {
            foreach (var item in listOfPatient)
            {
                DisplayAllListBox.Items.Add(item + "\n\n");
            }
        }

        private void fillBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(fillBtn, "Fills the form with random data");
        }

        private void addBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(addBtn, "Add Patient to the list");
        }

        private void clearFormBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(clearFormBtn, "Clears all fields of the form");
        }

        private void saveTXTBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(saveTXTBtn, "Save the list of the patients in the .txt file");
        }

        private void saveBINBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(saveBINBtn, "Save the list of the patients in the .bin file");
        }

        private void loadTXTBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(loadTXTBtn, "Load the list of the patients from the .txt file");
        }

        private void loadBINBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(loadBINBtn, "Load the list of the patients from the .bin file");
        }

        private void sortByBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(sortByBtn, "Choose the condition on left side to sort the list");
        }

        private void editPatientBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(editPatientBtn, "Choose patient from the list to edit information");
        }

        private void deletePatientBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(deletePatientBtn, "Choose patient from the list to delete");
        }

        private void deleteAllPatsBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(deleteAllPatsBtn, "Deletes all patients from the list");
        }

        private void displayAllBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(displayAllBtn, "Click to display or refresh the list");
        }
    }
}
