namespace WageCalculator
{
    partial class UserControl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioYukon = new System.Windows.Forms.RadioButton();
            this.radioSaskatchewan = new System.Windows.Forms.RadioButton();
            this.radioQuebec = new System.Windows.Forms.RadioButton();
            this.radioPEI = new System.Windows.Forms.RadioButton();
            this.radioOntario = new System.Windows.Forms.RadioButton();
            this.radioNunavut = new System.Windows.Forms.RadioButton();
            this.radioNovaScotia = new System.Windows.Forms.RadioButton();
            this.radioNwT = new System.Windows.Forms.RadioButton();
            this.radioNewLab = new System.Windows.Forms.RadioButton();
            this.radioNewBr = new System.Windows.Forms.RadioButton();
            this.radioManitoba = new System.Windows.Forms.RadioButton();
            this.radioBritishColumbia = new System.Windows.Forms.RadioButton();
            this.radioAlberta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputRegWkHrs = new System.Windows.Forms.TextBox();
            this.outputRegWagePH = new System.Windows.Forms.TextBox();
            this.outputOvWkHrs = new System.Windows.Forms.TextBox();
            this.outputOvWagePH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.outputMinWageMsg = new System.Windows.Forms.TextBox();
            this.btnCalWkPay = new System.Windows.Forms.Button();
            this.outRegH = new System.Windows.Forms.TextBox();
            this.outOvH = new System.Windows.Forms.TextBox();
            this.outRegP = new System.Windows.Forms.TextBox();
            this.outOvP = new System.Windows.Forms.TextBox();
            this.outTotalP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioYukon);
            this.groupBox1.Controls.Add(this.radioSaskatchewan);
            this.groupBox1.Controls.Add(this.radioQuebec);
            this.groupBox1.Controls.Add(this.radioPEI);
            this.groupBox1.Controls.Add(this.radioOntario);
            this.groupBox1.Controls.Add(this.radioNunavut);
            this.groupBox1.Controls.Add(this.radioNovaScotia);
            this.groupBox1.Controls.Add(this.radioNwT);
            this.groupBox1.Controls.Add(this.radioNewLab);
            this.groupBox1.Controls.Add(this.radioNewBr);
            this.groupBox1.Controls.Add(this.radioManitoba);
            this.groupBox1.Controls.Add(this.radioBritishColumbia);
            this.groupBox1.Controls.Add(this.radioAlberta);
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Province";
            // 
            // radioYukon
            // 
            this.radioYukon.AutoSize = true;
            this.radioYukon.Location = new System.Drawing.Point(7, 317);
            this.radioYukon.Name = "radioYukon";
            this.radioYukon.Size = new System.Drawing.Size(56, 17);
            this.radioYukon.TabIndex = 12;
            this.radioYukon.TabStop = true;
            this.radioYukon.Text = "Yukon";
            this.radioYukon.UseVisualStyleBackColor = true;
            this.radioYukon.CheckedChanged += new System.EventHandler(this.radioYukon_CheckedChanged);
            // 
            // radioSaskatchewan
            // 
            this.radioSaskatchewan.AutoSize = true;
            this.radioSaskatchewan.Location = new System.Drawing.Point(7, 293);
            this.radioSaskatchewan.Name = "radioSaskatchewan";
            this.radioSaskatchewan.Size = new System.Drawing.Size(96, 17);
            this.radioSaskatchewan.TabIndex = 11;
            this.radioSaskatchewan.TabStop = true;
            this.radioSaskatchewan.Text = "Saskatchewan";
            this.radioSaskatchewan.UseVisualStyleBackColor = true;
            this.radioSaskatchewan.CheckedChanged += new System.EventHandler(this.radioSaskatchewan_CheckedChanged);
            // 
            // radioQuebec
            // 
            this.radioQuebec.AutoSize = true;
            this.radioQuebec.Location = new System.Drawing.Point(7, 269);
            this.radioQuebec.Name = "radioQuebec";
            this.radioQuebec.Size = new System.Drawing.Size(63, 17);
            this.radioQuebec.TabIndex = 10;
            this.radioQuebec.TabStop = true;
            this.radioQuebec.Text = "Quebec";
            this.radioQuebec.UseVisualStyleBackColor = true;
            this.radioQuebec.CheckedChanged += new System.EventHandler(this.radioQuebec_CheckedChanged);
            // 
            // radioPEI
            // 
            this.radioPEI.AutoSize = true;
            this.radioPEI.Location = new System.Drawing.Point(7, 245);
            this.radioPEI.Name = "radioPEI";
            this.radioPEI.Size = new System.Drawing.Size(125, 17);
            this.radioPEI.TabIndex = 9;
            this.radioPEI.TabStop = true;
            this.radioPEI.Text = "Prince Edward Island";
            this.radioPEI.UseVisualStyleBackColor = true;
            this.radioPEI.CheckedChanged += new System.EventHandler(this.radioPEI_CheckedChanged);
            // 
            // radioOntario
            // 
            this.radioOntario.AutoSize = true;
            this.radioOntario.Location = new System.Drawing.Point(7, 221);
            this.radioOntario.Name = "radioOntario";
            this.radioOntario.Size = new System.Drawing.Size(59, 17);
            this.radioOntario.TabIndex = 8;
            this.radioOntario.TabStop = true;
            this.radioOntario.Text = "Ontario";
            this.radioOntario.UseVisualStyleBackColor = true;
            this.radioOntario.CheckedChanged += new System.EventHandler(this.radioOntario_CheckedChanged);
            // 
            // radioNunavut
            // 
            this.radioNunavut.AutoSize = true;
            this.radioNunavut.Location = new System.Drawing.Point(7, 197);
            this.radioNunavut.Name = "radioNunavut";
            this.radioNunavut.Size = new System.Drawing.Size(66, 17);
            this.radioNunavut.TabIndex = 7;
            this.radioNunavut.TabStop = true;
            this.radioNunavut.Text = "Nunavut";
            this.radioNunavut.UseVisualStyleBackColor = true;
            this.radioNunavut.CheckedChanged += new System.EventHandler(this.radioNunavut_CheckedChanged);
            // 
            // radioNovaScotia
            // 
            this.radioNovaScotia.AutoSize = true;
            this.radioNovaScotia.Location = new System.Drawing.Point(7, 173);
            this.radioNovaScotia.Name = "radioNovaScotia";
            this.radioNovaScotia.Size = new System.Drawing.Size(84, 17);
            this.radioNovaScotia.TabIndex = 6;
            this.radioNovaScotia.TabStop = true;
            this.radioNovaScotia.Text = "Nova Scotia";
            this.radioNovaScotia.UseVisualStyleBackColor = true;
            this.radioNovaScotia.CheckedChanged += new System.EventHandler(this.radioNovaScotia_CheckedChanged);
            // 
            // radioNwT
            // 
            this.radioNwT.AutoSize = true;
            this.radioNwT.Location = new System.Drawing.Point(7, 149);
            this.radioNwT.Name = "radioNwT";
            this.radioNwT.Size = new System.Drawing.Size(122, 17);
            this.radioNwT.TabIndex = 5;
            this.radioNwT.TabStop = true;
            this.radioNwT.Text = "Northwest Territories";
            this.radioNwT.UseVisualStyleBackColor = true;
            this.radioNwT.CheckedChanged += new System.EventHandler(this.radioNwT_CheckedChanged);
            // 
            // radioNewLab
            // 
            this.radioNewLab.AutoSize = true;
            this.radioNewLab.Location = new System.Drawing.Point(7, 125);
            this.radioNewLab.Name = "radioNewLab";
            this.radioNewLab.Size = new System.Drawing.Size(160, 17);
            this.radioNewLab.TabIndex = 4;
            this.radioNewLab.TabStop = true;
            this.radioNewLab.Text = "Newfoundland and Labrador";
            this.radioNewLab.UseVisualStyleBackColor = true;
            this.radioNewLab.CheckedChanged += new System.EventHandler(this.radioNewLab_CheckedChanged);
            // 
            // radioNewBr
            // 
            this.radioNewBr.AutoSize = true;
            this.radioNewBr.Location = new System.Drawing.Point(7, 101);
            this.radioNewBr.Name = "radioNewBr";
            this.radioNewBr.Size = new System.Drawing.Size(99, 17);
            this.radioNewBr.TabIndex = 3;
            this.radioNewBr.TabStop = true;
            this.radioNewBr.Text = "New Brunswick";
            this.radioNewBr.UseVisualStyleBackColor = true;
            this.radioNewBr.CheckedChanged += new System.EventHandler(this.radioNewBr_CheckedChanged);
            // 
            // radioManitoba
            // 
            this.radioManitoba.AutoSize = true;
            this.radioManitoba.Location = new System.Drawing.Point(7, 77);
            this.radioManitoba.Name = "radioManitoba";
            this.radioManitoba.Size = new System.Drawing.Size(69, 17);
            this.radioManitoba.TabIndex = 2;
            this.radioManitoba.TabStop = true;
            this.radioManitoba.Text = "Manitoba";
            this.radioManitoba.UseVisualStyleBackColor = true;
            this.radioManitoba.CheckedChanged += new System.EventHandler(this.radioManitoba_CheckedChanged);
            // 
            // radioBritishColumbia
            // 
            this.radioBritishColumbia.AutoSize = true;
            this.radioBritishColumbia.Location = new System.Drawing.Point(7, 53);
            this.radioBritishColumbia.Name = "radioBritishColumbia";
            this.radioBritishColumbia.Size = new System.Drawing.Size(99, 17);
            this.radioBritishColumbia.TabIndex = 1;
            this.radioBritishColumbia.TabStop = true;
            this.radioBritishColumbia.Text = "British Columbia";
            this.radioBritishColumbia.UseVisualStyleBackColor = true;
            this.radioBritishColumbia.CheckedChanged += new System.EventHandler(this.radioBritishColumbia_CheckedChanged);
            // 
            // radioAlberta
            // 
            this.radioAlberta.AutoSize = true;
            this.radioAlberta.Location = new System.Drawing.Point(7, 29);
            this.radioAlberta.Name = "radioAlberta";
            this.radioAlberta.Size = new System.Drawing.Size(58, 17);
            this.radioAlberta.TabIndex = 0;
            this.radioAlberta.TabStop = true;
            this.radioAlberta.Text = "Alberta";
            this.radioAlberta.UseVisualStyleBackColor = true;
            this.radioAlberta.CheckedChanged += new System.EventHandler(this.radioAlberta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular weekly hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regular wage per hour:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Overtime weekly hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Overtime wage per hour:";
            // 
            // outputRegWkHrs
            // 
            this.outputRegWkHrs.Location = new System.Drawing.Point(429, 61);
            this.outputRegWkHrs.Name = "outputRegWkHrs";
            this.outputRegWkHrs.Size = new System.Drawing.Size(137, 20);
            this.outputRegWkHrs.TabIndex = 5;
            // 
            // outputRegWagePH
            // 
            this.outputRegWagePH.Location = new System.Drawing.Point(429, 89);
            this.outputRegWagePH.Name = "outputRegWagePH";
            this.outputRegWagePH.Size = new System.Drawing.Size(137, 20);
            this.outputRegWagePH.TabIndex = 6;
            // 
            // outputOvWkHrs
            // 
            this.outputOvWkHrs.Location = new System.Drawing.Point(429, 116);
            this.outputOvWkHrs.Name = "outputOvWkHrs";
            this.outputOvWkHrs.Size = new System.Drawing.Size(137, 20);
            this.outputOvWkHrs.TabIndex = 7;
            // 
            // outputOvWagePH
            // 
            this.outputOvWagePH.Location = new System.Drawing.Point(429, 143);
            this.outputOvWagePH.Name = "outputOvWagePH";
            this.outputOvWagePH.Size = new System.Drawing.Size(137, 20);
            this.outputOvWagePH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Regular hours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Overtime hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Regular pay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Overtime pay:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total pay:";
            // 
            // outputMinWageMsg
            // 
            this.outputMinWageMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputMinWageMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMinWageMsg.Location = new System.Drawing.Point(33, 406);
            this.outputMinWageMsg.Multiline = true;
            this.outputMinWageMsg.Name = "outputMinWageMsg";
            this.outputMinWageMsg.ReadOnly = true;
            this.outputMinWageMsg.Size = new System.Drawing.Size(533, 44);
            this.outputMinWageMsg.TabIndex = 14;
            // 
            // btnCalWkPay
            // 
            this.btnCalWkPay.Location = new System.Drawing.Point(429, 169);
            this.btnCalWkPay.Name = "btnCalWkPay";
            this.btnCalWkPay.Size = new System.Drawing.Size(137, 23);
            this.btnCalWkPay.TabIndex = 15;
            this.btnCalWkPay.Text = "Calculate Weekly Pay";
            this.btnCalWkPay.UseVisualStyleBackColor = true;
            this.btnCalWkPay.Click += new System.EventHandler(this.btnCalWkPay_Click);
            // 
            // outRegH
            // 
            this.outRegH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outRegH.Location = new System.Drawing.Point(512, 229);
            this.outRegH.Name = "outRegH";
            this.outRegH.ReadOnly = true;
            this.outRegH.Size = new System.Drawing.Size(67, 13);
            this.outRegH.TabIndex = 16;
            // 
            // outOvH
            // 
            this.outOvH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outOvH.Location = new System.Drawing.Point(512, 255);
            this.outOvH.Name = "outOvH";
            this.outOvH.ReadOnly = true;
            this.outOvH.Size = new System.Drawing.Size(67, 13);
            this.outOvH.TabIndex = 17;
            // 
            // outRegP
            // 
            this.outRegP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outRegP.Location = new System.Drawing.Point(512, 281);
            this.outRegP.Name = "outRegP";
            this.outRegP.ReadOnly = true;
            this.outRegP.Size = new System.Drawing.Size(67, 13);
            this.outRegP.TabIndex = 18;
            this.outRegP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // outOvP
            // 
            this.outOvP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outOvP.Location = new System.Drawing.Point(512, 308);
            this.outOvP.Name = "outOvP";
            this.outOvP.ReadOnly = true;
            this.outOvP.Size = new System.Drawing.Size(67, 13);
            this.outOvP.TabIndex = 19;
            // 
            // outTotalP
            // 
            this.outTotalP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outTotalP.Location = new System.Drawing.Point(512, 335);
            this.outTotalP.Name = "outTotalP";
            this.outTotalP.ReadOnly = true;
            this.outTotalP.Size = new System.Drawing.Size(67, 13);
            this.outTotalP.TabIndex = 20;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outTotalP);
            this.Controls.Add(this.outOvP);
            this.Controls.Add(this.outRegP);
            this.Controls.Add(this.outOvH);
            this.Controls.Add(this.outRegH);
            this.Controls.Add(this.btnCalWkPay);
            this.Controls.Add(this.outputMinWageMsg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputOvWagePH);
            this.Controls.Add(this.outputOvWkHrs);
            this.Controls.Add(this.outputRegWagePH);
            this.Controls.Add(this.outputRegWkHrs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(599, 478);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioYukon;
        private System.Windows.Forms.RadioButton radioSaskatchewan;
        private System.Windows.Forms.RadioButton radioQuebec;
        private System.Windows.Forms.RadioButton radioPEI;
        private System.Windows.Forms.RadioButton radioOntario;
        private System.Windows.Forms.RadioButton radioNunavut;
        private System.Windows.Forms.RadioButton radioNovaScotia;
        private System.Windows.Forms.RadioButton radioNwT;
        private System.Windows.Forms.RadioButton radioNewLab;
        private System.Windows.Forms.RadioButton radioNewBr;
        private System.Windows.Forms.RadioButton radioManitoba;
        private System.Windows.Forms.RadioButton radioBritishColumbia;
        private System.Windows.Forms.RadioButton radioAlberta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputRegWagePH;
        private System.Windows.Forms.TextBox outputOvWkHrs;
        private System.Windows.Forms.TextBox outputOvWagePH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outputMinWageMsg;
        private System.Windows.Forms.Button btnCalWkPay;
        private System.Windows.Forms.TextBox outputRegWkHrs;
        private System.Windows.Forms.TextBox outRegH;
        private System.Windows.Forms.TextBox outOvH;
        private System.Windows.Forms.TextBox outRegP;
        private System.Windows.Forms.TextBox outOvP;
        private System.Windows.Forms.TextBox outTotalP;
    }
}
