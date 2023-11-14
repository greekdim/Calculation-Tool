namespace Calc_Tool___Rev_A.Forms
{
    partial class FormFlow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculateOrifice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.comboBoxCvKvOr = new System.Windows.Forms.ComboBox();
            this.txtValueToCalc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCalculateOrifice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxCvKvOr);
            this.panel1.Controls.Add(this.txtValueToCalc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(648, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 316);
            this.panel1.TabIndex = 0;
            // 
            // btnCalculateOrifice
            // 
            this.btnCalculateOrifice.Location = new System.Drawing.Point(35, 249);
            this.btnCalculateOrifice.Name = "btnCalculateOrifice";
            this.btnCalculateOrifice.Size = new System.Drawing.Size(150, 38);
            this.btnCalculateOrifice.TabIndex = 29;
            this.btnCalculateOrifice.Text = "Calculate";
            this.btnCalculateOrifice.UseVisualStyleBackColor = true;
            this.btnCalculateOrifice.Click += new System.EventHandler(this.btnCalculateOrifice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.lblResult1);
            this.panel2.Location = new System.Drawing.Point(35, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 70);
            this.panel2.TabIndex = 4;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult1.ForeColor = System.Drawing.Color.Black;
            this.lblResult1.Location = new System.Drawing.Point(3, 7);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(159, 25);
            this.lblResult1.TabIndex = 4;
            this.lblResult1.Text = "Kv = 3 // Orifice=";
            // 
            // comboBoxCvKvOr
            // 
            this.comboBoxCvKvOr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxCvKvOr.FormattingEnabled = true;
            this.comboBoxCvKvOr.Items.AddRange(new object[] {
            "Cv to Kv and orifice",
            "Kv to Cv and orifice",
            "Orifice to Cv and Kv"});
            this.comboBoxCvKvOr.Location = new System.Drawing.Point(35, 93);
            this.comboBoxCvKvOr.Name = "comboBoxCvKvOr";
            this.comboBoxCvKvOr.Size = new System.Drawing.Size(254, 33);
            this.comboBoxCvKvOr.TabIndex = 2;
            // 
            // txtValueToCalc
            // 
            this.txtValueToCalc.Location = new System.Drawing.Point(35, 55);
            this.txtValueToCalc.Name = "txtValueToCalc";
            this.txtValueToCalc.Size = new System.Drawing.Size(150, 31);
            this.txtValueToCalc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Cv, Kv, Orifice ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.comboBox7);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 635);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(218, 536);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 50);
            this.panel4.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 22);
            this.label14.TabIndex = 29;
            this.label14.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(475, 411);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 31);
            this.textBox7.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 411);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 31);
            this.textBox6.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(426, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cv";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(37, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Flow Rate";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 361);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 31);
            this.textBox5.TabIndex = 22;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(306, 311);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(94, 33);
            this.comboBox7.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 31);
            this.textBox4.TabIndex = 20;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(306, 261);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(94, 33);
            this.comboBox6.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 31);
            this.textBox3.TabIndex = 18;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(218, 211);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(182, 33);
            this.comboBox5.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(306, 166);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(94, 33);
            this.comboBox4.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 31);
            this.textBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(218, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 33);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "Medium Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(37, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(37, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Medium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Inlet Pressure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Outlet Pressure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gravity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calculation Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Detailed Flow Calculation";
            // 
            // FormFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormFlow";
            this.Text = "Flow - Orifice - Cv";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxCvKvOr;
        private TextBox txtValueToCalc;
        private Panel panel2;
        private Label lblResult1;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label12;
        private TextBox textBox5;
        private ComboBox comboBox7;
        private TextBox textBox4;
        private ComboBox comboBox6;
        private TextBox textBox3;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Panel panel4;
        private Label label14;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label13;
        private Button btnCalculateOrifice;
    }
}