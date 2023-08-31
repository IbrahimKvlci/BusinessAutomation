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
            this.panel1.SuspendLayout();
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
            this.cbxBrandPCF.SelectedIndexChanged += new System.EventHandler(this.cbxBrandPCF_SelectedIndexChanged);
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
            this.cbxCategoryPCF.Items.AddRange(new object[] {
            "Tumu"});
            this.cbxCategoryPCF.Location = new System.Drawing.Point(572, 33);
            this.cbxCategoryPCF.Name = "cbxCategoryPCF";
            this.cbxCategoryPCF.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoryPCF.TabIndex = 4;
            this.cbxCategoryPCF.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryPCF_SelectedIndexChanged);
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
            this.tbxTitlePCF.TextChanged += new System.EventHandler(this.tbxTitlePCF_TextChanged);
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
            this.tbxBarcodePCF.TextChanged += new System.EventHandler(this.tbxBarcodePCF_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 530);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.Load += new System.EventHandler(this.ProductCrudForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Button btnAddPCF;
    }
}