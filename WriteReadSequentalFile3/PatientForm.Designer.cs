namespace WriteReadSequentalFile3
{
    partial class PatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sinTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.sinLabel = new System.Windows.Forms.Label();
            this.fNameLable = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.displayAllBtn = new System.Windows.Forms.Button();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.deleteAllPatsBtn = new System.Windows.Forms.Button();
            this.DisplayAllListBox = new System.Windows.Forms.ListBox();
            this.deletePatientBtn = new System.Windows.Forms.Button();
            this.sortByBtn = new System.Windows.Forms.Button();
            this.sinRadioBtn = new System.Windows.Forms.RadioButton();
            this.fNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.ageRadioBtn = new System.Windows.Forms.RadioButton();
            this.lNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.editPatientBtn = new System.Windows.Forms.Button();
            this.saveTXTBtn = new System.Windows.Forms.Button();
            this.saveBINBtn = new System.Windows.Forms.Button();
            this.loadTXTBtn = new System.Windows.Forms.Button();
            this.loadBINBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinTextBox
            // 
            this.sinTextBox.Location = new System.Drawing.Point(160, 31);
            this.sinTextBox.Name = "sinTextBox";
            this.sinTextBox.Size = new System.Drawing.Size(177, 26);
            this.sinTextBox.TabIndex = 0;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(160, 81);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(177, 26);
            this.fNameTextBox.TabIndex = 1;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(160, 134);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(177, 26);
            this.lNameTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(160, 187);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(177, 26);
            this.ageTextBox.TabIndex = 3;
            // 
            // sinLabel
            // 
            this.sinLabel.AutoSize = true;
            this.sinLabel.Location = new System.Drawing.Point(44, 37);
            this.sinLabel.Name = "sinLabel";
            this.sinLabel.Size = new System.Drawing.Size(40, 20);
            this.sinLabel.TabIndex = 4;
            this.sinLabel.Text = "SIN:";
            // 
            // fNameLable
            // 
            this.fNameLable.AutoSize = true;
            this.fNameLable.Location = new System.Drawing.Point(44, 88);
            this.fNameLable.Name = "fNameLable";
            this.fNameLable.Size = new System.Drawing.Size(90, 20);
            this.fNameLable.TabIndex = 5;
            this.fNameLable.Text = "First Name:";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(44, 141);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lNameLabel.TabIndex = 6;
            this.lNameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(44, 194);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(38, 20);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(255, 251);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 44);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseHover += new System.EventHandler(this.addBtn_MouseHover);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(160, 251);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(87, 44);
            this.fillBtn.TabIndex = 8;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            this.fillBtn.MouseHover += new System.EventHandler(this.fillBtn_MouseHover);
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Location = new System.Drawing.Point(857, 264);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(131, 44);
            this.displayAllBtn.TabIndex = 11;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = true;
            this.displayAllBtn.Click += new System.EventHandler(this.displayAllBtn_Click);
            this.displayAllBtn.MouseHover += new System.EventHandler(this.displayAllBtn_MouseHover);
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Location = new System.Drawing.Point(48, 251);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(97, 44);
            this.clearFormBtn.TabIndex = 12;
            this.clearFormBtn.Text = "Clear Form";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.ClearFormBtn_Click);
            this.clearFormBtn.MouseHover += new System.EventHandler(this.clearFormBtn_MouseHover);
            // 
            // deleteAllPatsBtn
            // 
            this.deleteAllPatsBtn.Location = new System.Drawing.Point(857, 203);
            this.deleteAllPatsBtn.Name = "deleteAllPatsBtn";
            this.deleteAllPatsBtn.Size = new System.Drawing.Size(149, 44);
            this.deleteAllPatsBtn.TabIndex = 13;
            this.deleteAllPatsBtn.Text = "Delete all Patients";
            this.deleteAllPatsBtn.UseVisualStyleBackColor = true;
            this.deleteAllPatsBtn.Click += new System.EventHandler(this.deleteAllPatsBtn_Click);
            this.deleteAllPatsBtn.MouseHover += new System.EventHandler(this.deleteAllPatsBtn_MouseHover);
            // 
            // DisplayAllListBox
            // 
            this.DisplayAllListBox.FormattingEnabled = true;
            this.DisplayAllListBox.ItemHeight = 20;
            this.DisplayAllListBox.Location = new System.Drawing.Point(383, 31);
            this.DisplayAllListBox.Name = "DisplayAllListBox";
            this.DisplayAllListBox.Size = new System.Drawing.Size(453, 184);
            this.DisplayAllListBox.TabIndex = 15;
            // 
            // deletePatientBtn
            // 
            this.deletePatientBtn.Location = new System.Drawing.Point(857, 141);
            this.deletePatientBtn.Name = "deletePatientBtn";
            this.deletePatientBtn.Size = new System.Drawing.Size(139, 42);
            this.deletePatientBtn.TabIndex = 16;
            this.deletePatientBtn.Text = "Delete Patient";
            this.deletePatientBtn.UseVisualStyleBackColor = true;
            this.deletePatientBtn.Click += new System.EventHandler(this.deletePatientBtn_Click);
            this.deletePatientBtn.MouseHover += new System.EventHandler(this.deletePatientBtn_MouseHover);
            // 
            // sortByBtn
            // 
            this.sortByBtn.Location = new System.Drawing.Point(1064, 33);
            this.sortByBtn.Name = "sortByBtn";
            this.sortByBtn.Size = new System.Drawing.Size(96, 46);
            this.sortByBtn.TabIndex = 17;
            this.sortByBtn.Text = "Sort";
            this.sortByBtn.UseVisualStyleBackColor = true;
            this.sortByBtn.Click += new System.EventHandler(this.sortBySINBtn_Click);
            this.sortByBtn.MouseHover += new System.EventHandler(this.sortByBtn_MouseHover);
            // 
            // sinRadioBtn
            // 
            this.sinRadioBtn.AutoSize = true;
            this.sinRadioBtn.Location = new System.Drawing.Point(975, 33);
            this.sinRadioBtn.Name = "sinRadioBtn";
            this.sinRadioBtn.Size = new System.Drawing.Size(61, 24);
            this.sinRadioBtn.TabIndex = 18;
            this.sinRadioBtn.TabStop = true;
            this.sinRadioBtn.Text = "SIN";
            this.sinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fNameRadioBtn
            // 
            this.fNameRadioBtn.AutoSize = true;
            this.fNameRadioBtn.Location = new System.Drawing.Point(857, 33);
            this.fNameRadioBtn.Name = "fNameRadioBtn";
            this.fNameRadioBtn.Size = new System.Drawing.Size(111, 24);
            this.fNameRadioBtn.TabIndex = 19;
            this.fNameRadioBtn.TabStop = true;
            this.fNameRadioBtn.Text = "First Name";
            this.fNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ageRadioBtn
            // 
            this.ageRadioBtn.AutoSize = true;
            this.ageRadioBtn.Location = new System.Drawing.Point(973, 55);
            this.ageRadioBtn.Name = "ageRadioBtn";
            this.ageRadioBtn.Size = new System.Drawing.Size(63, 24);
            this.ageRadioBtn.TabIndex = 20;
            this.ageRadioBtn.TabStop = true;
            this.ageRadioBtn.Text = "Age";
            this.ageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lNameRadioBtn
            // 
            this.lNameRadioBtn.AutoSize = true;
            this.lNameRadioBtn.Location = new System.Drawing.Point(857, 55);
            this.lNameRadioBtn.Name = "lNameRadioBtn";
            this.lNameRadioBtn.Size = new System.Drawing.Size(111, 24);
            this.lNameRadioBtn.TabIndex = 21;
            this.lNameRadioBtn.TabStop = true;
            this.lNameRadioBtn.Text = "Last Name";
            this.lNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // editPatientBtn
            // 
            this.editPatientBtn.Location = new System.Drawing.Point(857, 88);
            this.editPatientBtn.Name = "editPatientBtn";
            this.editPatientBtn.Size = new System.Drawing.Size(145, 42);
            this.editPatientBtn.TabIndex = 22;
            this.editPatientBtn.Text = "Edit Patient";
            this.editPatientBtn.UseVisualStyleBackColor = true;
            this.editPatientBtn.Click += new System.EventHandler(this.editPatientBtn_Click);
            this.editPatientBtn.MouseHover += new System.EventHandler(this.editPatientBtn_MouseHover);
            // 
            // saveTXTBtn
            // 
            this.saveTXTBtn.Location = new System.Drawing.Point(383, 241);
            this.saveTXTBtn.Name = "saveTXTBtn";
            this.saveTXTBtn.Size = new System.Drawing.Size(81, 66);
            this.saveTXTBtn.TabIndex = 23;
            this.saveTXTBtn.Text = "Save to .txt";
            this.saveTXTBtn.UseVisualStyleBackColor = true;
            this.saveTXTBtn.Click += new System.EventHandler(this.saveTXTBtn_Click);
            this.saveTXTBtn.MouseHover += new System.EventHandler(this.saveTXTBtn_MouseHover);
            // 
            // saveBINBtn
            // 
            this.saveBINBtn.Location = new System.Drawing.Point(763, 240);
            this.saveBINBtn.Name = "saveBINBtn";
            this.saveBINBtn.Size = new System.Drawing.Size(73, 67);
            this.saveBINBtn.TabIndex = 24;
            this.saveBINBtn.Text = "Save to .bin";
            this.saveBINBtn.UseVisualStyleBackColor = true;
            this.saveBINBtn.Click += new System.EventHandler(this.saveXMLBtn_Click);
            this.saveBINBtn.MouseHover += new System.EventHandler(this.saveBINBtn_MouseHover);
            // 
            // loadTXTBtn
            // 
            this.loadTXTBtn.Location = new System.Drawing.Point(476, 241);
            this.loadTXTBtn.Name = "loadTXTBtn";
            this.loadTXTBtn.Size = new System.Drawing.Size(131, 67);
            this.loadTXTBtn.TabIndex = 25;
            this.loadTXTBtn.Text = "Load previous list from .txt";
            this.loadTXTBtn.UseVisualStyleBackColor = true;
            this.loadTXTBtn.Click += new System.EventHandler(this.loadTXTBtn_Click);
            this.loadTXTBtn.MouseHover += new System.EventHandler(this.loadTXTBtn_MouseHover);
            // 
            // loadBINBtn
            // 
            this.loadBINBtn.Location = new System.Drawing.Point(621, 240);
            this.loadBINBtn.Name = "loadBINBtn";
            this.loadBINBtn.Size = new System.Drawing.Size(131, 67);
            this.loadBINBtn.TabIndex = 26;
            this.loadBINBtn.Text = "Load previous list from .bin";
            this.loadBINBtn.UseVisualStyleBackColor = true;
            this.loadBINBtn.Click += new System.EventHandler(this.loadXMLBtn_Click);
            this.loadBINBtn.MouseHover += new System.EventHandler(this.loadBINBtn_MouseHover);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 336);
            this.Controls.Add(this.loadBINBtn);
            this.Controls.Add(this.loadTXTBtn);
            this.Controls.Add(this.saveBINBtn);
            this.Controls.Add(this.saveTXTBtn);
            this.Controls.Add(this.editPatientBtn);
            this.Controls.Add(this.lNameRadioBtn);
            this.Controls.Add(this.ageRadioBtn);
            this.Controls.Add(this.fNameRadioBtn);
            this.Controls.Add(this.sinRadioBtn);
            this.Controls.Add(this.sortByBtn);
            this.Controls.Add(this.deletePatientBtn);
            this.Controls.Add(this.DisplayAllListBox);
            this.Controls.Add(this.deleteAllPatsBtn);
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.displayAllBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLable);
            this.Controls.Add(this.sinLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.sinTextBox);
            this.Name = "PatientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sinTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label sinLabel;
        private System.Windows.Forms.Label fNameLable;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button displayAllBtn;
        private System.Windows.Forms.Button clearFormBtn;
        private System.Windows.Forms.Button deleteAllPatsBtn;
        private System.Windows.Forms.ListBox DisplayAllListBox;
        private System.Windows.Forms.Button deletePatientBtn;
        private System.Windows.Forms.Button sortByBtn;
        private System.Windows.Forms.RadioButton sinRadioBtn;
        private System.Windows.Forms.RadioButton fNameRadioBtn;
        private System.Windows.Forms.RadioButton ageRadioBtn;
        private System.Windows.Forms.RadioButton lNameRadioBtn;
        private System.Windows.Forms.Button editPatientBtn;
        private System.Windows.Forms.Button saveTXTBtn;
        private System.Windows.Forms.Button saveBINBtn;
        private System.Windows.Forms.Button loadTXTBtn;
        private System.Windows.Forms.Button loadBINBtn;
    }
}

