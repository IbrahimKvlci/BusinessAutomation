namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetSalePanel = new System.Windows.Forms.Button();
            this.btnProductCrudPanel = new System.Windows.Forms.Button();
            this.btnMainMenuPanel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnSetSalePanel);
            this.panel2.Controls.Add(this.btnProductCrudPanel);
            this.panel2.Controls.Add(this.btnMainMenuPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 590);
            this.panel2.TabIndex = 1;
            // 
            // btnSetSalePanel
            // 
            this.btnSetSalePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetSalePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetSalePanel.FlatAppearance.BorderSize = 0;
            this.btnSetSalePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSalePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.btnSetSalePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnSetSalePanel.Image")));
            this.btnSetSalePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetSalePanel.Location = new System.Drawing.Point(0, 140);
            this.btnSetSalePanel.Name = "btnSetSalePanel";
            this.btnSetSalePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSetSalePanel.Size = new System.Drawing.Size(125, 70);
            this.btnSetSalePanel.TabIndex = 2;
            this.btnSetSalePanel.Text = "  İndirim/Zam";
            this.btnSetSalePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetSalePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetSalePanel.UseVisualStyleBackColor = true;
            this.btnSetSalePanel.Click += new System.EventHandler(this.btnSetSalePanel_Click);
            // 
            // btnProductCrudPanel
            // 
            this.btnProductCrudPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductCrudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductCrudPanel.FlatAppearance.BorderSize = 0;
            this.btnProductCrudPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCrudPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.btnProductCrudPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnProductCrudPanel.Image")));
            this.btnProductCrudPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductCrudPanel.Location = new System.Drawing.Point(0, 70);
            this.btnProductCrudPanel.Name = "btnProductCrudPanel";
            this.btnProductCrudPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProductCrudPanel.Size = new System.Drawing.Size(125, 70);
            this.btnProductCrudPanel.TabIndex = 1;
            this.btnProductCrudPanel.Text = "  Ürün İşlemleri";
            this.btnProductCrudPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductCrudPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductCrudPanel.UseVisualStyleBackColor = true;
            this.btnProductCrudPanel.Click += new System.EventHandler(this.btnProductCrudPanel_Click);
            // 
            // btnMainMenuPanel
            // 
            this.btnMainMenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMenuPanel.FlatAppearance.BorderSize = 0;
            this.btnMainMenuPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.btnMainMenuPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenuPanel.Image")));
            this.btnMainMenuPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.btnMainMenuPanel.Name = "btnMainMenuPanel";
            this.btnMainMenuPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMainMenuPanel.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenuPanel.TabIndex = 0;
            this.btnMainMenuPanel.Text = "  Ana Menü";
            this.btnMainMenuPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenuPanel.UseVisualStyleBackColor = true;
            this.btnMainMenuPanel.Click += new System.EventHandler(this.btnMainMenuPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.Screenshot_2023_07_30_200821;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 111);
            this.panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(125, 111);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(990, 590);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1115, 701);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Button btnMainMenuPanel;
        private Button btnSetSalePanel;
        private Button btnProductCrudPanel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pnlMain;
    }
}