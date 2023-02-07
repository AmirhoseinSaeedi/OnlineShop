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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDvg)).BeginInit();
            this.SuspendLayout();
            // 
            // productDvg
            // 
            this.productDvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDvg.Location = new System.Drawing.Point(0, 115);
            this.productDvg.Name = "productDvg";
            this.productDvg.RowHeadersWidth = 51;
            this.productDvg.RowTemplate.Height = 29;
            this.productDvg.Size = new System.Drawing.Size(797, 323);
            this.productDvg.TabIndex = 0;
            // 
            // productRefresh
            // 
            this.productRefresh.Location = new System.Drawing.Point(35, 12);
            this.productRefresh.Name = "productRefresh";
            this.productRefresh.Size = new System.Drawing.Size(94, 29);
            this.productRefresh.TabIndex = 1;
            this.productRefresh.Text = "Refresh";
            this.productRefresh.UseVisualStyleBackColor = true;
            this.productRefresh.Click += new System.EventHandler(this.productRefresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productRefresh);
            this.Controls.Add(this.productDvg);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDvg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView productDvg;
        private Button productRefresh;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}