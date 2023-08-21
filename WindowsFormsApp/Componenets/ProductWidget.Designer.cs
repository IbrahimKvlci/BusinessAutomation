namespace WindowsFormsApp.Componenets
{
    partial class ProductWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.lblBrandProduct = new System.Windows.Forms.Label();
            this.lblCategoryProduct = new System.Windows.Forms.Label();
            this.lblTitleProduct = new System.Windows.Forms.Label();
            this.pbxImageProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.btnUpdateProduct);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.lblPriceProduct);
            this.panel1.Controls.Add(this.lblBrandProduct);
            this.panel1.Controls.Add(this.lblCategoryProduct);
            this.panel1.Controls.Add(this.lblTitleProduct);
            this.panel1.Controls.Add(this.pbxImageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 301);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(46, 265);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 6;
            this.btnUpdateProduct.Text = "Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(127, 265);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.lblPriceProduct.Location = new System.Drawing.Point(164, 227);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(35, 15);
            this.lblPriceProduct.TabIndex = 4;
            this.lblPriceProduct.Text = "Price";
            // 
            // lblBrandProduct
            // 
            this.lblBrandProduct.AutoSize = true;
            this.lblBrandProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandProduct.Location = new System.Drawing.Point(3, 227);
            this.lblBrandProduct.Name = "lblBrandProduct";
            this.lblBrandProduct.Size = new System.Drawing.Size(40, 15);
            this.lblBrandProduct.TabIndex = 3;
            this.lblBrandProduct.Text = "Brand";
            // 
            // lblCategoryProduct
            // 
            this.lblCategoryProduct.AutoSize = true;
            this.lblCategoryProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryProduct.Location = new System.Drawing.Point(3, 197);
            this.lblCategoryProduct.Name = "lblCategoryProduct";
            this.lblCategoryProduct.Size = new System.Drawing.Size(57, 15);
            this.lblCategoryProduct.TabIndex = 2;
            this.lblCategoryProduct.Text = "Category";
            // 
            // lblTitleProduct
            // 
            this.lblTitleProduct.AutoSize = true;
            this.lblTitleProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleProduct.Location = new System.Drawing.Point(3, 147);
            this.lblTitleProduct.MaximumSize = new System.Drawing.Size(200, 50);
            this.lblTitleProduct.Name = "lblTitleProduct";
            this.lblTitleProduct.Size = new System.Drawing.Size(199, 50);
            this.lblTitleProduct.TabIndex = 1;
            this.lblTitleProduct.Text = "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss" +
    "sssssssss";
            // 
            // pbxImageProduct
            // 
            this.pbxImageProduct.AccessibleName = "deneme";
            this.pbxImageProduct.Location = new System.Drawing.Point(3, 3);
            this.pbxImageProduct.Name = "pbxImageProduct";
            this.pbxImageProduct.Size = new System.Drawing.Size(213, 141);
            this.pbxImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageProduct.TabIndex = 0;
            this.pbxImageProduct.TabStop = false;
            // 
            // ProductWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProductWidget";
            this.Size = new System.Drawing.Size(219, 301);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Label lblPriceProduct;
        private Label lblBrandProduct;
        private Label lblCategoryProduct;
        private Label lblTitleProduct;
        private PictureBox pbxImageProduct;
    }
}
