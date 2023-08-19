namespace WindowsFormsApp.Forms
{
    partial class ProductAdd
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
            this.nbStockMMF = new System.Windows.Forms.NumericUpDown();
            this.nbPriceMMF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBarkodAdd = new System.Windows.Forms.TextBox();
            this.cbxBrandMMF = new System.Windows.Forms.ComboBox();
            this.cbxCategoryMMF = new System.Windows.Forms.ComboBox();
            this.tbxTitleMMF = new System.Windows.Forms.TextBox();
            this.pbxImageMMF = new System.Windows.Forms.PictureBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.btnAddMMF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbStockMMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceMMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageMMF)).BeginInit();
            this.SuspendLayout();
            // 
            // nbStockMMF
            // 
            this.nbStockMMF.Location = new System.Drawing.Point(718, 301);
            this.nbStockMMF.Name = "nbStockMMF";
            this.nbStockMMF.Size = new System.Drawing.Size(149, 23);
            this.nbStockMMF.TabIndex = 30;
            // 
            // nbPriceMMF
            // 
            this.nbPriceMMF.Location = new System.Drawing.Point(718, 255);
            this.nbPriceMMF.Name = "nbPriceMMF";
            this.nbPriceMMF.Size = new System.Drawing.Size(149, 23);
            this.nbPriceMMF.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Stok Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(634, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(634, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(634, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marka :";
            // 
            // tbxBarkodAdd
            // 
            this.tbxBarkodAdd.Location = new System.Drawing.Point(111, 26);
            this.tbxBarkodAdd.Name = "tbxBarkodAdd";
            this.tbxBarkodAdd.Size = new System.Drawing.Size(756, 23);
            this.tbxBarkodAdd.TabIndex = 24;
            // 
            // cbxBrandMMF
            // 
            this.cbxBrandMMF.FormattingEnabled = true;
            this.cbxBrandMMF.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cbxBrandMMF.Location = new System.Drawing.Point(717, 160);
            this.cbxBrandMMF.Name = "cbxBrandMMF";
            this.cbxBrandMMF.Size = new System.Drawing.Size(150, 23);
            this.cbxBrandMMF.TabIndex = 23;
            // 
            // cbxCategoryMMF
            // 
            this.cbxCategoryMMF.FormattingEnabled = true;
            this.cbxCategoryMMF.Items.AddRange(new object[] {
            "s",
            "v",
            "b"});
            this.cbxCategoryMMF.Location = new System.Drawing.Point(717, 205);
            this.cbxCategoryMMF.Name = "cbxCategoryMMF";
            this.cbxCategoryMMF.Size = new System.Drawing.Size(150, 23);
            this.cbxCategoryMMF.TabIndex = 22;
            // 
            // tbxTitleMMF
            // 
            this.tbxTitleMMF.Location = new System.Drawing.Point(307, 115);
            this.tbxTitleMMF.Name = "tbxTitleMMF";
            this.tbxTitleMMF.Size = new System.Drawing.Size(560, 23);
            this.tbxTitleMMF.TabIndex = 21;
            // 
            // pbxImageMMF
            // 
            this.pbxImageMMF.Image = global::WindowsFormsApp.Properties.Resources.Screenshot_2023_07_30_200821;
            this.pbxImageMMF.ImageLocation = "";
            this.pbxImageMMF.Location = new System.Drawing.Point(12, 115);
            this.pbxImageMMF.Name = "pbxImageMMF";
            this.pbxImageMMF.Size = new System.Drawing.Size(207, 211);
            this.pbxImageMMF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageMMF.TabIndex = 20;
            this.pbxImageMMF.TabStop = false;
            this.pbxImageMMF.Click += new System.EventHandler(this.pbxImageMMF_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(12, 19);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(93, 30);
            this.lblBarcode.TabIndex = 19;
            this.lblBarcode.Text = "Barkod :";
            // 
            // btnAddMMF
            // 
            this.btnAddMMF.Location = new System.Drawing.Point(747, 356);
            this.btnAddMMF.Name = "btnAddMMF";
            this.btnAddMMF.Size = new System.Drawing.Size(120, 23);
            this.btnAddMMF.TabIndex = 31;
            this.btnAddMMF.Text = "Ekle";
            this.btnAddMMF.UseVisualStyleBackColor = true;
            this.btnAddMMF.Click += new System.EventHandler(this.btnAddMMF_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(879, 423);
            this.Controls.Add(this.btnAddMMF);
            this.Controls.Add(this.nbStockMMF);
            this.Controls.Add(this.nbPriceMMF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBarkodAdd);
            this.Controls.Add(this.cbxBrandMMF);
            this.Controls.Add(this.cbxCategoryMMF);
            this.Controls.Add(this.tbxTitleMMF);
            this.Controls.Add(this.pbxImageMMF);
            this.Controls.Add(this.lblBarcode);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbStockMMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceMMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageMMF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown nbStockMMF;
        private NumericUpDown nbPriceMMF;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxBarkodAdd;
        private ComboBox cbxBrandMMF;
        private ComboBox cbxCategoryMMF;
        private TextBox tbxTitleMMF;
        private PictureBox pbxImageMMF;
        private Label lblBarcode;
        private Button btnAddMMF;
    }
}