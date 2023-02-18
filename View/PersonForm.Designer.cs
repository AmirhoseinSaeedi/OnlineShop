namespace View
{
    partial class PersonForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.personBtnSave = new System.Windows.Forms.Button();
            this.personBtnDelete = new System.Windows.Forms.Button();
            this.personBtnUpdate = new System.Windows.Forms.Button();
            this.personLblFirstName = new System.Windows.Forms.Label();
            this.personLblLastName = new System.Windows.Forms.Label();
            this.personTxtLastName = new System.Windows.Forms.TextBox();
            this.personTxtFirstName = new System.Windows.Forms.TextBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.personTxtId = new System.Windows.Forms.TextBox();
            this.lblll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personUpdateTextBoxId = new System.Windows.Forms.TextBox();
            this.personUpdateTextBoxNewFirstName = new System.Windows.Forms.TextBox();
            this.personUpdateTextBoxNewLastName = new System.Windows.Forms.TextBox();
            this.PersonBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(539, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // personBtnSave
            // 
            this.personBtnSave.Location = new System.Drawing.Point(95, 12);
            this.personBtnSave.Name = "personBtnSave";
            this.personBtnSave.Size = new System.Drawing.Size(94, 29);
            this.personBtnSave.TabIndex = 1;
            this.personBtnSave.Text = "Save";
            this.personBtnSave.UseVisualStyleBackColor = true;
            this.personBtnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // personBtnDelete
            // 
            this.personBtnDelete.Location = new System.Drawing.Point(539, 12);
            this.personBtnDelete.Name = "personBtnDelete";
            this.personBtnDelete.Size = new System.Drawing.Size(94, 29);
            this.personBtnDelete.TabIndex = 2;
            this.personBtnDelete.Text = "Delete";
            this.personBtnDelete.UseVisualStyleBackColor = true;
            this.personBtnDelete.Click += new System.EventHandler(this.personBtnDelete_Click);
            // 
            // personBtnUpdate
            // 
            this.personBtnUpdate.Location = new System.Drawing.Point(95, 193);
            this.personBtnUpdate.Name = "personBtnUpdate";
            this.personBtnUpdate.Size = new System.Drawing.Size(94, 29);
            this.personBtnUpdate.TabIndex = 3;
            this.personBtnUpdate.Text = "Update";
            this.personBtnUpdate.UseVisualStyleBackColor = true;
            this.personBtnUpdate.Click += new System.EventHandler(this.personBtnUpdate_Click);
            // 
            // personLblFirstName
            // 
            this.personLblFirstName.AutoSize = true;
            this.personLblFirstName.Location = new System.Drawing.Point(12, 61);
            this.personLblFirstName.Name = "personLblFirstName";
            this.personLblFirstName.Size = new System.Drawing.Size(77, 20);
            this.personLblFirstName.TabIndex = 4;
            this.personLblFirstName.Text = "First name";
            // 
            // personLblLastName
            // 
            this.personLblLastName.AutoSize = true;
            this.personLblLastName.Location = new System.Drawing.Point(12, 105);
            this.personLblLastName.Name = "personLblLastName";
            this.personLblLastName.Size = new System.Drawing.Size(76, 20);
            this.personLblLastName.TabIndex = 5;
            this.personLblLastName.Text = "Last name";
            // 
            // personTxtLastName
            // 
            this.personTxtLastName.Location = new System.Drawing.Point(95, 102);
            this.personTxtLastName.Name = "personTxtLastName";
            this.personTxtLastName.Size = new System.Drawing.Size(122, 27);
            this.personTxtLastName.TabIndex = 6;
            // 
            // personTxtFirstName
            // 
            this.personTxtFirstName.Location = new System.Drawing.Point(95, 58);
            this.personTxtFirstName.Name = "personTxtFirstName";
            this.personTxtFirstName.Size = new System.Drawing.Size(122, 27);
            this.personTxtFirstName.TabIndex = 7;
            this.personTxtFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvPerson
            // 
            this.dgvPerson.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPerson.Location = new System.Drawing.Point(409, 228);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowTemplate.Height = 29;
            this.dgvPerson.Size = new System.Drawing.Size(379, 210);
            this.dgvPerson.TabIndex = 8;
            // 
            // personTxtId
            // 
            this.personTxtId.Location = new System.Drawing.Point(539, 76);
            this.personTxtId.Name = "personTxtId";
            this.personTxtId.Size = new System.Drawing.Size(125, 27);
            this.personTxtId.TabIndex = 9;
            // 
            // lblll
            // 
            this.lblll.AutoSize = true;
            this.lblll.Location = new System.Drawing.Point(499, 79);
            this.lblll.Name = "lblll";
            this.lblll.Size = new System.Drawing.Size(22, 20);
            this.lblll.TabIndex = 10;
            this.lblll.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last name";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(12, 308);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(77, 20);
            this.labe.TabIndex = 12;
            this.labe.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id";
            // 
            // personUpdateTextBoxId
            // 
            this.personUpdateTextBoxId.Location = new System.Drawing.Point(92, 246);
            this.personUpdateTextBoxId.Name = "personUpdateTextBoxId";
            this.personUpdateTextBoxId.Size = new System.Drawing.Size(125, 27);
            this.personUpdateTextBoxId.TabIndex = 14;
            this.personUpdateTextBoxId.TextChanged += new System.EventHandler(this.personUpdateBtnId_TextChanged);
            // 
            // personUpdateTextBoxNewFirstName
            // 
            this.personUpdateTextBoxNewFirstName.Location = new System.Drawing.Point(92, 301);
            this.personUpdateTextBoxNewFirstName.Name = "personUpdateTextBoxNewFirstName";
            this.personUpdateTextBoxNewFirstName.Size = new System.Drawing.Size(125, 27);
            this.personUpdateTextBoxNewFirstName.TabIndex = 15;
            // 
            // personUpdateTextBoxNewLastName
            // 
            this.personUpdateTextBoxNewLastName.Location = new System.Drawing.Point(92, 357);
            this.personUpdateTextBoxNewLastName.Name = "personUpdateTextBoxNewLastName";
            this.personUpdateTextBoxNewLastName.Size = new System.Drawing.Size(125, 27);
            this.personUpdateTextBoxNewLastName.TabIndex = 16;
            // 
            // PersonBackBtn
            // 
            this.PersonBackBtn.Location = new System.Drawing.Point(12, 409);
            this.PersonBackBtn.Name = "PersonBackBtn";
            this.PersonBackBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonBackBtn.TabIndex = 17;
            this.PersonBackBtn.Text = "Back";
            this.PersonBackBtn.UseVisualStyleBackColor = true;
            this.PersonBackBtn.Click += new System.EventHandler(this.PersonBackBtn_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonBackBtn);
            this.Controls.Add(this.personUpdateTextBoxNewLastName);
            this.Controls.Add(this.personUpdateTextBoxNewFirstName);
            this.Controls.Add(this.personUpdateTextBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblll);
            this.Controls.Add(this.personTxtId);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.personTxtFirstName);
            this.Controls.Add(this.personTxtLastName);
            this.Controls.Add(this.personLblLastName);
            this.Controls.Add(this.personLblFirstName);
            this.Controls.Add(this.personBtnUpdate);
            this.Controls.Add(this.personBtnDelete);
            this.Controls.Add(this.personBtnSave);
            this.Controls.Add(this.btnRefresh);
            this.Name = "PersonForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRefresh;
        private Button personBtnSave;
        private Button personBtnDelete;
        private Button personBtnUpdate;
        private Label personLblFirstName;
        private Label personLblLastName;
        private TextBox personTxtLastName;
        private TextBox personTxtFirstName;
        private DataGridView dgvPerson;
        private TextBox personTxtId;
        private Label lblll;
        private Label label1;
        private Label labe;
        private Label label3;
        private TextBox personUpdateTextBoxId;
        private TextBox personUpdateTextBoxNewFirstName;
        private TextBox personUpdateTextBoxNewLastName;
        private Button PersonBackBtn;
    }
}