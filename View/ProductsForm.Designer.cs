namespace View
{
    partial class ProductsForm
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
            this.ProductSaveBtn = new System.Windows.Forms.Button();
            this.ProductUpdateBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.ProductRefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductUnitPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductTitleTxt = new System.Windows.Forms.TextBox();
            this.ProductDVG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductSaveBtn
            // 
            this.ProductSaveBtn.Location = new System.Drawing.Point(32, 12);
            this.ProductSaveBtn.Name = "ProductSaveBtn";
            this.ProductSaveBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductSaveBtn.TabIndex = 0;
            this.ProductSaveBtn.Text = "Save";
            this.ProductSaveBtn.UseVisualStyleBackColor = true;
            this.ProductSaveBtn.Click += new System.EventHandler(this.ProductSaveBtn_Click);
            // 
            // ProductUpdateBtn
            // 
            this.ProductUpdateBtn.Location = new System.Drawing.Point(284, 12);
            this.ProductUpdateBtn.Name = "ProductUpdateBtn";
            this.ProductUpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductUpdateBtn.TabIndex = 1;
            this.ProductUpdateBtn.Text = "Update";
            this.ProductUpdateBtn.UseVisualStyleBackColor = true;
            this.ProductUpdateBtn.Click += new System.EventHandler(this.ProductUpdateBtn_Click);
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.Location = new System.Drawing.Point(155, 12);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductDeleteBtn.TabIndex = 2;
            this.ProductDeleteBtn.Text = "Delete";
            this.ProductDeleteBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // ProductRefreshBtn
            // 
            this.ProductRefreshBtn.Location = new System.Drawing.Point(418, 12);
            this.ProductRefreshBtn.Name = "ProductRefreshBtn";
            this.ProductRefreshBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductRefreshBtn.TabIndex = 3;
            this.ProductRefreshBtn.Text = "Refresh";
            this.ProductRefreshBtn.UseVisualStyleBackColor = true;
            this.ProductRefreshBtn.Click += new System.EventHandler(this.ProductRefreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // ProductUnitPriceTxt
            // 
            this.ProductUnitPriceTxt.Location = new System.Drawing.Point(366, 71);
            this.ProductUnitPriceTxt.Name = "ProductUnitPriceTxt";
            this.ProductUnitPriceTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductUnitPriceTxt.TabIndex = 5;
            // 
            // ProductTitleTxt
            // 
            this.ProductTitleTxt.Location = new System.Drawing.Point(115, 71);
            this.ProductTitleTxt.Name = "ProductTitleTxt";
            this.ProductTitleTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductTitleTxt.TabIndex = 6;
            // 
            // ProductDVG
            // 
            this.ProductDVG.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.ProductDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDVG.Location = new System.Drawing.Point(80, 104);
            this.ProductDVG.Name = "ProductDVG";
            this.ProductDVG.RowHeadersWidth = 51;
            this.ProductDVG.RowTemplate.Height = 29;
            this.ProductDVG.Size = new System.Drawing.Size(432, 214);
            this.ProductDVG.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unit price";
            // 
            // ProductBackBtn
            // 
            this.ProductBackBtn.Location = new System.Drawing.Point(3, 324);
            this.ProductBackBtn.Name = "ProductBackBtn";
            this.ProductBackBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductBackBtn.TabIndex = 9;
            this.ProductBackBtn.Text = "Back";
            this.ProductBackBtn.UseVisualStyleBackColor = true;
            this.ProductBackBtn.Click += new System.EventHandler(this.ProductBackBtn_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(603, 360);
            this.Controls.Add(this.ProductBackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDVG);
            this.Controls.Add(this.ProductTitleTxt);
            this.Controls.Add(this.ProductUnitPriceTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductRefreshBtn);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductUpdateBtn);
            this.Controls.Add(this.ProductSaveBtn);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ProductSaveBtn;
        private Button ProductUpdateBtn;
        private Button ProductDeleteBtn;
        private Button ProductRefreshBtn;
        private Label label1;
        private TextBox ProductUnitPriceTxt;
        private TextBox ProductTitleTxt;
        private DataGridView ProductDVG;
        private Label label2;
        private Button ProductBackBtn;
    }
}