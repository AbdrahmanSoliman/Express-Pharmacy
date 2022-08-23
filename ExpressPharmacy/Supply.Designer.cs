
namespace ExpressPharmacy
{
    partial class Supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateBT = new System.Windows.Forms.Button();
            this.restockBT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.qntTB = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.catTB = new System.Windows.Forms.TextBox();
            this.supplyBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.newPriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.newProdTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newQntTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Restocking a product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.updateBT);
            this.panel1.Controls.Add(this.restockBT);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.priceTB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.qntTB);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productTB);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(53, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 171);
            this.panel1.TabIndex = 9;
            // 
            // updateBT
            // 
            this.updateBT.BackColor = System.Drawing.Color.PeachPuff;
            this.updateBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBT.BackgroundImage")));
            this.updateBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBT.FlatAppearance.BorderSize = 0;
            this.updateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBT.Location = new System.Drawing.Point(391, 122);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(32, 28);
            this.updateBT.TabIndex = 16;
            this.updateBT.UseVisualStyleBackColor = false;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // restockBT
            // 
            this.restockBT.BackColor = System.Drawing.Color.PeachPuff;
            this.restockBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restockBT.BackgroundImage")));
            this.restockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restockBT.FlatAppearance.BorderSize = 0;
            this.restockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockBT.Location = new System.Drawing.Point(464, 40);
            this.restockBT.Name = "restockBT";
            this.restockBT.Size = new System.Drawing.Size(32, 28);
            this.restockBT.TabIndex = 15;
            this.restockBT.UseVisualStyleBackColor = false;
            this.restockBT.Click += new System.EventHandler(this.restockBT_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(248, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 3);
            this.panel4.TabIndex = 13;
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.Color.PeachPuff;
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.priceTB.Location = new System.Drawing.Point(248, 122);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(95, 22);
            this.priceTB.TabIndex = 14;
            this.priceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(163, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 3);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label3.Location = new System.Drawing.Point(147, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Price";
            // 
            // qntTB
            // 
            this.qntTB.BackColor = System.Drawing.Color.PeachPuff;
            this.qntTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qntTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.qntTB.Location = new System.Drawing.Point(163, 57);
            this.qntTB.Name = "qntTB";
            this.qntTB.Size = new System.Drawing.Size(59, 22);
            this.qntTB.TabIndex = 11;
            this.qntTB.Text = "1";
            this.qntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel12.Location = new System.Drawing.Point(127, 40);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(125, 3);
            this.panel12.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // productTB
            // 
            this.productTB.BackColor = System.Drawing.Color.PeachPuff;
            this.productTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.productTB.Location = new System.Drawing.Point(127, 18);
            this.productTB.Name = "productTB";
            this.productTB.Size = new System.Drawing.Size(125, 22);
            this.productTB.TabIndex = 8;
            this.productTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label10.Location = new System.Drawing.Point(26, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.catTB);
            this.panel2.Controls.Add(this.supplyBt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.newPriceTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.newProdTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.newQntTB);
            this.panel2.Location = new System.Drawing.Point(53, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 171);
            this.panel2.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(248, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(59, 3);
            this.panel8.TabIndex = 21;
            // 
            // catTB
            // 
            this.catTB.BackColor = System.Drawing.Color.Peru;
            this.catTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.catTB.Location = new System.Drawing.Point(248, 136);
            this.catTB.Name = "catTB";
            this.catTB.Size = new System.Drawing.Size(59, 22);
            this.catTB.TabIndex = 22;
            this.catTB.Text = "1";
            this.catTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // supplyBt
            // 
            this.supplyBt.BackColor = System.Drawing.Color.Peru;
            this.supplyBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplyBt.BackgroundImage")));
            this.supplyBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplyBt.FlatAppearance.BorderSize = 0;
            this.supplyBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplyBt.Location = new System.Drawing.Point(443, 77);
            this.supplyBt.Name = "supplyBt";
            this.supplyBt.Size = new System.Drawing.Size(53, 47);
            this.supplyBt.TabIndex = 17;
            this.supplyBt.UseVisualStyleBackColor = false;
            this.supplyBt.Click += new System.EventHandler(this.supplyBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(111, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Category";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(230, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 3);
            this.panel5.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(213, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 3);
            this.panel7.TabIndex = 16;
            // 
            // newPriceTB
            // 
            this.newPriceTB.BackColor = System.Drawing.Color.Peru;
            this.newPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.newPriceTB.Location = new System.Drawing.Point(230, 102);
            this.newPriceTB.Name = "newPriceTB";
            this.newPriceTB.Size = new System.Drawing.Size(95, 22);
            this.newPriceTB.TabIndex = 23;
            this.newPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(96, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "New Product";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Location = new System.Drawing.Point(249, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(59, 3);
            this.panel6.TabIndex = 19;
            // 
            // newProdTB
            // 
            this.newProdTB.BackColor = System.Drawing.Color.Peru;
            this.newProdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newProdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.newProdTB.Location = new System.Drawing.Point(213, 25);
            this.newProdTB.Name = "newProdTB";
            this.newProdTB.Size = new System.Drawing.Size(125, 22);
            this.newProdTB.TabIndex = 17;
            this.newProdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(124, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(112, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantity";
            // 
            // newQntTB
            // 
            this.newQntTB.BackColor = System.Drawing.Color.Peru;
            this.newQntTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newQntTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.newQntTB.Location = new System.Drawing.Point(249, 65);
            this.newQntTB.Name = "newQntTB";
            this.newQntTB.Size = new System.Drawing.Size(59, 22);
            this.newQntTB.TabIndex = 20;
            this.newQntTB.Text = "1";
            this.newQntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supply";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox productTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qntTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restockBT;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox newPriceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox newProdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newQntTB;
        private System.Windows.Forms.Button supplyBt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox catTB;
        private System.Windows.Forms.Label label7;
    }
}