namespace FormSalary
{
    partial class Form1
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.listBoxPosition = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddPersonnel = new System.Windows.Forms.Button();
            this.SalarydataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sgti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalarydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(59, 71);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(201, 71);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(358, 71);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.Location = new System.Drawing.Point(530, 71);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(52, 13);
            this.labelHireDate.TabIndex = 3;
            this.labelHireDate.Text = "Hire Date";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(62, 87);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbFirstName_MouseClick);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(204, 87);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // listBoxPosition
            // 
            this.listBoxPosition.AllowDrop = true;
            this.listBoxPosition.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxPosition.FormattingEnabled = true;
            this.listBoxPosition.Items.AddRange(new object[] {
            "PO1",
            "PO2",
            "PO3",
            "SPO1",
            "SPO2",
            "SPO3",
            "SPO4",
            "INSP",
            "SINSP",
            "CINSP",
            "SUPT",
            "SSUPT",
            "CSUPT",
            "DIR",
            "DDIR",
            "DGeneral"});
            this.listBoxPosition.Location = new System.Drawing.Point(361, 87);
            this.listBoxPosition.Name = "listBoxPosition";
            this.listBoxPosition.Size = new System.Drawing.Size(120, 95);
            this.listBoxPosition.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // buttonAddPersonnel
            // 
            this.buttonAddPersonnel.Location = new System.Drawing.Point(62, 159);
            this.buttonAddPersonnel.Name = "buttonAddPersonnel";
            this.buttonAddPersonnel.Size = new System.Drawing.Size(130, 23);
            this.buttonAddPersonnel.TabIndex = 8;
            this.buttonAddPersonnel.Text = "Add Personnel";
            this.buttonAddPersonnel.UseVisualStyleBackColor = true;
            this.buttonAddPersonnel.Click += new System.EventHandler(this.buttonAddPersonnel_Click);
            // 
            // SalarydataGridView
            // 
            this.SalarydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalarydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Sgti,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.SalarydataGridView.Location = new System.Drawing.Point(0, 188);
            this.SalarydataGridView.Name = "SalarydataGridView";
            this.SalarydataGridView.Size = new System.Drawing.Size(786, 116);
            this.SalarydataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Sgti
            // 
            this.Sgti.DataPropertyName = "Sgti";
            this.Sgti.HeaderText = "Sgti";
            this.Sgti.Name = "Sgti";
            this.Sgti.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Position";
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HireDate";
            this.Column4.HeaderText = "Hire Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GrossPay";
            this.Column5.HeaderText = "Gross Pay";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LongPay";
            this.Column6.HeaderText = "Long Pay";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TotalDeductions";
            this.Column7.HeaderText = "Deductions";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TotalSalary";
            this.Column8.HeaderText = "Salary";
            this.Column8.Name = "Column8";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(62, 349);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(508, 349);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 474);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.SalarydataGridView);
            this.Controls.Add(this.buttonAddPersonnel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxPosition);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SalarydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ListBox listBoxPosition;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAddPersonnel;
        private System.Windows.Forms.DataGridView SalarydataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sgti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;

    }
}

