
namespace ExpressPharmacy
{
    partial class Cart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qntTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusBT = new System.Windows.Forms.Button();
            this.minusBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productTB = new System.Windows.Forms.TextBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.pharmaDataSet = new ExpressPharmacy.pharmaDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ExpressPharmacy.pharmaDataSetTableAdapters.productTableAdapter();
            this.proceedBT = new System.Windows.Forms.Button();
            this.HomeImage = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkoutBTout = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.phonenoTBout = new System.Windows.Forms.TextBox();
            this.fnameTBout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnameTBout = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkoutBTin = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.phonenoTBin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lnameTBin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.fnameTBin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.HomeImage.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // qntTB
            // 
            this.qntTB.BackColor = System.Drawing.SystemColors.Control;
            this.qntTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qntTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.qntTB.Location = new System.Drawing.Point(289, 305);
            this.qntTB.Name = "qntTB";
            this.qntTB.Size = new System.Drawing.Size(75, 22);
            this.qntTB.TabIndex = 1;
            this.qntTB.Text = "1";
            this.qntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(289, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 3);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(171, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qnt.";
            // 
            // plusBT
            // 
            this.plusBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusBT.BackgroundImage")));
            this.plusBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusBT.FlatAppearance.BorderSize = 0;
            this.plusBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBT.Location = new System.Drawing.Point(389, 310);
            this.plusBT.Name = "plusBT";
            this.plusBT.Size = new System.Drawing.Size(20, 18);
            this.plusBT.TabIndex = 4;
            this.plusBT.UseVisualStyleBackColor = true;
            this.plusBT.Click += new System.EventHandler(this.plusBT_Click);
            // 
            // minusBT
            // 
            this.minusBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusBT.BackgroundImage")));
            this.minusBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusBT.FlatAppearance.BorderSize = 0;
            this.minusBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBT.Location = new System.Drawing.Point(244, 316);
            this.minusBT.Name = "minusBT";
            this.minusBT.Size = new System.Drawing.Size(22, 10);
            this.minusBT.TabIndex = 5;
            this.minusBT.UseVisualStyleBackColor = true;
            this.minusBT.Click += new System.EventHandler(this.minusBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(156, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 3);
            this.panel2.TabIndex = 2;
            // 
            // productTB
            // 
            this.productTB.BackColor = System.Drawing.SystemColors.Control;
            this.productTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.productTB.Location = new System.Drawing.Point(156, 62);
            this.productTB.Name = "productTB";
            this.productTB.Size = new System.Drawing.Size(125, 22);
            this.productTB.TabIndex = 3;
            this.productTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBt
            // 
            this.searchBt.BackColor = System.Drawing.SystemColors.Control;
            this.searchBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBt.BackgroundImage")));
            this.searchBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBt.FlatAppearance.BorderSize = 0;
            this.searchBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.searchBt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.searchBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBt.Location = new System.Drawing.Point(333, 65);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(31, 22);
            this.searchBt.TabIndex = 7;
            this.searchBt.UseVisualStyleBackColor = false;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // pharmaDataSet
            // 
            this.pharmaDataSet.DataSetName = "pharmaDataSet";
            this.pharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.pharmaDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // proceedBT
            // 
            this.proceedBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proceedBT.BackgroundImage")));
            this.proceedBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proceedBT.FlatAppearance.BorderSize = 0;
            this.proceedBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBT.Location = new System.Drawing.Point(309, 362);
            this.proceedBT.Name = "proceedBT";
            this.proceedBT.Size = new System.Drawing.Size(39, 36);
            this.proceedBT.TabIndex = 8;
            this.proceedBT.UseVisualStyleBackColor = true;
            this.proceedBT.Click += new System.EventHandler(this.proceedBT_Click);
            // 
            // HomeImage
            // 
            this.HomeImage.Controls.Add(this.label12);
            this.HomeImage.Controls.Add(this.panel10);
            this.HomeImage.Controls.Add(this.dataGridView1);
            this.HomeImage.Controls.Add(this.proceedBT);
            this.HomeImage.Controls.Add(this.qntTB);
            this.HomeImage.Controls.Add(this.searchBt);
            this.HomeImage.Controls.Add(this.panel1);
            this.HomeImage.Controls.Add(this.panel2);
            this.HomeImage.Controls.Add(this.label1);
            this.HomeImage.Controls.Add(this.minusBT);
            this.HomeImage.Controls.Add(this.label2);
            this.HomeImage.Controls.Add(this.productTB);
            this.HomeImage.Controls.Add(this.plusBT);
            this.HomeImage.Location = new System.Drawing.Point(0, 0);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(647, 410);
            this.HomeImage.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.SandyBrown;
            this.label12.Location = new System.Drawing.Point(282, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 32);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cart";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(647, 410);
            this.panel10.TabIndex = 9;
            this.panel10.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.checkoutBTout);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.addressTB);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.phonenoTBout);
            this.panel3.Controls.Add(this.fnameTBout);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lnameTBout);
            this.panel3.Location = new System.Drawing.Point(333, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 386);
            this.panel3.TabIndex = 5;
            // 
            // checkoutBTout
            // 
            this.checkoutBTout.BackColor = System.Drawing.Color.DarkRed;
            this.checkoutBTout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkoutBTout.BackgroundImage")));
            this.checkoutBTout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutBTout.FlatAppearance.BorderSize = 0;
            this.checkoutBTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBTout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkoutBTout.Location = new System.Drawing.Point(134, 314);
            this.checkoutBTout.Name = "checkoutBTout";
            this.checkoutBTout.Size = new System.Drawing.Size(55, 47);
            this.checkoutBTout.TabIndex = 14;
            this.checkoutBTout.UseVisualStyleBackColor = false;
            this.checkoutBTout.Visible = false;
            this.checkoutBTout.Click += new System.EventHandler(this.checkoutBTout_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(125, 287);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 3);
            this.panel9.TabIndex = 24;
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.DarkRed;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addressTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addressTB.Location = new System.Drawing.Point(125, 265);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(145, 22);
            this.addressTB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(32, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delivery";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Location = new System.Drawing.Point(125, 231);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 3);
            this.panel6.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(23, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "First Name";
            // 
            // phonenoTBout
            // 
            this.phonenoTBout.BackColor = System.Drawing.Color.DarkRed;
            this.phonenoTBout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenoTBout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.phonenoTBout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phonenoTBout.Location = new System.Drawing.Point(125, 209);
            this.phonenoTBout.Name = "phonenoTBout";
            this.phonenoTBout.Size = new System.Drawing.Size(145, 22);
            this.phonenoTBout.TabIndex = 21;
            // 
            // fnameTBout
            // 
            this.fnameTBout.BackColor = System.Drawing.Color.DarkRed;
            this.fnameTBout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTBout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fnameTBout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fnameTBout.Location = new System.Drawing.Point(134, 90);
            this.fnameTBout.Name = "fnameTBout";
            this.fnameTBout.Size = new System.Drawing.Size(125, 22);
            this.fnameTBout.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(28, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone No.";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(134, 112);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 3);
            this.panel8.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(134, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 3);
            this.panel7.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(24, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last Name";
            // 
            // lnameTBout
            // 
            this.lnameTBout.BackColor = System.Drawing.Color.DarkRed;
            this.lnameTBout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTBout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lnameTBout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lnameTBout.Location = new System.Drawing.Point(134, 150);
            this.lnameTBout.Name = "lnameTBout";
            this.lnameTBout.Size = new System.Drawing.Size(125, 22);
            this.lnameTBout.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.checkoutBTin);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.phonenoTBin);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.lnameTBin);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.fnameTBin);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(25, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 386);
            this.panel4.TabIndex = 4;
            // 
            // checkoutBTin
            // 
            this.checkoutBTin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkoutBTin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkoutBTin.BackgroundImage")));
            this.checkoutBTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutBTin.FlatAppearance.BorderSize = 0;
            this.checkoutBTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBTin.Location = new System.Drawing.Point(129, 314);
            this.checkoutBTin.Name = "checkoutBTin";
            this.checkoutBTin.Size = new System.Drawing.Size(55, 47);
            this.checkoutBTin.TabIndex = 13;
            this.checkoutBTin.UseVisualStyleBackColor = false;
            this.checkoutBTin.Visible = false;
            this.checkoutBTin.Click += new System.EventHandler(this.checkoutBTin_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(120, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 3);
            this.panel5.TabIndex = 10;
            // 
            // phonenoTBin
            // 
            this.phonenoTBin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phonenoTBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenoTBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.phonenoTBin.Location = new System.Drawing.Point(120, 240);
            this.phonenoTBin.Name = "phonenoTBin";
            this.phonenoTBin.Size = new System.Drawing.Size(145, 22);
            this.phonenoTBin.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label5.Location = new System.Drawing.Point(21, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone No.";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel11.Location = new System.Drawing.Point(129, 194);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(125, 3);
            this.panel11.TabIndex = 7;
            // 
            // lnameTBin
            // 
            this.lnameTBin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lnameTBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lnameTBin.Location = new System.Drawing.Point(129, 172);
            this.lnameTBin.Name = "lnameTBin";
            this.lnameTBin.Size = new System.Drawing.Size(125, 22);
            this.lnameTBin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel12.Location = new System.Drawing.Point(129, 129);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(125, 3);
            this.panel12.TabIndex = 4;
            // 
            // fnameTBin
            // 
            this.fnameTBin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fnameTBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fnameTBin.Location = new System.Drawing.Point(129, 107);
            this.fnameTBin.Name = "fnameTBin";
            this.fnameTBin.Size = new System.Drawing.Size(125, 22);
            this.fnameTBin.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label10.Location = new System.Drawing.Point(17, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "In-Store Pickup";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.HomeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.HomeImage.ResumeLayout(false);
            this.HomeImage.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox qntTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plusBT;
        private System.Windows.Forms.Button minusBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox productTB;
        private System.Windows.Forms.Button searchBt;
        private pharmaDataSet pharmaDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private pharmaDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Button proceedBT;
        private System.Windows.Forms.Panel HomeImage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button checkoutBTout;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phonenoTBout;
        private System.Windows.Forms.TextBox fnameTBout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lnameTBout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button checkoutBTin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox phonenoTBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox lnameTBin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox fnameTBin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}