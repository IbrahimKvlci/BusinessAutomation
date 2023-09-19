namespace WindowsFormsApp.Forms
{
    partial class ProductUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nbStockUpdate = new System.Windows.Forms.NumericUpDown();
            this.nbPriceUpdate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBarkodUpdate = new System.Windows.Forms.TextBox();
            this.cbxBrandUpdate = new System.Windows.Forms.ComboBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxTitleUpdate = new System.Windows.Forms.TextBox();
            this.pbxImageUpdate = new System.Windows.Forms.PictureBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbStockUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(747, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nbStockUpdate
            // 
            this.nbStockUpdate.DecimalPlaces = 2;
            this.nbStockUpdate.Location = new System.Drawing.Point(718, 291);
            this.nbStockUpdate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbStockUpdate.Name = "nbStockUpdate";
            this.nbStockUpdate.Size = new System.Drawing.Size(149, 23);
            this.nbStockUpdate.TabIndex = 43;
            // 
            // nbPriceUpdate
            // 
            this.nbPriceUpdate.DecimalPlaces = 2;
            this.nbPriceUpdate.Location = new System.Drawing.Point(718, 245);
            this.nbPriceUpdate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbPriceUpdate.Name = "nbPriceUpdate";
            this.nbPriceUpdate.Size = new System.Drawing.Size(149, 23);
            this.nbPriceUpdate.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Stok Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(634, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(634, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(634, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Marka :";
            // 
            // tbxBarkodUpdate
            // 
            this.tbxBarkodUpdate.Location = new System.Drawing.Point(111, 16);
            this.tbxBarkodUpdate.Name = "tbxBarkodUpdate";
            this.tbxBarkodUpdate.Size = new System.Drawing.Size(756, 23);
            this.tbxBarkodUpdate.TabIndex = 37;
            // 
            // cbxBrandUpdate
            // 
            this.cbxBrandUpdate.FormattingEnabled = true;
            this.cbxBrandUpdate.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cbxBrandUpdate.Location = new System.Drawing.Point(717, 150);
            this.cbxBrandUpdate.Name = "cbxBrandUpdate";
            this.cbxBrandUpdate.Size = new System.Drawing.Size(150, 23);
            this.cbxBrandUpdate.TabIndex = 36;
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Items.AddRange(new object[] {
            "s",
            "v",
            "b"});
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(717, 195);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(150, 23);
            this.cbxCategoryUpdate.TabIndex = 35;
            // 
            // tbxTitleUpdate
            // 
            this.tbxTitleUpdate.Location = new System.Drawing.Point(307, 105);
            this.tbxTitleUpdate.Name = "tbxTitleUpdate";
            this.tbxTitleUpdate.Size = new System.Drawing.Size(560, 23);
            this.tbxTitleUpdate.TabIndex = 34;
            // 
            // pbxImageUpdate
            // 
            this.pbxImageUpdate.Image = global::WindowsFormsApp.Properties.Resources.Screenshot_2023_07_30_200821;
            this.pbxImageUpdate.ImageLocation = "";
            this.pbxImageUpdate.Location = new System.Drawing.Point(12, 105);
            this.pbxImageUpdate.Name = "pbxImageUpdate";
            this.pbxImageUpdate.Size = new System.Drawing.Size(207, 211);
            this.pbxImageUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageUpdate.TabIndex = 33;
            this.pbxImageUpdate.TabStop = false;
            this.pbxImageUpdate.Click += new System.EventHandler(this.pbxImageUpdate_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(12, 9);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(93, 30);
            this.lblBarcode.TabIndex = 32;
            this.lblBarcode.Text = "Barkod :";
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(890, 415);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nbStockUpdate);
            this.Controls.Add(this.nbPriceUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBarkodUpdate);
            this.Controls.Add(this.cbxBrandUpdate);
            this.Controls.Add(this.cbxCategoryUpdate);
            this.Controls.Add(this.tbxTitleUpdate);
            this.Controls.Add(this.pbxImageUpdate);
            this.Controls.Add(this.lblBarcode);
            this.Name = "ProductUpdate";
            this.Text = "ProductUpdate";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbStockUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private NumericUpDown nbStockUpdate;
        private NumericUpDown nbPriceUpdate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxBarkodUpdate;
        private ComboBox cbxBrandUpdate;
        private ComboBox cbxCategoryUpdate;
        private TextBox tbxTitleUpdate;
        private PictureBox pbxImageUpdate;
        private Label lblBarcode;
    }
}