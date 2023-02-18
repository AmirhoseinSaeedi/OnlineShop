namespace View
{
    partial class ProductForm
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
            this.productDvg = new System.Windows.Forms.DataGridView();
            this.productRefresh = new System.Windows.Forms.Button();
            this.ProductSaveBtn = new System.Windows.Forms.Button();
            this.ProductUpdateBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.ProductUnitPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductTitleTxt = new System.Windows.Forms.TextBox();
            this.ProductUnitPriceLbl = new System.Windows.Forms.Label();
            this.ProductTitleLbl = new System.Windows.Forms.Label();
            this.ProductDeletIdTxt = new System.Windows.Forms.TextBox();
            this.ProductIdLbl = new System.Windows.Forms.Label();
            this.ProductNewTitleTxt = new System.Windows.Forms.TextBox();
            this.ProductNewIdTxt = new System.Windows.Forms.TextBox();
            this.ProductNewUnitPriceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDvg)).BeginInit();
            this.SuspendLayout();
            // 
            // productDvg
            // 
            this.productDvg.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.productDvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDvg.Location = new System.Drawing.Point(414, 232);
            this.productDvg.Name = "productDvg";
            this.productDvg.RowHeadersWidth = 51;
            this.productDvg.RowTemplate.Height = 29;
            this.productDvg.Size = new System.Drawing.Size(374, 206);
            this.productDvg.TabIndex = 0;
            // 
            // productRefresh
            // 
            this.productRefresh.Location = new System.Drawing.Point(541, 186);
            this.productRefresh.Name = "productRefresh";
            this.productRefresh.Size = new System.Drawing.Size(94, 29);
            this.productRefresh.TabIndex = 1;
            this.productRefresh.Text = "Refresh";
            this.productRefresh.UseVisualStyleBackColor = true;
            this.productRefresh.Click += new System.EventHandler(this.productRefresh_Click);
            // 
            // ProductSaveBtn
            // 
            this.ProductSaveBtn.Location = new System.Drawing.Point(101, 12);
            this.ProductSaveBtn.Name = "ProductSaveBtn";
            this.ProductSaveBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductSaveBtn.TabIndex = 2;
            this.ProductSaveBtn.Text = "Save";
            this.ProductSaveBtn.UseVisualStyleBackColor = true;
            this.ProductSaveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductUpdateBtn
            // 
            this.ProductUpdateBtn.Location = new System.Drawing.Point(101, 197);
            this.ProductUpdateBtn.Name = "ProductUpdateBtn";
            this.ProductUpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductUpdateBtn.TabIndex = 3;
            this.ProductUpdateBtn.Text = "Update";
            this.ProductUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.Location = new System.Drawing.Point(541, 12);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductDeleteBtn.TabIndex = 4;
            this.ProductDeleteBtn.Text = "Delete";
            this.ProductDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ProductUnitPriceTxt
            // 
            this.ProductUnitPriceTxt.Location = new System.Drawing.Point(101, 126);
            this.ProductUnitPriceTxt.Name = "ProductUnitPriceTxt";
            this.ProductUnitPriceTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductUnitPriceTxt.TabIndex = 5;
            // 
            // ProductTitleTxt
            // 
            this.ProductTitleTxt.Location = new System.Drawing.Point(101, 78);
            this.ProductTitleTxt.Name = "ProductTitleTxt";
            this.ProductTitleTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductTitleTxt.TabIndex = 6;
            // 
            // ProductUnitPriceLbl
            // 
            this.ProductUnitPriceLbl.AutoSize = true;
            this.ProductUnitPriceLbl.Location = new System.Drawing.Point(12, 133);
            this.ProductUnitPriceLbl.Name = "ProductUnitPriceLbl";
            this.ProductUnitPriceLbl.Size = new System.Drawing.Size(73, 20);
            this.ProductUnitPriceLbl.TabIndex = 7;
            this.ProductUnitPriceLbl.Text = "Unit price";
            // 
            // ProductTitleLbl
            // 
            this.ProductTitleLbl.AutoSize = true;
            this.ProductTitleLbl.Location = new System.Drawing.Point(24, 78);
            this.ProductTitleLbl.Name = "ProductTitleLbl";
            this.ProductTitleLbl.Size = new System.Drawing.Size(38, 20);
            this.ProductTitleLbl.TabIndex = 8;
            this.ProductTitleLbl.Text = "Title";
            // 
            // ProductDeletIdTxt
            // 
            this.ProductDeletIdTxt.Location = new System.Drawing.Point(529, 78);
            this.ProductDeletIdTxt.Name = "ProductDeletIdTxt";
            this.ProductDeletIdTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductDeletIdTxt.TabIndex = 9;
            // 
            // ProductIdLbl
            // 
            this.ProductIdLbl.AutoSize = true;
            this.ProductIdLbl.Location = new System.Drawing.Point(480, 85);
            this.ProductIdLbl.Name = "ProductIdLbl";
            this.ProductIdLbl.Size = new System.Drawing.Size(22, 20);
            this.ProductIdLbl.TabIndex = 10;
            this.ProductIdLbl.Text = "Id";
            // 
            // ProductNewTitleTxt
            // 
            this.ProductNewTitleTxt.Location = new System.Drawing.Point(101, 299);
            this.ProductNewTitleTxt.Name = "ProductNewTitleTxt";
            this.ProductNewTitleTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductNewTitleTxt.TabIndex = 11;
            // 
            // ProductNewIdTxt
            // 
            this.ProductNewIdTxt.Location = new System.Drawing.Point(101, 244);
            this.ProductNewIdTxt.Name = "ProductNewIdTxt";
            this.ProductNewIdTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductNewIdTxt.TabIndex = 12;
            // 
            // ProductNewUnitPriceTxt
            // 
            this.ProductNewUnitPriceTxt.Location = new System.Drawing.Point(101, 355);
            this.ProductNewUnitPriceTxt.Name = "ProductNewUnitPriceTxt";
            this.ProductNewUnitPriceTxt.Size = new System.Drawing.Size(125, 27);
            this.ProductNewUnitPriceTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Unit price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id";
            // 
            // ProductBackBtn
            // 
            this.ProductBackBtn.Location = new System.Drawing.Point(24, 409);
            this.ProductBackBtn.Name = "ProductBackBtn";
            this.ProductBackBtn.Size = new System.Drawing.Size(94, 29);
            this.ProductBackBtn.TabIndex = 17;
            this.ProductBackBtn.Text = "Back";
            this.ProductBackBtn.UseVisualStyleBackColor = true;
            this.ProductBackBtn.Click += new System.EventHandler(this.ProductBackBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductBackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNewUnitPriceTxt);
            this.Controls.Add(this.ProductNewIdTxt);
            this.Controls.Add(this.ProductNewTitleTxt);
            this.Controls.Add(this.ProductIdLbl);
            this.Controls.Add(this.ProductDeletIdTxt);
            this.Controls.Add(this.ProductTitleLbl);
            this.Controls.Add(this.ProductUnitPriceLbl);
            this.Controls.Add(this.ProductTitleTxt);
            this.Controls.Add(this.ProductUnitPriceTxt);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductUpdateBtn);
            this.Controls.Add(this.ProductSaveBtn);
            this.Controls.Add(this.productRefresh);
            this.Controls.Add(this.productDvg);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView productDvg;
        private Button productRefresh;
        private Button ProductSaveBtn;
        private Button ProductUpdateBtn;
        private Button ProductDeleteBtn;
        private TextBox ProductUnitPriceTxt;
        private TextBox ProductTitleTxt;
        private Label ProductUnitPriceLbl;
        private Label ProductTitleLbl;
        private TextBox ProductDeletIdTxt;
        private Label ProductIdLbl;
        private TextBox ProductNewTitleTxt;
        private TextBox ProductNewIdTxt;
        private TextBox ProductNewUnitPriceTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ProductBackBtn;
    }
}