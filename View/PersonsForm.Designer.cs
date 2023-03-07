namespace View
{
    partial class PersonsForm
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
            this.PersonSaveBtn = new System.Windows.Forms.Button();
            this.PersonDeleteBtn = new System.Windows.Forms.Button();
            this.PersonUpdateBtn = new System.Windows.Forms.Button();
            this.PersonRefreshBtn = new System.Windows.Forms.Button();
            this.PersonDVG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonFirsNameTxt = new System.Windows.Forms.TextBox();
            this.PersonLastNameTxt = new System.Windows.Forms.TextBox();
            this.PersonBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonSaveBtn
            // 
            this.PersonSaveBtn.Location = new System.Drawing.Point(52, 12);
            this.PersonSaveBtn.Name = "PersonSaveBtn";
            this.PersonSaveBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonSaveBtn.TabIndex = 0;
            this.PersonSaveBtn.Text = "Save";
            this.PersonSaveBtn.UseVisualStyleBackColor = true;
            this.PersonSaveBtn.Click += new System.EventHandler(this.PersonSaveBtn_Click);
            // 
            // PersonDeleteBtn
            // 
            this.PersonDeleteBtn.Location = new System.Drawing.Point(194, 12);
            this.PersonDeleteBtn.Name = "PersonDeleteBtn";
            this.PersonDeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonDeleteBtn.TabIndex = 1;
            this.PersonDeleteBtn.Text = "Delete";
            this.PersonDeleteBtn.UseVisualStyleBackColor = true;
            this.PersonDeleteBtn.Click += new System.EventHandler(this.PersonDeleteBtn_Click);
            // 
            // PersonUpdateBtn
            // 
            this.PersonUpdateBtn.Location = new System.Drawing.Point(329, 12);
            this.PersonUpdateBtn.Name = "PersonUpdateBtn";
            this.PersonUpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonUpdateBtn.TabIndex = 2;
            this.PersonUpdateBtn.Text = "Update";
            this.PersonUpdateBtn.UseVisualStyleBackColor = true;
            this.PersonUpdateBtn.Click += new System.EventHandler(this.PersonUpdateBtn_Click);
            // 
            // PersonRefreshBtn
            // 
            this.PersonRefreshBtn.Location = new System.Drawing.Point(464, 12);
            this.PersonRefreshBtn.Name = "PersonRefreshBtn";
            this.PersonRefreshBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonRefreshBtn.TabIndex = 3;
            this.PersonRefreshBtn.Text = "Refresh";
            this.PersonRefreshBtn.UseVisualStyleBackColor = true;
            this.PersonRefreshBtn.Click += new System.EventHandler(this.PersonRefreshBtn_Click);
            // 
            // PersonDVG
            // 
            this.PersonDVG.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.PersonDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonDVG.Location = new System.Drawing.Point(88, 118);
            this.PersonDVG.Name = "PersonDVG";
            this.PersonDVG.RowHeadersWidth = 51;
            this.PersonDVG.RowTemplate.Height = 29;
            this.PersonDVG.Size = new System.Drawing.Size(432, 228);
            this.PersonDVG.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "First name";
            // 
            // PersonFirsNameTxt
            // 
            this.PersonFirsNameTxt.Location = new System.Drawing.Point(144, 69);
            this.PersonFirsNameTxt.Name = "PersonFirsNameTxt";
            this.PersonFirsNameTxt.Size = new System.Drawing.Size(125, 27);
            this.PersonFirsNameTxt.TabIndex = 8;
            // 
            // PersonLastNameTxt
            // 
            this.PersonLastNameTxt.Location = new System.Drawing.Point(391, 69);
            this.PersonLastNameTxt.Name = "PersonLastNameTxt";
            this.PersonLastNameTxt.Size = new System.Drawing.Size(129, 27);
            this.PersonLastNameTxt.TabIndex = 9;
            // 
            // PersonBackBtn
            // 
            this.PersonBackBtn.Location = new System.Drawing.Point(12, 352);
            this.PersonBackBtn.Name = "PersonBackBtn";
            this.PersonBackBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonBackBtn.TabIndex = 10;
            this.PersonBackBtn.Text = "Back";
            this.PersonBackBtn.UseVisualStyleBackColor = true;
            this.PersonBackBtn.Click += new System.EventHandler(this.PersonBackBtn_Click);
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(611, 387);
            this.Controls.Add(this.PersonBackBtn);
            this.Controls.Add(this.PersonLastNameTxt);
            this.Controls.Add(this.PersonFirsNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PersonDVG);
            this.Controls.Add(this.PersonRefreshBtn);
            this.Controls.Add(this.PersonUpdateBtn);
            this.Controls.Add(this.PersonDeleteBtn);
            this.Controls.Add(this.PersonSaveBtn);
            this.Name = "PersonsForm";
            this.Text = "PersonsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PersonDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PersonSaveBtn;
        private Button PersonDeleteBtn;
        private Button PersonUpdateBtn;
        private Button PersonRefreshBtn;
        private DataGridView PersonDVG;
        private Label label2;
        private Label label3;
        private TextBox PersonFirsNameTxt;
        private TextBox PersonLastNameTxt;
        private Button PersonBackBtn;
    }
}