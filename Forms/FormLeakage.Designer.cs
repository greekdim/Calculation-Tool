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
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnCalcLeak2 = new System.Windows.Forms.Button();
            this.pnlResult2 = new System.Windows.Forms.Panel();
            this.lblResult2Tool2 = new System.Windows.Forms.Label();
            this.lblResult1Tool2 = new System.Windows.Forms.Label();
            this.cbP1orLeak = new System.Windows.Forms.ComboBox();
            this.cbDeltaTime = new System.Windows.Forms.ComboBox();
            this.cbVolume = new System.Windows.Forms.ComboBox();
            this.cbP1 = new System.Windows.Forms.ComboBox();
            this.txtP1orLeak = new System.Windows.Forms.TextBox();
            this.txtDeltaTime = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.lblP1orLeak = new System.Windows.Forms.Label();
            this.lblDeltaTime = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.gprBoxRadio = new System.Windows.Forms.GroupBox();
            this.rbLeakCalc = new System.Windows.Forms.RadioButton();
            this.rbDeltaPCalc = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlResult2.SuspendLayout();
            this.gprBoxRadio.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(579, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relative Pressure:";
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
            this.btnCalcLeak1.Click += new System.EventHandler(this.btnCalcLeak1_Click);
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
            this.btnClearLeak1.Click += new System.EventHandler(this.btnClearLeak1_Click);
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
            this.lblResultLeak1.Size = new System.Drawing.Size(66, 22);
            this.lblResultLeak1.TabIndex = 0;
            this.lblResultLeak1.Text = "Result:";
            this.lblResultLeak1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnClear2);
            this.panel2.Controls.Add(this.btnCalcLeak2);
            this.panel2.Controls.Add(this.pnlResult2);
            this.panel2.Controls.Add(this.cbP1orLeak);
            this.panel2.Controls.Add(this.cbDeltaTime);
            this.panel2.Controls.Add(this.cbVolume);
            this.panel2.Controls.Add(this.cbP1);
            this.panel2.Controls.Add(this.txtP1orLeak);
            this.panel2.Controls.Add(this.txtDeltaTime);
            this.panel2.Controls.Add(this.txtVolume);
            this.panel2.Controls.Add(this.txtP1);
            this.panel2.Controls.Add(this.lblP1orLeak);
            this.panel2.Controls.Add(this.lblDeltaTime);
            this.panel2.Controls.Add(this.lblVolume);
            this.panel2.Controls.Add(this.lblP1);
            this.panel2.Controls.Add(this.gprBoxRadio);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(-4, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 392);
            this.panel2.TabIndex = 13;
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear2.Location = new System.Drawing.Point(821, 182);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(102, 49);
            this.btnClear2.TabIndex = 18;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnCalcLeak2
            // 
            this.btnCalcLeak2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcLeak2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcLeak2.Location = new System.Drawing.Point(661, 182);
            this.btnCalcLeak2.Name = "btnCalcLeak2";
            this.btnCalcLeak2.Size = new System.Drawing.Size(124, 49);
            this.btnCalcLeak2.TabIndex = 17;
            this.btnCalcLeak2.Text = "Calculate";
            this.btnCalcLeak2.UseVisualStyleBackColor = false;
            this.btnCalcLeak2.Click += new System.EventHandler(this.btnCalcLeak2_Click);
            // 
            // pnlResult2
            // 
            this.pnlResult2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.pnlResult2.Controls.Add(this.lblResult2Tool2);
            this.pnlResult2.Controls.Add(this.lblResult1Tool2);
            this.pnlResult2.Location = new System.Drawing.Point(597, 253);
            this.pnlResult2.Name = "pnlResult2";
            this.pnlResult2.Size = new System.Drawing.Size(395, 101);
            this.pnlResult2.TabIndex = 16;
            // 
            // lblResult2Tool2
            // 
            this.lblResult2Tool2.AutoSize = true;
            this.lblResult2Tool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult2Tool2.Location = new System.Drawing.Point(3, 54);
            this.lblResult2Tool2.Name = "lblResult2Tool2";
            this.lblResult2Tool2.Size = new System.Drawing.Size(206, 22);
            this.lblResult2Tool2.TabIndex = 1;
            this.lblResult2Tool2.Text = "Pressure drop over time:";
            // 
            // lblResult1Tool2
            // 
            this.lblResult1Tool2.AutoSize = true;
            this.lblResult1Tool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult1Tool2.Location = new System.Drawing.Point(3, 18);
            this.lblResult1Tool2.Name = "lblResult1Tool2";
            this.lblResult1Tool2.Size = new System.Drawing.Size(233, 22);
            this.lblResult1Tool2.TabIndex = 0;
            this.lblResult1Tool2.Text = "Leakrate (or final cal press):";
            // 
            // cbP1orLeak
            // 
            this.cbP1orLeak.BackColor = System.Drawing.SystemColors.Control;
            this.cbP1orLeak.FormattingEnabled = true;
            this.cbP1orLeak.Location = new System.Drawing.Point(487, 288);
            this.cbP1orLeak.Name = "cbP1orLeak";
            this.cbP1orLeak.Size = new System.Drawing.Size(91, 33);
            this.cbP1orLeak.TabIndex = 15;
            // 
            // cbDeltaTime
            // 
            this.cbDeltaTime.BackColor = System.Drawing.SystemColors.Control;
            this.cbDeltaTime.FormattingEnabled = true;
            this.cbDeltaTime.Location = new System.Drawing.Point(487, 253);
            this.cbDeltaTime.Name = "cbDeltaTime";
            this.cbDeltaTime.Size = new System.Drawing.Size(91, 33);
            this.cbDeltaTime.TabIndex = 14;
            // 
            // cbVolume
            // 
            this.cbVolume.BackColor = System.Drawing.SystemColors.Control;
            this.cbVolume.FormattingEnabled = true;
            this.cbVolume.Location = new System.Drawing.Point(487, 218);
            this.cbVolume.Name = "cbVolume";
            this.cbVolume.Size = new System.Drawing.Size(91, 33);
            this.cbVolume.TabIndex = 13;
            // 
            // cbP1
            // 
            this.cbP1.BackColor = System.Drawing.SystemColors.Control;
            this.cbP1.FormattingEnabled = true;
            this.cbP1.Location = new System.Drawing.Point(487, 182);
            this.cbP1.Name = "cbP1";
            this.cbP1.Size = new System.Drawing.Size(91, 33);
            this.cbP1.TabIndex = 12;
            // 
            // txtP1orLeak
            // 
            this.txtP1orLeak.Location = new System.Drawing.Point(331, 288);
            this.txtP1orLeak.Name = "txtP1orLeak";
            this.txtP1orLeak.Size = new System.Drawing.Size(150, 31);
            this.txtP1orLeak.TabIndex = 11;
            // 
            // txtDeltaTime
            // 
            this.txtDeltaTime.Location = new System.Drawing.Point(331, 253);
            this.txtDeltaTime.Name = "txtDeltaTime";
            this.txtDeltaTime.Size = new System.Drawing.Size(150, 31);
            this.txtDeltaTime.TabIndex = 10;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(331, 219);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(150, 31);
            this.txtVolume.TabIndex = 9;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(331, 182);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(150, 31);
            this.txtP1.TabIndex = 8;
            // 
            // lblP1orLeak
            // 
            this.lblP1orLeak.AutoSize = true;
            this.lblP1orLeak.Location = new System.Drawing.Point(27, 291);
            this.lblP1orLeak.Name = "lblP1orLeak";
            this.lblP1orLeak.Size = new System.Drawing.Size(257, 25);
            this.lblP1orLeak.TabIndex = 7;
            this.lblP1orLeak.Text = "Final Pressure or Valve Leakrate";
            // 
            // lblDeltaTime
            // 
            this.lblDeltaTime.AutoSize = true;
            this.lblDeltaTime.Location = new System.Drawing.Point(27, 253);
            this.lblDeltaTime.Name = "lblDeltaTime";
            this.lblDeltaTime.Size = new System.Drawing.Size(127, 25);
            this.lblDeltaTime.TabIndex = 6;
            this.lblDeltaTime.Text = "Period of Time";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(27, 218);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(72, 25);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Volume";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(27, 182);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(125, 25);
            this.lblP1.TabIndex = 4;
            this.lblP1.Text = "Initial Pressure";
            // 
            // gprBoxRadio
            // 
            this.gprBoxRadio.Controls.Add(this.rbLeakCalc);
            this.gprBoxRadio.Controls.Add(this.rbDeltaPCalc);
            this.gprBoxRadio.Location = new System.Drawing.Point(27, 57);
            this.gprBoxRadio.Name = "gprBoxRadio";
            this.gprBoxRadio.Size = new System.Drawing.Size(965, 104);
            this.gprBoxRadio.TabIndex = 3;
            this.gprBoxRadio.TabStop = false;
            this.gprBoxRadio.Text = "Calculation Type";
            // 
            // rbLeakCalc
            // 
            this.rbLeakCalc.AutoSize = true;
            this.rbLeakCalc.Location = new System.Drawing.Point(12, 30);
            this.rbLeakCalc.Name = "rbLeakCalc";
            this.rbLeakCalc.Size = new System.Drawing.Size(884, 29);
            this.rbLeakCalc.TabIndex = 0;
            this.rbLeakCalc.TabStop = true;
            this.rbLeakCalc.Text = "Calculate a LEAK FLOW RATE using a PRESSURE DROP over a known period of TIME, fro" +
    "m a know VOLUME\r\n";
            this.rbLeakCalc.UseVisualStyleBackColor = true;
            this.rbLeakCalc.CheckedChanged += new System.EventHandler(this.rbLeakCalc_CheckedChanged);
            // 
            // rbDeltaPCalc
            // 
            this.rbDeltaPCalc.AutoSize = true;
            this.rbDeltaPCalc.Location = new System.Drawing.Point(12, 65);
            this.rbDeltaPCalc.Name = "rbDeltaPCalc";
            this.rbDeltaPCalc.Size = new System.Drawing.Size(925, 29);
            this.rbDeltaPCalc.TabIndex = 1;
            this.rbDeltaPCalc.TabStop = true;
            this.rbDeltaPCalc.Text = "Calculate a PRESSURE DROP in a known VOLUME over a known period of TIME, from a k" +
    "nown VALVE LEAK RATE\r\n";
            this.rbDeltaPCalc.UseVisualStyleBackColor = true;
            this.rbDeltaPCalc.CheckedChanged += new System.EventHandler(this.rbDeltaPCalc_CheckedChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(27, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "NB: Relative pressures must be entered and are calculated";
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
            this.pnlResult2.ResumeLayout(false);
            this.pnlResult2.PerformLayout();
            this.gprBoxRadio.ResumeLayout(false);
            this.gprBoxRadio.PerformLayout();
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
        private RadioButton rbDeltaPCalc;
        private RadioButton rbLeakCalc;
        private GroupBox gprBoxRadio;
        private Button btnClear2;
        private Button btnCalcLeak2;
        private Panel pnlResult2;
        private Label lblResult2Tool2;
        private Label lblResult1Tool2;
        private ComboBox cbP1orLeak;
        private ComboBox cbDeltaTime;
        private ComboBox cbVolume;
        private ComboBox cbP1;
        private TextBox txtP1orLeak;
        private TextBox txtDeltaTime;
        private TextBox txtVolume;
        private TextBox txtP1;
        private Label lblP1orLeak;
        private Label lblDeltaTime;
        private Label lblVolume;
        private Label lblP1;
        private Label label3;
    }
}