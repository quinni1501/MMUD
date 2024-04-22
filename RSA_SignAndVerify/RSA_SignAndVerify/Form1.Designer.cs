namespace RSA_SignAndVerify
{
    partial class signBt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileTb = new System.Windows.Forms.TextBox();
            this.pTb = new System.Windows.Forms.TextBox();
            this.qTb = new System.Windows.Forms.TextBox();
            this.keyTb = new System.Windows.Forms.TextBox();
            this.contentTb = new System.Windows.Forms.TextBox();
            this.chooseBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "XÁC THỰC CHỮ KÝ SỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá trị p:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá trị q:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khóa bí mật:";
            // 
            // fileTb
            // 
            this.fileTb.Location = new System.Drawing.Point(150, 76);
            this.fileTb.Multiline = true;
            this.fileTb.Name = "fileTb";
            this.fileTb.Size = new System.Drawing.Size(287, 34);
            this.fileTb.TabIndex = 5;
            this.fileTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTb
            // 
            this.pTb.Location = new System.Drawing.Point(150, 155);
            this.pTb.Multiline = true;
            this.pTb.Name = "pTb";
            this.pTb.Size = new System.Drawing.Size(131, 33);
            this.pTb.TabIndex = 6;
            this.pTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qTb
            // 
            this.qTb.Location = new System.Drawing.Point(150, 218);
            this.qTb.Multiline = true;
            this.qTb.Name = "qTb";
            this.qTb.Size = new System.Drawing.Size(131, 33);
            this.qTb.TabIndex = 7;
            this.qTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // keyTb
            // 
            this.keyTb.Location = new System.Drawing.Point(150, 284);
            this.keyTb.Multiline = true;
            this.keyTb.Name = "keyTb";
            this.keyTb.Size = new System.Drawing.Size(131, 33);
            this.keyTb.TabIndex = 8;
            this.keyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contentTb
            // 
            this.contentTb.Location = new System.Drawing.Point(472, 73);
            this.contentTb.Multiline = true;
            this.contentTb.Name = "contentTb";
            this.contentTb.Size = new System.Drawing.Size(305, 115);
            this.contentTb.TabIndex = 9;
            // 
            // chooseBt
            // 
            this.chooseBt.Location = new System.Drawing.Point(360, 132);
            this.chooseBt.Name = "chooseBt";
            this.chooseBt.Size = new System.Drawing.Size(75, 23);
            this.chooseBt.TabIndex = 10;
            this.chooseBt.Text = "Choose File";
            this.chooseBt.UseVisualStyleBackColor = true;
            this.chooseBt.Click += new System.EventHandler(this.chooseBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nội dung File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign and Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signBt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chooseBt);
            this.Controls.Add(this.contentTb);
            this.Controls.Add(this.keyTb);
            this.Controls.Add(this.qTb);
            this.Controls.Add(this.pTb);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signBt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.signBt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileTb;
        private System.Windows.Forms.TextBox pTb;
        private System.Windows.Forms.TextBox qTb;
        private System.Windows.Forms.TextBox keyTb;
        private System.Windows.Forms.TextBox contentTb;
        private System.Windows.Forms.Button chooseBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

