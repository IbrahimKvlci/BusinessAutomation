namespace WindowsFormsApp.Forms
{
    partial class ProductCrudForm
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
            this.btnAddPCF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBrandPCF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategoryPCF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTitlePCF = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tbxBarcodePCF = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productWidget1 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget2 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget3 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget4 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget5 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget6 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget7 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget8 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget9 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget10 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget11 = new WindowsFormsApp.Componenets.ProductWidget();
            this.productWidget12 = new WindowsFormsApp.Componenets.ProductWidget();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddPCF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxBrandPCF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxCategoryPCF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxTitlePCF);
            this.panel1.Controls.Add(this.lblBarcode);
            this.panel1.Controls.Add(this.tbxBarcodePCF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnAddPCF
            // 
            this.btnAddPCF.Location = new System.Drawing.Point(875, 33);
            this.btnAddPCF.Name = "btnAddPCF";
            this.btnAddPCF.Size = new System.Drawing.Size(101, 23);
            this.btnAddPCF.TabIndex = 8;
            this.btnAddPCF.Text = "Ürün Ekle";
            this.btnAddPCF.UseVisualStyleBackColor = true;
            this.btnAddPCF.Click += new System.EventHandler(this.btnAddPCF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(723, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marka";
            // 
            // cbxBrandPCF
            // 
            this.cbxBrandPCF.FormattingEnabled = true;
            this.cbxBrandPCF.Location = new System.Drawing.Point(723, 33);
            this.cbxBrandPCF.Name = "cbxBrandPCF";
            this.cbxBrandPCF.Size = new System.Drawing.Size(121, 23);
            this.cbxBrandPCF.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(572, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori";
            // 
            // cbxCategoryPCF
            // 
            this.cbxCategoryPCF.FormattingEnabled = true;
            this.cbxCategoryPCF.Location = new System.Drawing.Point(572, 33);
            this.cbxCategoryPCF.Name = "cbxCategoryPCF";
            this.cbxCategoryPCF.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoryPCF.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // tbxTitlePCF
            // 
            this.tbxTitlePCF.Location = new System.Drawing.Point(286, 33);
            this.tbxTitlePCF.Name = "tbxTitlePCF";
            this.tbxTitlePCF.Size = new System.Drawing.Size(248, 23);
            this.tbxTitlePCF.TabIndex = 2;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(12, 9);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(59, 21);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Barkod";
            // 
            // tbxBarcodePCF
            // 
            this.tbxBarcodePCF.Location = new System.Drawing.Point(12, 33);
            this.tbxBarcodePCF.Name = "tbxBarcodePCF";
            this.tbxBarcodePCF.Size = new System.Drawing.Size(248, 23);
            this.tbxBarcodePCF.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.productWidget1);
            this.flowLayoutPanel1.Controls.Add(this.productWidget2);
            this.flowLayoutPanel1.Controls.Add(this.productWidget3);
            this.flowLayoutPanel1.Controls.Add(this.productWidget4);
            this.flowLayoutPanel1.Controls.Add(this.productWidget5);
            this.flowLayoutPanel1.Controls.Add(this.productWidget6);
            this.flowLayoutPanel1.Controls.Add(this.productWidget7);
            this.flowLayoutPanel1.Controls.Add(this.productWidget8);
            this.flowLayoutPanel1.Controls.Add(this.productWidget9);
            this.flowLayoutPanel1.Controls.Add(this.productWidget10);
            this.flowLayoutPanel1.Controls.Add(this.productWidget11);
            this.flowLayoutPanel1.Controls.Add(this.productWidget12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 530);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // productWidget1
            // 
            this.productWidget1.Location = new System.Drawing.Point(3, 3);
            this.productWidget1.Name = "productWidget1";
            this.productWidget1.Size = new System.Drawing.Size(219, 301);
            this.productWidget1.TabIndex = 0;
            // 
            // productWidget2
            // 
            this.productWidget2.Location = new System.Drawing.Point(228, 3);
            this.productWidget2.Name = "productWidget2";
            this.productWidget2.Size = new System.Drawing.Size(219, 301);
            this.productWidget2.TabIndex = 1;
            // 
            // productWidget3
            // 
            this.productWidget3.Location = new System.Drawing.Point(453, 3);
            this.productWidget3.Name = "productWidget3";
            this.productWidget3.Size = new System.Drawing.Size(219, 301);
            this.productWidget3.TabIndex = 2;
            // 
            // productWidget4
            // 
            this.productWidget4.Location = new System.Drawing.Point(678, 3);
            this.productWidget4.Name = "productWidget4";
            this.productWidget4.Size = new System.Drawing.Size(219, 301);
            this.productWidget4.TabIndex = 3;
            // 
            // productWidget5
            // 
            this.productWidget5.Location = new System.Drawing.Point(3, 310);
            this.productWidget5.Name = "productWidget5";
            this.productWidget5.Size = new System.Drawing.Size(219, 301);
            this.productWidget5.TabIndex = 4;
            // 
            // productWidget6
            // 
            this.productWidget6.Location = new System.Drawing.Point(228, 310);
            this.productWidget6.Name = "productWidget6";
            this.productWidget6.Size = new System.Drawing.Size(219, 301);
            this.productWidget6.TabIndex = 5;
            // 
            // productWidget7
            // 
            this.productWidget7.Location = new System.Drawing.Point(453, 310);
            this.productWidget7.Name = "productWidget7";
            this.productWidget7.Size = new System.Drawing.Size(219, 301);
            this.productWidget7.TabIndex = 6;
            // 
            // productWidget8
            // 
            this.productWidget8.Location = new System.Drawing.Point(678, 310);
            this.productWidget8.Name = "productWidget8";
            this.productWidget8.Size = new System.Drawing.Size(219, 301);
            this.productWidget8.TabIndex = 7;
            // 
            // productWidget9
            // 
            this.productWidget9.Location = new System.Drawing.Point(3, 617);
            this.productWidget9.Name = "productWidget9";
            this.productWidget9.Size = new System.Drawing.Size(219, 301);
            this.productWidget9.TabIndex = 8;
            // 
            // productWidget10
            // 
            this.productWidget10.Location = new System.Drawing.Point(228, 617);
            this.productWidget10.Name = "productWidget10";
            this.productWidget10.Size = new System.Drawing.Size(219, 301);
            this.productWidget10.TabIndex = 9;
            // 
            // productWidget11
            // 
            this.productWidget11.Location = new System.Drawing.Point(453, 617);
            this.productWidget11.Name = "productWidget11";
            this.productWidget11.Size = new System.Drawing.Size(219, 301);
            this.productWidget11.TabIndex = 10;
            // 
            // productWidget12
            // 
            this.productWidget12.Location = new System.Drawing.Point(678, 617);
            this.productWidget12.Name = "productWidget12";
            this.productWidget12.Size = new System.Drawing.Size(219, 301);
            this.productWidget12.TabIndex = 11;
            // 
            // ProductCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductCrudForm";
            this.Text = "ProductCrudForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblBarcode;
        private TextBox tbxBarcodePCF;
        private Label label3;
        private ComboBox cbxBrandPCF;
        private Label label2;
        private ComboBox cbxCategoryPCF;
        private Label label1;
        private TextBox tbxTitlePCF;
        private FlowLayoutPanel flowLayoutPanel1;
        private Componenets.ProductWidget productWidget1;
        private Componenets.ProductWidget productWidget2;
        private Componenets.ProductWidget productWidget3;
        private Componenets.ProductWidget productWidget4;
        private Componenets.ProductWidget productWidget5;
        private Componenets.ProductWidget productWidget6;
        private Componenets.ProductWidget productWidget7;
        private Componenets.ProductWidget productWidget8;
        private Componenets.ProductWidget productWidget9;
        private Componenets.ProductWidget productWidget10;
        private Componenets.ProductWidget productWidget11;
        private Componenets.ProductWidget productWidget12;
        private Button btnAddPCF;
    }
}