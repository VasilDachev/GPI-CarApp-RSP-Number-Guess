namespace CarApp
{
    partial class MainForm
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
            this.pbGallery = new System.Windows.Forms.PictureBox();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.rbVW = new System.Windows.Forms.RadioButton();
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChains = new System.Windows.Forms.CheckBox();
            this.cbLights = new System.Windows.Forms.CheckBox();
            this.cbABS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbExtras = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckD = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGallery
            // 
            this.pbGallery.Image = global::CarApp.Properties.Resources.Audi;
            this.pbGallery.Location = new System.Drawing.Point(12, 12);
            this.pbGallery.Name = "pbGallery";
            this.pbGallery.Size = new System.Drawing.Size(653, 380);
            this.pbGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGallery.TabIndex = 0;
            this.pbGallery.TabStop = false;
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMercedes.Location = new System.Drawing.Point(27, 41);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(138, 26);
            this.rbMercedes.TabIndex = 1;
            this.rbMercedes.TabStop = true;
            this.rbMercedes.Text = "Mercedes-Benz";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // rbVW
            // 
            this.rbVW.AutoSize = true;
            this.rbVW.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVW.Location = new System.Drawing.Point(27, 73);
            this.rbVW.Name = "rbVW";
            this.rbVW.Size = new System.Drawing.Size(114, 26);
            this.rbVW.TabIndex = 1;
            this.rbVW.TabStop = true;
            this.rbVW.Text = "Volkswagen";
            this.rbVW.UseVisualStyleBackColor = true;
            this.rbVW.CheckedChanged += new System.EventHandler(this.rbVW_CheckedChanged);
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAudi.Location = new System.Drawing.Point(27, 105);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(63, 26);
            this.rbAudi.TabIndex = 1;
            this.rbAudi.TabStop = true;
            this.rbAudi.Text = "Audi";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Price:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(804, 419);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(60, 24);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "0.000$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMercedes);
            this.groupBox1.Controls.Add(this.rbVW);
            this.groupBox1.Controls.Add(this.rbAudi);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(676, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Car Model:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbChains);
            this.groupBox2.Controls.Add(this.cbLights);
            this.groupBox2.Controls.Add(this.cbABS);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 144);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbChains
            // 
            this.cbChains.AutoSize = true;
            this.cbChains.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChains.Location = new System.Drawing.Point(21, 102);
            this.cbChains.Name = "cbChains";
            this.cbChains.Size = new System.Drawing.Size(108, 26);
            this.cbChains.TabIndex = 0;
            this.cbChains.Text = "Car Chains";
            this.cbChains.UseVisualStyleBackColor = true;
            this.cbChains.CheckedChanged += new System.EventHandler(this.cbChains_CheckedChanged);
            // 
            // cbLights
            // 
            this.cbLights.AutoSize = true;
            this.cbLights.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLights.Location = new System.Drawing.Point(21, 70);
            this.cbLights.Name = "cbLights";
            this.cbLights.Size = new System.Drawing.Size(107, 26);
            this.cbLights.TabIndex = 0;
            this.cbLights.Text = "Fog Lights";
            this.cbLights.UseVisualStyleBackColor = true;
            this.cbLights.CheckedChanged += new System.EventHandler(this.cbLights_CheckedChanged);
            // 
            // cbABS
            // 
            this.cbABS.AutoSize = true;
            this.cbABS.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbABS.Location = new System.Drawing.Point(21, 38);
            this.cbABS.Name = "cbABS";
            this.cbABS.Size = new System.Drawing.Size(61, 26);
            this.cbABS.TabIndex = 0;
            this.cbABS.Text = "ABS";
            this.cbABS.UseVisualStyleBackColor = true;
            this.cbABS.CheckedChanged += new System.EventHandler(this.cbABS_CheckedChanged);
            this.cbABS.CheckStateChanged += new System.EventHandler(this.cbABS_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Extras:";
            // 
            // lbExtras
            // 
            this.lbExtras.AutoSize = true;
            this.lbExtras.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtras.Location = new System.Drawing.Point(810, 443);
            this.lbExtras.Name = "lbExtras";
            this.lbExtras.Size = new System.Drawing.Size(54, 22);
            this.lbExtras.TabIndex = 8;
            this.lbExtras.Text = "0.000$";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCredit);
            this.groupBox3.Controls.Add(this.rbCheck);
            this.groupBox3.Controls.Add(this.rbCash);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(263, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 144);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Method:";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredit.Location = new System.Drawing.Point(24, 101);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(106, 26);
            this.rbCredit.TabIndex = 0;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "CreditCard";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheck.Location = new System.Drawing.Point(24, 69);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(74, 26);
            this.rbCheck.TabIndex = 0;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Check";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(24, 42);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(66, 26);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Price:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(802, 499);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(92, 35);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "0.000$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(726, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Discount:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(810, 465);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(54, 22);
            this.lbDiscount.TabIndex = 8;
            this.lbDiscount.Text = "0.000$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCheckD
            // 
            this.btnCheckD.Location = new System.Drawing.Point(194, 548);
            this.btnCheckD.Name = "btnCheckD";
            this.btnCheckD.Size = new System.Drawing.Size(106, 48);
            this.btnCheckD.TabIndex = 13;
            this.btnCheckD.Text = "Check Discount";
            this.btnCheckD.UseVisualStyleBackColor = true;
            this.btnCheckD.Click += new System.EventHandler(this.btnCheckD_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.Location = new System.Drawing.Point(536, 398);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(102, 198);
            this.btnTotalPrice.TabIndex = 14;
            this.btnTotalPrice.Text = "Total Price";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(929, 608);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.btnCheckD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbExtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGallery);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGallery;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.RadioButton rbVW;
        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbChains;
        private System.Windows.Forms.CheckBox cbLights;
        private System.Windows.Forms.CheckBox cbABS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExtras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckD;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}

