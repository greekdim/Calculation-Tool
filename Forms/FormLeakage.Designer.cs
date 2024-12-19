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
            cbLeakFormulaSelection = new ComboBox();
            lblPressure = new TextBox();
            lbl1 = new Label();
            txtValueLeak = new TextBox();
            lblValueLeak = new Label();
            cbPressureUnit = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTemperature = new TextBox();
            cvTempUnit = new ComboBox();
            btnCalcLeak1 = new Button();
            btnClearLeak1 = new Button();
            panel1 = new Panel();
            lblResultLeak1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnClear2 = new Button();
            btnCalcLeak2 = new Button();
            pnlResult2 = new Panel();
            lblResult2Tool2 = new Label();
            lblResult1Tool2 = new Label();
            cbP1orLeak = new ComboBox();
            cbDeltaTime = new ComboBox();
            cbVolume = new ComboBox();
            cbP1 = new ComboBox();
            txtP1orLeak = new TextBox();
            txtDeltaTime = new TextBox();
            txtVolume = new TextBox();
            txtP1 = new TextBox();
            lblP1orLeak = new Label();
            lblDeltaTime = new Label();
            lblVolume = new Label();
            lblP1 = new Label();
            gprBoxRadio = new GroupBox();
            rbLeakCalc = new RadioButton();
            rbDeltaPCalc = new RadioButton();
            lbl2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlResult2.SuspendLayout();
            gprBoxRadio.SuspendLayout();
            SuspendLayout();
            // 
            // cbLeakFormulaSelection
            // 
            cbLeakFormulaSelection.BackColor = SystemColors.Menu;
            cbLeakFormulaSelection.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbLeakFormulaSelection.FormattingEnabled = true;
            cbLeakFormulaSelection.ImeMode = ImeMode.Off;
            cbLeakFormulaSelection.Items.AddRange(new object[] { "sccm to ccm", "ccm to sccm" });
            cbLeakFormulaSelection.Location = new Point(327, 20);
            cbLeakFormulaSelection.Name = "cbLeakFormulaSelection";
            cbLeakFormulaSelection.Size = new Size(278, 30);
            cbLeakFormulaSelection.TabIndex = 0;
            cbLeakFormulaSelection.Text = "Please select an option";
            cbLeakFormulaSelection.SelectedIndexChanged += CbLeakFormulaSelection_SelectedIndexChanged;
            // 
            // lblPressure
            // 
            lblPressure.Location = new Point(732, 64);
            lblPressure.Name = "lblPressure";
            lblPressure.Size = new Size(150, 31);
            lblPressure.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(18, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(278, 25);
            lbl1.TabIndex = 2;
            lbl1.Text = "Leakage flow rate converter";
            // 
            // txtValueLeak
            // 
            txtValueLeak.Location = new Point(327, 63);
            txtValueLeak.Name = "txtValueLeak";
            txtValueLeak.Size = new Size(150, 31);
            txtValueLeak.TabIndex = 3;
            // 
            // lblValueLeak
            // 
            lblValueLeak.AutoSize = true;
            lblValueLeak.Location = new Point(483, 66);
            lblValueLeak.Name = "lblValueLeak";
            lblValueLeak.Size = new Size(44, 25);
            lblValueLeak.TabIndex = 4;
            lblValueLeak.Text = "ccm";
            // 
            // cbPressureUnit
            // 
            cbPressureUnit.BackColor = SystemColors.Menu;
            cbPressureUnit.ForeColor = SystemColors.WindowText;
            cbPressureUnit.FormattingEnabled = true;
            cbPressureUnit.Location = new Point(888, 64);
            cbPressureUnit.Name = "cbPressureUnit";
            cbPressureUnit.Size = new Size(72, 33);
            cbPressureUnit.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 69);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 6;
            label1.Text = "Relative Pressure:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 108);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 7;
            label2.Text = "Temperature:";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(732, 105);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(150, 31);
            txtTemperature.TabIndex = 8;
            // 
            // cvTempUnit
            // 
            cvTempUnit.BackColor = SystemColors.Menu;
            cvTempUnit.FormattingEnabled = true;
            cvTempUnit.Location = new Point(888, 105);
            cvTempUnit.Name = "cvTempUnit";
            cvTempUnit.Size = new Size(72, 33);
            cvTempUnit.TabIndex = 9;
            // 
            // btnCalcLeak1
            // 
            btnCalcLeak1.AutoSize = true;
            btnCalcLeak1.BackColor = SystemColors.ActiveCaption;
            btnCalcLeak1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcLeak1.Location = new Point(327, 146);
            btnCalcLeak1.Name = "btnCalcLeak1";
            btnCalcLeak1.Size = new Size(113, 47);
            btnCalcLeak1.TabIndex = 10;
            btnCalcLeak1.Text = "Calculate";
            btnCalcLeak1.UseVisualStyleBackColor = false;
            btnCalcLeak1.Click += btnCalcLeak1_Click;
            // 
            // btnClearLeak1
            // 
            btnClearLeak1.BackColor = Color.WhiteSmoke;
            btnClearLeak1.Location = new Point(446, 146);
            btnClearLeak1.Name = "btnClearLeak1";
            btnClearLeak1.Size = new Size(108, 47);
            btnClearLeak1.TabIndex = 11;
            btnClearLeak1.Text = "Clear";
            btnClearLeak1.UseVisualStyleBackColor = false;
            btnClearLeak1.Click += btnClearLeak1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(202, 202, 238);
            panel1.Controls.Add(lblResultLeak1);
            panel1.Location = new Point(582, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 47);
            panel1.TabIndex = 12;
            // 
            // lblResultLeak1
            // 
            lblResultLeak1.AutoSize = true;
            lblResultLeak1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultLeak1.Location = new Point(62, 13);
            lblResultLeak1.Name = "lblResultLeak1";
            lblResultLeak1.Size = new Size(66, 22);
            lblResultLeak1.TabIndex = 0;
            lblResultLeak1.Text = "Result:";
            lblResultLeak1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnClear2);
            panel2.Controls.Add(btnCalcLeak2);
            panel2.Controls.Add(pnlResult2);
            panel2.Controls.Add(cbP1orLeak);
            panel2.Controls.Add(cbDeltaTime);
            panel2.Controls.Add(cbVolume);
            panel2.Controls.Add(cbP1);
            panel2.Controls.Add(txtP1orLeak);
            panel2.Controls.Add(txtDeltaTime);
            panel2.Controls.Add(txtVolume);
            panel2.Controls.Add(txtP1);
            panel2.Controls.Add(lblP1orLeak);
            panel2.Controls.Add(lblDeltaTime);
            panel2.Controls.Add(lblVolume);
            panel2.Controls.Add(lblP1);
            panel2.Controls.Add(gprBoxRadio);
            panel2.Controls.Add(lbl2);
            panel2.Location = new Point(-4, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 392);
            panel2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(27, 335);
            label3.Name = "label3";
            label3.Size = new Size(410, 21);
            label3.TabIndex = 19;
            label3.Text = "NB: Relative pressures must be entered and are calculated";
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.WhiteSmoke;
            btnClear2.Location = new Point(821, 182);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(102, 49);
            btnClear2.TabIndex = 18;
            btnClear2.Text = "Clear";
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnCalcLeak2
            // 
            btnCalcLeak2.BackColor = SystemColors.ActiveCaption;
            btnCalcLeak2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcLeak2.Location = new Point(661, 182);
            btnCalcLeak2.Name = "btnCalcLeak2";
            btnCalcLeak2.Size = new Size(124, 49);
            btnCalcLeak2.TabIndex = 17;
            btnCalcLeak2.Text = "Calculate";
            btnCalcLeak2.UseVisualStyleBackColor = false;
            btnCalcLeak2.Click += btnCalcLeak2_Click;
            // 
            // pnlResult2
            // 
            pnlResult2.BackColor = Color.FromArgb(202, 202, 238);
            pnlResult2.Controls.Add(lblResult2Tool2);
            pnlResult2.Controls.Add(lblResult1Tool2);
            pnlResult2.Location = new Point(597, 253);
            pnlResult2.Name = "pnlResult2";
            pnlResult2.Size = new Size(395, 68);
            pnlResult2.TabIndex = 16;
            // 
            // lblResult2Tool2
            // 
            lblResult2Tool2.AutoSize = true;
            lblResult2Tool2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult2Tool2.Location = new Point(3, 35);
            lblResult2Tool2.Name = "lblResult2Tool2";
            lblResult2Tool2.Size = new Size(206, 22);
            lblResult2Tool2.TabIndex = 1;
            lblResult2Tool2.Text = "Pressure drop over time:";
            // 
            // lblResult1Tool2
            // 
            lblResult1Tool2.AutoSize = true;
            lblResult1Tool2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult1Tool2.Location = new Point(3, 5);
            lblResult1Tool2.Name = "lblResult1Tool2";
            lblResult1Tool2.Size = new Size(233, 22);
            lblResult1Tool2.TabIndex = 0;
            lblResult1Tool2.Text = "Leakrate (or final cal press):";
            // 
            // cbP1orLeak
            // 
            cbP1orLeak.BackColor = SystemColors.Control;
            cbP1orLeak.FormattingEnabled = true;
            cbP1orLeak.Location = new Point(487, 288);
            cbP1orLeak.Name = "cbP1orLeak";
            cbP1orLeak.Size = new Size(91, 33);
            cbP1orLeak.TabIndex = 15;
            // 
            // cbDeltaTime
            // 
            cbDeltaTime.BackColor = SystemColors.Control;
            cbDeltaTime.FormattingEnabled = true;
            cbDeltaTime.Location = new Point(487, 253);
            cbDeltaTime.Name = "cbDeltaTime";
            cbDeltaTime.Size = new Size(91, 33);
            cbDeltaTime.TabIndex = 14;
            // 
            // cbVolume
            // 
            cbVolume.BackColor = SystemColors.Control;
            cbVolume.FormattingEnabled = true;
            cbVolume.Location = new Point(487, 218);
            cbVolume.Name = "cbVolume";
            cbVolume.Size = new Size(91, 33);
            cbVolume.TabIndex = 13;
            // 
            // cbP1
            // 
            cbP1.BackColor = SystemColors.Control;
            cbP1.FormattingEnabled = true;
            cbP1.Location = new Point(487, 182);
            cbP1.Name = "cbP1";
            cbP1.Size = new Size(91, 33);
            cbP1.TabIndex = 12;
            // 
            // txtP1orLeak
            // 
            txtP1orLeak.Location = new Point(331, 288);
            txtP1orLeak.Name = "txtP1orLeak";
            txtP1orLeak.Size = new Size(150, 31);
            txtP1orLeak.TabIndex = 11;
            // 
            // txtDeltaTime
            // 
            txtDeltaTime.Location = new Point(331, 253);
            txtDeltaTime.Name = "txtDeltaTime";
            txtDeltaTime.Size = new Size(150, 31);
            txtDeltaTime.TabIndex = 10;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(331, 219);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(150, 31);
            txtVolume.TabIndex = 9;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(331, 182);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(150, 31);
            txtP1.TabIndex = 8;
            // 
            // lblP1orLeak
            // 
            lblP1orLeak.AutoSize = true;
            lblP1orLeak.Location = new Point(27, 291);
            lblP1orLeak.Name = "lblP1orLeak";
            lblP1orLeak.Size = new Size(257, 25);
            lblP1orLeak.TabIndex = 7;
            lblP1orLeak.Text = "Final Pressure or Valve Leakrate";
            // 
            // lblDeltaTime
            // 
            lblDeltaTime.AutoSize = true;
            lblDeltaTime.Location = new Point(27, 253);
            lblDeltaTime.Name = "lblDeltaTime";
            lblDeltaTime.Size = new Size(127, 25);
            lblDeltaTime.TabIndex = 6;
            lblDeltaTime.Text = "Period of Time";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(27, 218);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(72, 25);
            lblVolume.TabIndex = 5;
            lblVolume.Text = "Volume";
            // 
            // lblP1
            // 
            lblP1.AutoSize = true;
            lblP1.Location = new Point(27, 182);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(125, 25);
            lblP1.TabIndex = 4;
            lblP1.Text = "Initial Pressure";
            // 
            // gprBoxRadio
            // 
            gprBoxRadio.Controls.Add(rbLeakCalc);
            gprBoxRadio.Controls.Add(rbDeltaPCalc);
            gprBoxRadio.Location = new Point(27, 57);
            gprBoxRadio.Name = "gprBoxRadio";
            gprBoxRadio.Size = new Size(965, 104);
            gprBoxRadio.TabIndex = 3;
            gprBoxRadio.TabStop = false;
            gprBoxRadio.Text = "Calculation Type";
            // 
            // rbLeakCalc
            // 
            rbLeakCalc.AutoSize = true;
            rbLeakCalc.Location = new Point(12, 30);
            rbLeakCalc.Name = "rbLeakCalc";
            rbLeakCalc.Size = new Size(884, 29);
            rbLeakCalc.TabIndex = 0;
            rbLeakCalc.TabStop = true;
            rbLeakCalc.Text = "Calculate a LEAK FLOW RATE using a PRESSURE DROP over a known period of TIME, from a know VOLUME\r\n";
            rbLeakCalc.UseVisualStyleBackColor = true;
            rbLeakCalc.CheckedChanged += rbLeakCalc_CheckedChanged;
            // 
            // rbDeltaPCalc
            // 
            rbDeltaPCalc.AutoSize = true;
            rbDeltaPCalc.Location = new Point(12, 65);
            rbDeltaPCalc.Name = "rbDeltaPCalc";
            rbDeltaPCalc.Size = new Size(925, 29);
            rbDeltaPCalc.TabIndex = 1;
            rbDeltaPCalc.TabStop = true;
            rbDeltaPCalc.Text = "Calculate a PRESSURE DROP in a known VOLUME over a known period of TIME, from a known VALVE LEAK RATE\r\n";
            rbDeltaPCalc.UseVisualStyleBackColor = true;
            rbDeltaPCalc.CheckedChanged += rbDeltaPCalc_CheckedChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(27, 17);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(396, 25);
            lbl2.TabIndex = 2;
            lbl2.Text = "Leakage from closed volume calculation";
            // 
            // FormLeakage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 634);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnClearLeak1);
            Controls.Add(btnCalcLeak1);
            Controls.Add(cvTempUnit);
            Controls.Add(txtTemperature);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPressureUnit);
            Controls.Add(lblValueLeak);
            Controls.Add(txtValueLeak);
            Controls.Add(lbl1);
            Controls.Add(lblPressure);
            Controls.Add(cbLeakFormulaSelection);
            Name = "FormLeakage";
            Text = "Leakage Formulas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlResult2.ResumeLayout(false);
            pnlResult2.PerformLayout();
            gprBoxRadio.ResumeLayout(false);
            gprBoxRadio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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