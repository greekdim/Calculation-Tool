namespace Calc_Tool___Rev_A.Forms
{
    partial class FormLeakage
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
            this.cbLeakFormulaSelection = new System.Windows.Forms.ComboBox();
            this.lblPressure = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtValueLeak = new System.Windows.Forms.TextBox();
            this.lblValueLeak = new System.Windows.Forms.Label();
            this.cbPressureUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.cvTempUnit = new System.Windows.Forms.ComboBox();
            this.btnCalcLeak1 = new System.Windows.Forms.Button();
            this.btnClearLeak1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultLeak1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLeakFormulaSelection
            // 
            this.cbLeakFormulaSelection.BackColor = System.Drawing.SystemColors.Menu;
            this.cbLeakFormulaSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLeakFormulaSelection.FormattingEnabled = true;
            this.cbLeakFormulaSelection.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbLeakFormulaSelection.Items.AddRange(new object[] {
            "sccm to ccm",
            "ccm to sccm"});
            this.cbLeakFormulaSelection.Location = new System.Drawing.Point(327, 20);
            this.cbLeakFormulaSelection.Name = "cbLeakFormulaSelection";
            this.cbLeakFormulaSelection.Size = new System.Drawing.Size(278, 30);
            this.cbLeakFormulaSelection.TabIndex = 0;
            this.cbLeakFormulaSelection.Text = "Please select an option";
            this.cbLeakFormulaSelection.SelectedIndexChanged += new System.EventHandler(this.CbLeakFormulaSelection_SelectedIndexChanged);
            // 
            // lblPressure
            // 
            this.lblPressure.Location = new System.Drawing.Point(732, 64);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(150, 31);
            this.lblPressure.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(18, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(278, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Leakage flow rate converter";
            // 
            // txtValueLeak
            // 
            this.txtValueLeak.Location = new System.Drawing.Point(327, 63);
            this.txtValueLeak.Name = "txtValueLeak";
            this.txtValueLeak.Size = new System.Drawing.Size(150, 31);
            this.txtValueLeak.TabIndex = 3;
            // 
            // lblValueLeak
            // 
            this.lblValueLeak.AutoSize = true;
            this.lblValueLeak.Location = new System.Drawing.Point(483, 66);
            this.lblValueLeak.Name = "lblValueLeak";
            this.lblValueLeak.Size = new System.Drawing.Size(44, 25);
            this.lblValueLeak.TabIndex = 4;
            this.lblValueLeak.Text = "ccm";
            // 
            // cbPressureUnit
            // 
            this.cbPressureUnit.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPressureUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPressureUnit.FormattingEnabled = true;
            this.cbPressureUnit.Location = new System.Drawing.Point(888, 64);
            this.cbPressureUnit.Name = "cbPressureUnit";
            this.cbPressureUnit.Size = new System.Drawing.Size(72, 33);
            this.cbPressureUnit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pressure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(732, 105);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(150, 31);
            this.txtTemperature.TabIndex = 8;
            // 
            // cvTempUnit
            // 
            this.cvTempUnit.BackColor = System.Drawing.SystemColors.Menu;
            this.cvTempUnit.FormattingEnabled = true;
            this.cvTempUnit.Location = new System.Drawing.Point(888, 105);
            this.cvTempUnit.Name = "cvTempUnit";
            this.cvTempUnit.Size = new System.Drawing.Size(72, 33);
            this.cvTempUnit.TabIndex = 9;
            // 
            // btnCalcLeak1
            // 
            this.btnCalcLeak1.AutoSize = true;
            this.btnCalcLeak1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcLeak1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcLeak1.Location = new System.Drawing.Point(327, 146);
            this.btnCalcLeak1.Name = "btnCalcLeak1";
            this.btnCalcLeak1.Size = new System.Drawing.Size(113, 47);
            this.btnCalcLeak1.TabIndex = 10;
            this.btnCalcLeak1.Text = "Calculate";
            this.btnCalcLeak1.UseVisualStyleBackColor = false;
            // 
            // btnClearLeak1
            // 
            this.btnClearLeak1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearLeak1.Location = new System.Drawing.Point(446, 146);
            this.btnClearLeak1.Name = "btnClearLeak1";
            this.btnClearLeak1.Size = new System.Drawing.Size(108, 47);
            this.btnClearLeak1.TabIndex = 11;
            this.btnClearLeak1.Text = "Clear";
            this.btnClearLeak1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblResultLeak1);
            this.panel1.Location = new System.Drawing.Point(582, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 47);
            this.panel1.TabIndex = 12;
            // 
            // lblResultLeak1
            // 
            this.lblResultLeak1.AutoSize = true;
            this.lblResultLeak1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultLeak1.Location = new System.Drawing.Point(62, 13);
            this.lblResultLeak1.Name = "lblResultLeak1";
            this.lblResultLeak1.Size = new System.Drawing.Size(149, 22);
            this.lblResultLeak1.TabIndex = 0;
            this.lblResultLeak1.Text = "1 ccm = 23 sccm ";
            this.lblResultLeak1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(-4, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 392);
            this.panel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(821, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(661, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(597, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 101);
            this.panel3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pressure drop over time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Leakrate (or final cal press):";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(487, 288);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(91, 33);
            this.comboBox4.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(487, 253);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(91, 33);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(487, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 33);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 33);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(331, 288);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 31);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Final Pressure or Valve Leakrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Period of Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Pressure";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(884, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Calculate a LEAK FLOW RATE using a PRESSURE DROP over a known period of TIME, fro" +
    "m a know VOLUME\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(925, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Calculate a PRESSURE DROP in a known VOLUME over a known period of TIME, from a k" +
    "nown VALVE LEAK RATE\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(27, 17);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(396, 25);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Leakage from closed volume calculation";
            // 
            // FormLeakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearLeak1);
            this.Controls.Add(this.btnCalcLeak1);
            this.Controls.Add(this.cvTempUnit);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPressureUnit);
            this.Controls.Add(this.lblValueLeak);
            this.Controls.Add(this.txtValueLeak);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.cbLeakFormulaSelection);
            this.Name = "FormLeakage";
            this.Text = "Leakage Formulas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       // private void cbLeakFormulaSelection_SelectedIndexChanged(object sender, EventArgs e)
       // {
        //    throw new NotImplementedException();
       // }

        #endregion

        private ComboBox cbLeakFormulaSelection;
        private TextBox lblPressure;
        private Label lbl1;
        private TextBox txtValueLeak;
        private Label lblValueLeak;
        private ComboBox cbPressureUnit;
        private Label label1;
        private Label label2;
        private TextBox txtTemperature;
        private ComboBox cvTempUnit;
        private Button btnCalcLeak1;
        private Button btnClearLeak1;
        private Panel panel1;
        private Label lblResultLeak1;
        private Panel panel2;
        private Label lbl2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}