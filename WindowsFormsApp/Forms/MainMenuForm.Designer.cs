namespace WindowsFormsApp.Forms
{
    partial class MainMenuForm
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.pbxImageMMF = new System.Windows.Forms.PictureBox();
            this.tbxTitleMMF = new System.Windows.Forms.TextBox();
            this.cbxCategoryMMF = new System.Windows.Forms.ComboBox();
            this.cbxBrandMMF = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxBarkodMMF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbPriceMMF = new System.Windows.Forms.NumericUpDown();
            this.nbStockMMF = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteMMF = new System.Windows.Forms.Button();
            this.btnUpdateMMF = new System.Windows.Forms.Button();
            this.lblProductInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageMMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceMMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbStockMMF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(12, 35);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(93, 30);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Barkod :";
            this.lblBarcode.Click += new System.EventHandler(this.lblBarcode_Click);
            // 
            // pbxImageMMF
            // 
            this.pbxImageMMF.Location = new System.Drawing.Point(12, 131);
            this.pbxImageMMF.Name = "pbxImageMMF";
            this.pbxImageMMF.Size = new System.Drawing.Size(207, 211);
            this.pbxImageMMF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageMMF.TabIndex = 2;
            this.pbxImageMMF.TabStop = false;
            // 
            // tbxTitleMMF
            // 
            this.tbxTitleMMF.Location = new System.Drawing.Point(307, 131);
            this.tbxTitleMMF.Name = "tbxTitleMMF";
            this.tbxTitleMMF.Size = new System.Drawing.Size(560, 23);
            this.tbxTitleMMF.TabIndex = 3;
            // 
            // cbxCategoryMMF
            // 
            this.cbxCategoryMMF.FormattingEnabled = true;
            this.cbxCategoryMMF.Location = new System.Drawing.Point(717, 221);
            this.cbxCategoryMMF.Name = "cbxCategoryMMF";
            this.cbxCategoryMMF.Size = new System.Drawing.Size(150, 23);
            this.cbxCategoryMMF.TabIndex = 4;
            this.cbxCategoryMMF.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryMMF_SelectedIndexChanged);
            // 
            // cbxBrandMMF
            // 
            this.cbxBrandMMF.FormattingEnabled = true;
            this.cbxBrandMMF.Location = new System.Drawing.Point(717, 176);
            this.cbxBrandMMF.Name = "cbxBrandMMF";
            this.cbxBrandMMF.Size = new System.Drawing.Size(150, 23);
            this.cbxBrandMMF.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 0);
            this.button1.TabIndex = 7;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 0);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbxBarkodMMF
            // 
            this.tbxBarkodMMF.Location = new System.Drawing.Point(111, 42);
            this.tbxBarkodMMF.Name = "tbxBarkodMMF";
            this.tbxBarkodMMF.Size = new System.Drawing.Size(756, 23);
            this.tbxBarkodMMF.TabIndex = 9;
            this.tbxBarkodMMF.TextChanged += new System.EventHandler(this.tbxBarkodMMF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(634, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(634, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(634, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Adet :";
            // 
            // nbPriceMMF
            // 
            this.nbPriceMMF.Location = new System.Drawing.Point(718, 271);
            this.nbPriceMMF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbPriceMMF.Name = "nbPriceMMF";
            this.nbPriceMMF.Size = new System.Drawing.Size(149, 23);
            this.nbPriceMMF.TabIndex = 15;
            this.nbPriceMMF.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nbStockMMF
            // 
            this.nbStockMMF.Location = new System.Drawing.Point(718, 317);
            this.nbStockMMF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbStockMMF.Name = "nbStockMMF";
            this.nbStockMMF.Size = new System.Drawing.Size(149, 23);
            this.nbStockMMF.TabIndex = 16;
            // 
            // btnDeleteMMF
            // 
            this.btnDeleteMMF.Location = new System.Drawing.Point(747, 372);
            this.btnDeleteMMF.Name = "btnDeleteMMF";
            this.btnDeleteMMF.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteMMF.TabIndex = 17;
            this.btnDeleteMMF.Text = "Sil";
            this.btnDeleteMMF.UseVisualStyleBackColor = true;
            this.btnDeleteMMF.Click += new System.EventHandler(this.btnDeleteMMF_Click);
            // 
            // btnUpdateMMF
            // 
            this.btnUpdateMMF.Location = new System.Drawing.Point(611, 372);
            this.btnUpdateMMF.Name = "btnUpdateMMF";
            this.btnUpdateMMF.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateMMF.TabIndex = 18;
            this.btnUpdateMMF.Text = "Güncelle";
            this.btnUpdateMMF.UseVisualStyleBackColor = true;
            this.btnUpdateMMF.Click += new System.EventHandler(this.btnUpdateMMF_Click);
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProductInfo.Location = new System.Drawing.Point(12, 389);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(0, 25);
            this.lblProductInfo.TabIndex = 19;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(884, 438);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.btnUpdateMMF);
            this.Controls.Add(this.btnDeleteMMF);
            this.Controls.Add(this.nbStockMMF);
            this.Controls.Add(this.nbPriceMMF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBarkodMMF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxBrandMMF);
            this.Controls.Add(this.cbxCategoryMMF);
            this.Controls.Add(this.tbxTitleMMF);
            this.Controls.Add(this.pbxImageMMF);
            this.Controls.Add(this.lblBarcode);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageMMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPriceMMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbStockMMF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblBarcode;
        private PictureBox pbxImageMMF;
        private TextBox tbxTitleMMF;
        private ComboBox cbxCategoryMMF;
        private ComboBox cbxBrandMMF;
        private Button button1;
        private Button button2;
        private TextBox tbxBarkodMMF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nbPriceMMF;
        private NumericUpDown nbStockMMF;
        private Button btnDeleteMMF;
        private Button btnUpdateMMF;
        private Label lblProductInfo;
    }
}