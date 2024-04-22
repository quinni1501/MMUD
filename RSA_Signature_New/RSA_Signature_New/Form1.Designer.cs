namespace RSA_Signature_New
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTb = new System.Windows.Forms.TextBox();
            this.qTb = new System.Windows.Forms.TextBox();
            this.pTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phiTb = new System.Windows.Forms.TextBox();
            this.nTb = new System.Windows.Forms.TextBox();
            this.priTb = new System.Windows.Forms.TextBox();
            this.pubTb = new System.Windows.Forms.TextBox();
            this.verifyBt = new System.Windows.Forms.Button();
            this.calculateBt = new System.Windows.Forms.Button();
            this.signBt = new System.Windows.Forms.Button();
            this.signTb = new System.Windows.Forms.TextBox();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA SIGNATURE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTb);
            this.groupBox1.Controls.Add(this.qTb);
            this.groupBox1.Controls.Add(this.pTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // dTb
            // 
            this.dTb.Location = new System.Drawing.Point(127, 152);
            this.dTb.Multiline = true;
            this.dTb.Name = "dTb";
            this.dTb.Size = new System.Drawing.Size(119, 35);
            this.dTb.TabIndex = 5;
            this.dTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qTb
            // 
            this.qTb.Location = new System.Drawing.Point(127, 92);
            this.qTb.Multiline = true;
            this.qTb.Name = "qTb";
            this.qTb.Size = new System.Drawing.Size(119, 35);
            this.qTb.TabIndex = 4;
            this.qTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTb
            // 
            this.pTb.Location = new System.Drawing.Point(127, 34);
            this.pTb.Multiline = true;
            this.pTb.Name = "pTb";
            this.pTb.Size = new System.Drawing.Size(119, 35);
            this.pTb.TabIndex = 3;
            this.pTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pTb.TextChanged += new System.EventHandler(this.pTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Φ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Public Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Private Key";
            // 
            // phiTb
            // 
            this.phiTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiTb.Location = new System.Drawing.Point(529, 88);
            this.phiTb.Multiline = true;
            this.phiTb.Name = "phiTb";
            this.phiTb.Size = new System.Drawing.Size(70, 35);
            this.phiTb.TabIndex = 6;
            this.phiTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nTb
            // 
            this.nTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTb.Location = new System.Drawing.Point(529, 154);
            this.nTb.Multiline = true;
            this.nTb.Name = "nTb";
            this.nTb.Size = new System.Drawing.Size(70, 35);
            this.nTb.TabIndex = 7;
            this.nTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priTb
            // 
            this.priTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priTb.Location = new System.Drawing.Point(109, 345);
            this.priTb.Multiline = true;
            this.priTb.Name = "priTb";
            this.priTb.Size = new System.Drawing.Size(119, 35);
            this.priTb.TabIndex = 8;
            this.priTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pubTb
            // 
            this.pubTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubTb.Location = new System.Drawing.Point(395, 345);
            this.pubTb.Multiline = true;
            this.pubTb.Name = "pubTb";
            this.pubTb.Size = new System.Drawing.Size(119, 35);
            this.pubTb.TabIndex = 9;
            this.pubTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyBt
            // 
            this.verifyBt.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBt.Location = new System.Drawing.Point(324, 410);
            this.verifyBt.Name = "verifyBt";
            this.verifyBt.Size = new System.Drawing.Size(83, 40);
            this.verifyBt.TabIndex = 10;
            this.verifyBt.Text = "Verify";
            this.verifyBt.UseVisualStyleBackColor = true;
            this.verifyBt.Click += new System.EventHandler(this.verifyBt_Click);
            // 
            // calculateBt
            // 
            this.calculateBt.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBt.Location = new System.Drawing.Point(621, 115);
            this.calculateBt.Name = "calculateBt";
            this.calculateBt.Size = new System.Drawing.Size(91, 40);
            this.calculateBt.TabIndex = 11;
            this.calculateBt.Text = "Calculate";
            this.calculateBt.UseVisualStyleBackColor = true;
            this.calculateBt.Click += new System.EventHandler(this.calculateBt_Click);
            // 
            // signBt
            // 
            this.signBt.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBt.Location = new System.Drawing.Point(621, 233);
            this.signBt.Name = "signBt";
            this.signBt.Size = new System.Drawing.Size(91, 40);
            this.signBt.TabIndex = 12;
            this.signBt.Text = "Sign";
            this.signBt.UseVisualStyleBackColor = true;
            this.signBt.Click += new System.EventHandler(this.signBt_Click);
            // 
            // signTb
            // 
            this.signTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signTb.Location = new System.Drawing.Point(480, 240);
            this.signTb.Multiline = true;
            this.signTb.Name = "signTb";
            this.signTb.Size = new System.Drawing.Size(119, 35);
            this.signTb.TabIndex = 13;
            this.signTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // messageTb
            // 
            this.messageTb.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTb.Location = new System.Drawing.Point(621, 345);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(119, 35);
            this.messageTb.TabIndex = 14;
            this.messageTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.signTb);
            this.Controls.Add(this.signBt);
            this.Controls.Add(this.calculateBt);
            this.Controls.Add(this.verifyBt);
            this.Controls.Add(this.pubTb);
            this.Controls.Add(this.priTb);
            this.Controls.Add(this.nTb);
            this.Controls.Add(this.phiTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dTb;
        private System.Windows.Forms.TextBox qTb;
        private System.Windows.Forms.TextBox pTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phiTb;
        private System.Windows.Forms.TextBox nTb;
        private System.Windows.Forms.TextBox priTb;
        private System.Windows.Forms.TextBox pubTb;
        private System.Windows.Forms.Button verifyBt;
        private System.Windows.Forms.Button calculateBt;
        private System.Windows.Forms.Button signBt;
        private System.Windows.Forms.TextBox signTb;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Label label9;
    }
}

