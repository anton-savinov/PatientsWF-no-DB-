using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteReadSequentalFile3
{
    public partial class EditPatientForm : Form
    {
        public EditPatientForm()
        {
            InitializeComponent();
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            sinFormDisplayLbl.Text = PatientForm.patientForEdit.SIN.ToString();
            fNameFormDisplayLbl.Text = PatientForm.patientForEdit.FirstName;
            lNameFormDisplayLbl.Text = PatientForm.patientForEdit.LastName;
            ageFormDisplayLbl.Text = PatientForm.patientForEdit.Age.ToString();
        }
        //DisabledTextboxesForEdit() disables all textboxes, user is not able to fill any textbox
        void DisabledTextboxesForEdit(TextBox input)
        {
            input.Text = null;
            input.ReadOnly = true;
        }
        //savePatientFormBtn_Click() saves Patient in the list after editing
        //checks what Patient`s property was choosen to edit
        //shows error message
        private void savePatientFormBtn_Click(object sender, EventArgs e)
        {
            //checking if none of the Patients properties was choosen
            if (!sinFormCheckBox.Checked && !lNameFormCheckBox.Checked && !fNameFormCheckBox.Checked && !ageFormCheckBox.Checked)
            {
                throw new Exception("Choose field to edit, then enter a value");
            }
            //editing SIN property
            if (sinFormCheckBox.Checked)
            {
                if (sinFormEditTxtBox.Text != "")
                {
                    PatientForm.patientForEdit.SIN = Convert.ToInt32(sinFormEditTxtBox.Text);
                    sinFormDisplayLbl.Text = PatientForm.patientForEdit.SIN.ToString();
                    sinFormCheckBox.Checked = false;
                    DisabledTextboxesForEdit(sinFormEditTxtBox);
                }
                else
                    ThrowException("SIN");
            }
            //editing first name property
            if (fNameFormCheckBox.Checked)
            {
                if (fNameFormEditTxtBox.Text != "")
                {
                    PatientForm.patientForEdit.FirstName = fNameFormEditTxtBox.Text;
                    fNameFormDisplayLbl.Text = PatientForm.patientForEdit.FirstName;
                    fNameFormCheckBox.Checked = false;
                    DisabledTextboxesForEdit(fNameFormEditTxtBox);
                }
                else
                    ThrowException("First Name");
            }
            //checking last name property
            if (lNameFormCheckBox.Checked)
            {
                if (lNameFormEditTxtBox.Text != "")
                {
                    PatientForm.patientForEdit.LastName = lNameFormEditTxtBox.Text;
                    lNameFormDisplayLbl.Text = PatientForm.patientForEdit.LastName;
                    lNameFormCheckBox.Checked = false;
                    DisabledTextboxesForEdit(lNameFormEditTxtBox);
                }
                else
                    ThrowException("Last Name");
            }
            //checking age property
            if (ageFormCheckBox.Checked)
            {
                if (ageFormEditTxtBox.Text != "")
                {
                    PatientForm.patientForEdit.Age = Convert.ToInt32(ageFormEditTxtBox.Text);
                    ageFormDisplayLbl.Text = PatientForm.patientForEdit.Age.ToString();
                    ageFormCheckBox.Checked = false;
                    DisabledTextboxesForEdit(ageFormEditTxtBox);
                }
                else
                    ThrowException("Age");
            }
            MessageBox.Show("Patient is edited");
        }

        void ThrowException(string emptyField)
        {
            throw new Exception($"Enter {emptyField} to edit");
        }

        private void sinFormCheckBox_Click(object sender, EventArgs e)
        {
            if (sinFormCheckBox.Checked)
            {
                sinFormEditTxtBox.ReadOnly = false;
            }
            else
                DisabledTextboxesForEdit(sinFormEditTxtBox);
        }

        private void fNameFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fNameFormCheckBox.Checked)
            {
                fNameFormEditTxtBox.ReadOnly = false;
            }
            else
                DisabledTextboxesForEdit(fNameFormEditTxtBox);
        }

        private void ageFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ageFormCheckBox.Checked)
            {
                ageFormEditTxtBox.ReadOnly = false;
            }
            else
                DisabledTextboxesForEdit(ageFormEditTxtBox);
        }

        private void lNameFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lNameFormCheckBox.Checked)
            {
                lNameFormEditTxtBox.ReadOnly = false;
            }
            else
                DisabledTextboxesForEdit(lNameFormEditTxtBox);
        }

        private void EditPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientForm.patientForEdit.SIN = Convert.ToInt32(sinFormDisplayLbl.Text);
            PatientForm.patientForEdit.FirstName = fNameFormDisplayLbl.Text;
            PatientForm.patientForEdit.LastName = lNameFormDisplayLbl.Text;
            PatientForm.patientForEdit.Age = Convert.ToInt32(ageFormDisplayLbl.Text);
        }
    }
}
