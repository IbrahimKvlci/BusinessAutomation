namespace WindowsFormsApp.Forms
{
    partial class SetSaleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.btnApplyBrand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nmValueBrand = new System.Windows.Forms.NumericUpDown();
            this.cbxSaleBrand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnApplyCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmValueCategory = new System.Windows.Forms.NumericUpDown();
            this.cbxSaleCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmValueAll = new System.Windows.Forms.NumericUpDown();
            this.cbxSaleAll = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxBrand);
            this.panel1.Controls.Add(this.btnApplyBrand);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nmValueBrand);
            this.panel1.Controls.Add(this.cbxSaleBrand);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxCategory);
            this.panel1.Controls.Add(this.btnApplyCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nmValueCategory);
            this.panel1.Controls.Add(this.cbxSaleCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnApplyAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nmValueAll);
            this.panel1.Controls.Add(this.cbxSaleAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 557);
            this.panel1.TabIndex = 0;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(575, 132);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 23);
            this.cbxBrand.TabIndex = 16;
            // 
            // btnApplyBrand
            // 
            this.btnApplyBrand.Location = new System.Drawing.Point(620, 211);
            this.btnApplyBrand.Name = "btnApplyBrand";
            this.btnApplyBrand.Size = new System.Drawing.Size(75, 23);
            this.btnApplyBrand.TabIndex = 15;
            this.btnApplyBrand.Text = "Uygula";
            this.btnApplyBrand.UseVisualStyleBackColor = true;
            this.btnApplyBrand.Click += new System.EventHandler(this.btnApplyBrand_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(541, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // nmValueBrand
            // 
            this.nmValueBrand.Location = new System.Drawing.Point(575, 172);
            this.nmValueBrand.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValueBrand.Name = "nmValueBrand";
            this.nmValueBrand.Size = new System.Drawing.Size(120, 23);
            this.nmValueBrand.TabIndex = 13;
            // 
            // cbxSaleBrand
            // 
            this.cbxSaleBrand.FormattingEnabled = true;
            this.cbxSaleBrand.Items.AddRange(new object[] {
            "İndirim",
            "Zam"});
            this.cbxSaleBrand.Location = new System.Drawing.Point(575, 92);
            this.cbxSaleBrand.Name = "cbxSaleBrand";
            this.cbxSaleBrand.Size = new System.Drawing.Size(121, 23);
            this.cbxSaleBrand.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(552, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Markaya Göre Uygula";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(314, 132);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxCategory.TabIndex = 10;
            // 
            // btnApplyCategory
            // 
            this.btnApplyCategory.Location = new System.Drawing.Point(359, 211);
            this.btnApplyCategory.Name = "btnApplyCategory";
            this.btnApplyCategory.Size = new System.Drawing.Size(75, 23);
            this.btnApplyCategory.TabIndex = 9;
            this.btnApplyCategory.Text = "Uygula";
            this.btnApplyCategory.UseVisualStyleBackColor = true;
            this.btnApplyCategory.Click += new System.EventHandler(this.btnApplyCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(280, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "%";
            // 
            // nmValueCategory
            // 
            this.nmValueCategory.Location = new System.Drawing.Point(314, 172);
            this.nmValueCategory.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValueCategory.Name = "nmValueCategory";
            this.nmValueCategory.Size = new System.Drawing.Size(120, 23);
            this.nmValueCategory.TabIndex = 7;
            // 
            // cbxSaleCategory
            // 
            this.cbxSaleCategory.FormattingEnabled = true;
            this.cbxSaleCategory.Items.AddRange(new object[] {
            "İndirim",
            "Zam"});
            this.cbxSaleCategory.Location = new System.Drawing.Point(314, 92);
            this.cbxSaleCategory.Name = "cbxSaleCategory";
            this.cbxSaleCategory.Size = new System.Drawing.Size(121, 23);
            this.cbxSaleCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(291, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategoriye Göre Uygula";
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.Location = new System.Drawing.Point(95, 172);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(75, 23);
            this.btnApplyAll.TabIndex = 4;
            this.btnApplyAll.Text = "Uygula";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            this.btnApplyAll.Click += new System.EventHandler(this.btnApplyAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // nmValueAll
            // 
            this.nmValueAll.Location = new System.Drawing.Point(50, 133);
            this.nmValueAll.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmValueAll.Name = "nmValueAll";
            this.nmValueAll.Size = new System.Drawing.Size(120, 23);
            this.nmValueAll.TabIndex = 2;
            // 
            // cbxSaleAll
            // 
            this.cbxSaleAll.FormattingEnabled = true;
            this.cbxSaleAll.Items.AddRange(new object[] {
            "İndirim",
            "Zam"});
            this.cbxSaleAll.Location = new System.Drawing.Point(50, 92);
            this.cbxSaleAll.Name = "cbxSaleAll";
            this.cbxSaleAll.Size = new System.Drawing.Size(121, 23);
            this.cbxSaleAll.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Ürünlere Uygula";
            // 
            // SetSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(889, 557);
            this.Controls.Add(this.panel1);
            this.Name = "SetSaleForm";
            this.Text = "SetSaleForm";
            this.Load += new System.EventHandler(this.SetSaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cbxBrand;
        private Button btnApplyBrand;
        private Label label5;
        private NumericUpDown nmValueBrand;
        private ComboBox cbxSaleBrand;
        private Label label6;
        private ComboBox cbxCategory;
        private Button btnApplyCategory;
        private Label label3;
        private NumericUpDown nmValueCategory;
        private ComboBox cbxSaleCategory;
        private Label label4;
        private Button btnApplyAll;
        private Label label2;
        private NumericUpDown nmValueAll;
        private ComboBox cbxSaleAll;
        private Label label1;
    }
}