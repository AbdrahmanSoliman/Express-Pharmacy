
namespace ExpressPharmacy
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBt = new System.Windows.Forms.Button();
            this.supplyIconBt = new System.Windows.Forms.Button();
            this.expiredIconBt = new System.Windows.Forms.Button();
            this.cartIconBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.exitBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolbarControl);
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.SystemColors.GrayText;
            this.exitBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBt.BackgroundImage")));
            this.exitBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBt.FlatAppearance.BorderSize = 0;
            this.exitBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.exitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBt.Location = new System.Drawing.Point(761, 8);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(27, 26);
            this.exitBt.TabIndex = 9;
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.logoutBt);
            this.panel2.Controls.Add(this.supplyIconBt);
            this.panel2.Controls.Add(this.expiredIconBt);
            this.panel2.Controls.Add(this.cartIconBt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 410);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SideToolbarControl);
            // 
            // logoutBt
            // 
            this.logoutBt.BackColor = System.Drawing.SystemColors.GrayText;
            this.logoutBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBt.BackgroundImage")));
            this.logoutBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBt.FlatAppearance.BorderSize = 0;
            this.logoutBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.logoutBt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.logoutBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBt.Location = new System.Drawing.Point(4, 375);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(35, 32);
            this.logoutBt.TabIndex = 9;
            this.logoutBt.UseVisualStyleBackColor = false;
            this.logoutBt.Click += new System.EventHandler(this.logoutBt_Click);
            // 
            // supplyIconBt
            // 
            this.supplyIconBt.BackColor = System.Drawing.SystemColors.GrayText;
            this.supplyIconBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplyIconBt.BackgroundImage")));
            this.supplyIconBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplyIconBt.FlatAppearance.BorderSize = 0;
            this.supplyIconBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.supplyIconBt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.supplyIconBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplyIconBt.Location = new System.Drawing.Point(51, 271);
            this.supplyIconBt.Name = "supplyIconBt";
            this.supplyIconBt.Size = new System.Drawing.Size(55, 47);
            this.supplyIconBt.TabIndex = 8;
            this.supplyIconBt.UseVisualStyleBackColor = false;
            this.supplyIconBt.Click += new System.EventHandler(this.supplyIconBt_Click);
            // 
            // expiredIconBt
            // 
            this.expiredIconBt.BackColor = System.Drawing.SystemColors.GrayText;
            this.expiredIconBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expiredIconBt.BackgroundImage")));
            this.expiredIconBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expiredIconBt.FlatAppearance.BorderSize = 0;
            this.expiredIconBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.expiredIconBt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.expiredIconBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expiredIconBt.Location = new System.Drawing.Point(51, 208);
            this.expiredIconBt.Name = "expiredIconBt";
            this.expiredIconBt.Size = new System.Drawing.Size(55, 47);
            this.expiredIconBt.TabIndex = 7;
            this.expiredIconBt.UseVisualStyleBackColor = false;
            this.expiredIconBt.Click += new System.EventHandler(this.expiredIconBt_Click);
            // 
            // cartIconBt
            // 
            this.cartIconBt.BackColor = System.Drawing.SystemColors.GrayText;
            this.cartIconBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartIconBt.BackgroundImage")));
            this.cartIconBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartIconBt.FlatAppearance.BorderSize = 0;
            this.cartIconBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.cartIconBt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.cartIconBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartIconBt.Location = new System.Drawing.Point(51, 145);
            this.cartIconBt.Name = "cartIconBt";
            this.cartIconBt.Size = new System.Drawing.Size(55, 47);
            this.cartIconBt.TabIndex = 6;
            this.cartIconBt.UseVisualStyleBackColor = false;
            this.cartIconBt.Click += new System.EventHandler(this.cartIconBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HomeImage
            // 
            this.HomeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeImage.Image = ((System.Drawing.Image)(resources.GetObject("HomeImage.Image")));
            this.HomeImage.Location = new System.Drawing.Point(153, 40);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(647, 410);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeImage.TabIndex = 2;
            this.HomeImage.TabStop = false;
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button supplyIconBt;
        private System.Windows.Forms.Button expiredIconBt;
        private System.Windows.Forms.Button cartIconBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.PictureBox HomeImage;
    }
}

