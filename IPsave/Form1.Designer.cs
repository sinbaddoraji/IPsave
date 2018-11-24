namespace IPsave
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subnetTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subnetBinaryTxt = new System.Windows.Forms.TextBox();
            this.ipAddTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aAndB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "192.168.100.25/28";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subnet ID:";
            // 
            // subnetTxt
            // 
            this.subnetTxt.BackColor = System.Drawing.Color.White;
            this.subnetTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subnetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetTxt.Location = new System.Drawing.Point(124, 62);
            this.subnetTxt.Name = "subnetTxt";
            this.subnetTxt.ReadOnly = true;
            this.subnetTxt.Size = new System.Drawing.Size(170, 29);
            this.subnetTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Binary)";
            // 
            // subnetBinaryTxt
            // 
            this.subnetBinaryTxt.BackColor = System.Drawing.Color.White;
            this.subnetBinaryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subnetBinaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetBinaryTxt.Location = new System.Drawing.Point(329, 26);
            this.subnetBinaryTxt.MaxLength = 35;
            this.subnetBinaryTxt.Name = "subnetBinaryTxt";
            this.subnetBinaryTxt.ReadOnly = true;
            this.subnetBinaryTxt.Size = new System.Drawing.Size(345, 29);
            this.subnetBinaryTxt.TabIndex = 8;
            this.subnetBinaryTxt.Text = "\r\n\r\n";
            // 
            // ipAddTxt
            // 
            this.ipAddTxt.BackColor = System.Drawing.Color.White;
            this.ipAddTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddTxt.Location = new System.Drawing.Point(329, 64);
            this.ipAddTxt.MaxLength = 35;
            this.ipAddTxt.Name = "ipAddTxt";
            this.ipAddTxt.ReadOnly = true;
            this.ipAddTxt.Size = new System.Drawing.Size(345, 29);
            this.ipAddTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "B";
            // 
            // aAndB
            // 
            this.aAndB.BackColor = System.Drawing.Color.White;
            this.aAndB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aAndB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAndB.Location = new System.Drawing.Point(329, 142);
            this.aAndB.MaxLength = 35;
            this.aAndB.Name = "aAndB";
            this.aAndB.ReadOnly = true;
            this.aAndB.Size = new System.Drawing.Size(345, 29);
            this.aAndB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Network Address";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(199, 29);
            this.textBox6.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Broadcast Address";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(16, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(199, 29);
            this.textBox7.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generate Subnet ID\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(466, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "A X B";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(221, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "Generate ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(329, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 76);
            this.button2.TabIndex = 23;
            this.button2.Text = "Solve All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.aAndB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subnetBinaryTxt);
            this.Controls.Add(this.ipAddTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subnetTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(702, 317);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPsave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subnetTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subnetBinaryTxt;
        private System.Windows.Forms.TextBox ipAddTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aAndB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}

