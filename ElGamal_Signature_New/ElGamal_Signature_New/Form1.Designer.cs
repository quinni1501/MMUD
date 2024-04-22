namespace ElGamal_Signature_New
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTb = new System.Windows.Forms.TextBox();
            this.alphaTb = new System.Windows.Forms.TextBox();
            this.aTb = new System.Windows.Forms.TextBox();
            this.kTb = new System.Windows.Forms.TextBox();
            this.xTb = new System.Windows.Forms.TextBox();
            this.signBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pubTb = new System.Windows.Forms.TextBox();
            this.y1Tb = new System.Windows.Forms.TextBox();
            this.y2Tb = new System.Windows.Forms.TextBox();
            this.verifyBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELGAMAM SIGNATURE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xTb);
            this.groupBox1.Controls.Add(this.kTb);
            this.groupBox1.Controls.Add(this.aTb);
            this.groupBox1.Controls.Add(this.alphaTb);
            this.groupBox1.Controls.Add(this.pTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phần tử sinh (α)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khóa bí mật (a)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số ngẫu nhiên (k)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bản tin (x)";
            // 
            // pTb
            // 
            this.pTb.Location = new System.Drawing.Point(218, 33);
            this.pTb.Name = "pTb";
            this.pTb.Size = new System.Drawing.Size(100, 33);
            this.pTb.TabIndex = 5;
            this.pTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alphaTb
            // 
            this.alphaTb.Location = new System.Drawing.Point(218, 80);
            this.alphaTb.Name = "alphaTb";
            this.alphaTb.Size = new System.Drawing.Size(100, 33);
            this.alphaTb.TabIndex = 6;
            this.alphaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aTb
            // 
            this.aTb.Location = new System.Drawing.Point(218, 129);
            this.aTb.Name = "aTb";
            this.aTb.Size = new System.Drawing.Size(100, 33);
            this.aTb.TabIndex = 7;
            this.aTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kTb
            // 
            this.kTb.Location = new System.Drawing.Point(218, 184);
            this.kTb.Name = "kTb";
            this.kTb.Size = new System.Drawing.Size(100, 33);
            this.kTb.TabIndex = 8;
            this.kTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xTb
            // 
            this.xTb.Location = new System.Drawing.Point(218, 240);
            this.xTb.Name = "xTb";
            this.xTb.Size = new System.Drawing.Size(100, 33);
            this.xTb.TabIndex = 9;
            this.xTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signBt
            // 
            this.signBt.BackColor = System.Drawing.Color.Teal;
            this.signBt.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signBt.Location = new System.Drawing.Point(428, 218);
            this.signBt.Name = "signBt";
            this.signBt.Size = new System.Drawing.Size(79, 36);
            this.signBt.TabIndex = 2;
            this.signBt.Text = "Sign";
            this.signBt.UseVisualStyleBackColor = false;
            this.signBt.Click += new System.EventHandler(this.signBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Public Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y1 Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Y2 Key";
            // 
            // pubTb
            // 
            this.pubTb.Location = new System.Drawing.Point(663, 137);
            this.pubTb.Multiline = true;
            this.pubTb.Name = "pubTb";
            this.pubTb.Size = new System.Drawing.Size(103, 33);
            this.pubTb.TabIndex = 8;
            this.pubTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y1Tb
            // 
            this.y1Tb.Location = new System.Drawing.Point(663, 210);
            this.y1Tb.Multiline = true;
            this.y1Tb.Name = "y1Tb";
            this.y1Tb.Size = new System.Drawing.Size(103, 33);
            this.y1Tb.TabIndex = 9;
            this.y1Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y2Tb
            // 
            this.y2Tb.Location = new System.Drawing.Point(663, 287);
            this.y2Tb.Multiline = true;
            this.y2Tb.Name = "y2Tb";
            this.y2Tb.Size = new System.Drawing.Size(103, 33);
            this.y2Tb.TabIndex = 10;
            this.y2Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyBt
            // 
            this.verifyBt.BackColor = System.Drawing.Color.Teal;
            this.verifyBt.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verifyBt.Location = new System.Drawing.Point(367, 430);
            this.verifyBt.Name = "verifyBt";
            this.verifyBt.Size = new System.Drawing.Size(79, 36);
            this.verifyBt.TabIndex = 11;
            this.verifyBt.Text = "Verify";
            this.verifyBt.UseVisualStyleBackColor = false;
            this.verifyBt.Click += new System.EventHandler(this.verifyBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.verifyBt);
            this.Controls.Add(this.y2Tb);
            this.Controls.Add(this.y1Tb);
            this.Controls.Add(this.pubTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signBt);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alphaTb;
        private System.Windows.Forms.TextBox pTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xTb;
        private System.Windows.Forms.TextBox kTb;
        private System.Windows.Forms.TextBox aTb;
        private System.Windows.Forms.Button signBt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pubTb;
        private System.Windows.Forms.TextBox y1Tb;
        private System.Windows.Forms.TextBox y2Tb;
        private System.Windows.Forms.Button verifyBt;
    }
}

