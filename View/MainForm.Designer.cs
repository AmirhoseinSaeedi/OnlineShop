namespace View
{
    partial class MainForm
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
            this.PersonBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonBtn
            // 
            this.PersonBtn.Location = new System.Drawing.Point(98, 107);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(94, 29);
            this.PersonBtn.TabIndex = 0;
            this.PersonBtn.Text = "Person";
            this.PersonBtn.UseVisualStyleBackColor = true;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.Location = new System.Drawing.Point(313, 107);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductBtn.TabIndex = 1;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(529, 273);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.PersonBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button PersonBtn;
        private Button ProductBtn;
    }
}