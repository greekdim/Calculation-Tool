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
            this.lblUnitFlow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBFlow = new System.Windows.Forms.RadioButton();
            this.rBCv = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFlowResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.tBoxGravity = new System.Windows.Forms.TextBox();
            this.cBOutPressUnit = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cBInPressUnit = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cBMedium = new System.Windows.Forms.ComboBox();
            this.cBTempUnit = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cBMediumType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.comboBoxCvKvOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.panel3.Controls.Add(this.lblUnitFlow);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.lblUnitName);
            this.panel3.Controls.Add(this.tBoxGravity);
            this.panel3.Controls.Add(this.cBOutPressUnit);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.cBInPressUnit);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.cBMedium);
            this.panel3.Controls.Add(this.cBTempUnit);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.cBMediumType);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 635);
            this.panel3.TabIndex = 1;
            // 
            // lblUnitFlow
            // 
            this.lblUnitFlow.AutoSize = true;
            this.lblUnitFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitFlow.ForeColor = System.Drawing.Color.Black;
            this.lblUnitFlow.Location = new System.Drawing.Point(374, 460);
            this.lblUnitFlow.Name = "lblUnitFlow";
            this.lblUnitFlow.Size = new System.Drawing.Size(42, 22);
            this.lblUnitFlow.TabIndex = 30;
            this.lblUnitFlow.Text = "Unit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBFlow);
            this.groupBox1.Controls.Add(this.rBCv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 76);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Type";
            // 
            // rBFlow
            // 
            this.rBFlow.AutoSize = true;
            this.rBFlow.Location = new System.Drawing.Point(181, 36);
            this.rBFlow.Name = "rBFlow";
            this.rBFlow.Size = new System.Drawing.Size(116, 26);
            this.rBFlow.TabIndex = 1;
            this.rBFlow.Text = "Flow Rate";
            this.rBFlow.UseVisualStyleBackColor = true;
            // 
            // rBCv
            // 
            this.rBCv.AutoSize = true;
            this.rBCv.Checked = true;
            this.rBCv.Location = new System.Drawing.Point(6, 36);
            this.rBCv.Name = "rBCv";
            this.rBCv.Size = new System.Drawing.Size(57, 26);
            this.rBCv.TabIndex = 0;
            this.rBCv.TabStop = true;
            this.rBCv.Text = "Cv";
            this.rBCv.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.panel4.Controls.Add(this.lblFlowResult);
            this.panel4.Location = new System.Drawing.Point(374, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 50);
            this.panel4.TabIndex = 28;
            // 
            // lblFlowResult
            // 
            this.lblFlowResult.AutoSize = true;
            this.lblFlowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFlowResult.ForeColor = System.Drawing.Color.Black;
            this.lblFlowResult.Location = new System.Drawing.Point(20, 14);
            this.lblFlowResult.Name = "lblFlowResult";
            this.lblFlowResult.Size = new System.Drawing.Size(53, 22);
            this.lblFlowResult.TabIndex = 29;
            this.lblFlowResult.Text = "Cv = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 455);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 31);
            this.textBox6.TabIndex = 25;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitName.ForeColor = System.Drawing.Color.Black;
            this.lblUnitName.Location = new System.Drawing.Point(37, 460);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(91, 22);
            this.lblUnitName.TabIndex = 23;
            this.lblUnitName.Text = "Flow Rate";
            // 
            // tBoxGravity
            // 
            this.tBoxGravity.BackColor = System.Drawing.SystemColors.Menu;
            this.tBoxGravity.Enabled = false;
            this.tBoxGravity.Location = new System.Drawing.Point(218, 405);
            this.tBoxGravity.Name = "tBoxGravity";
            this.tBoxGravity.Size = new System.Drawing.Size(82, 31);
            this.tBoxGravity.TabIndex = 22;
            // 
            // cBOutPressUnit
            // 
            this.cBOutPressUnit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cBOutPressUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBOutPressUnit.FormattingEnabled = true;
            this.cBOutPressUnit.Items.AddRange(new object[] {
            "PSIA",
            "bar"});
            this.cBOutPressUnit.Location = new System.Drawing.Point(306, 355);
            this.cBOutPressUnit.Name = "cBOutPressUnit";
            this.cBOutPressUnit.Size = new System.Drawing.Size(94, 33);
            this.cBOutPressUnit.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 355);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 31);
            this.textBox4.TabIndex = 20;
            // 
            // cBInPressUnit
            // 
            this.cBInPressUnit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cBInPressUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBInPressUnit.FormattingEnabled = true;
            this.cBInPressUnit.Items.AddRange(new object[] {
            "PSIA",
            "bar"});
            this.cBInPressUnit.Location = new System.Drawing.Point(306, 305);
            this.cBInPressUnit.Name = "cBInPressUnit";
            this.cBInPressUnit.Size = new System.Drawing.Size(94, 33);
            this.cBInPressUnit.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 305);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 31);
            this.textBox3.TabIndex = 18;
            // 
            // cBMedium
            // 
            this.cBMedium.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cBMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMedium.FormattingEnabled = true;
            this.cBMedium.Location = new System.Drawing.Point(218, 255);
            this.cBMedium.Name = "cBMedium";
            this.cBMedium.Size = new System.Drawing.Size(182, 33);
            this.cBMedium.TabIndex = 17;
            this.cBMedium.SelectedIndexChanged += new System.EventHandler(this.cBMedium_SelectedIndexChanged);
            // 
            // cBTempUnit
            // 
            this.cBTempUnit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cBTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTempUnit.FormattingEnabled = true;
            this.cBTempUnit.Items.AddRange(new object[] {
            "°C",
            "°F"});
            this.cBTempUnit.Location = new System.Drawing.Point(306, 210);
            this.cBTempUnit.Name = "cBTempUnit";
            this.cBTempUnit.Size = new System.Drawing.Size(94, 33);
            this.cBTempUnit.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 31);
            this.textBox2.TabIndex = 15;
            // 
            // cBMediumType
            // 
            this.cBMediumType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cBMediumType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMediumType.FormattingEnabled = true;
            this.cBMediumType.Items.AddRange(new object[] {
            "Liquid",
            "Gas"});
            this.cBMediumType.Location = new System.Drawing.Point(218, 155);
            this.cBMediumType.Name = "cBMediumType";
            this.cBMediumType.Size = new System.Drawing.Size(182, 33);
            this.cBMediumType.TabIndex = 14;
            this.cBMediumType.SelectedIndexChanged += new System.EventHandler(this.cBMediumType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 160);
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
            this.label10.Location = new System.Drawing.Point(37, 210);
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
            this.label9.Location = new System.Drawing.Point(37, 260);
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
            this.label8.Location = new System.Drawing.Point(37, 310);
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
            this.label7.Location = new System.Drawing.Point(37, 360);
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
            this.label6.Location = new System.Drawing.Point(37, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gravity";
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 524);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 52);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // FormFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.Controls.Add(this.btnClear);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label lblUnitName;
        private TextBox tBoxGravity;
        private ComboBox cBOutPressUnit;
        private TextBox textBox4;
        private ComboBox cBInPressUnit;
        private TextBox textBox3;
        private ComboBox cBMedium;
        private ComboBox cBTempUnit;
        private TextBox textBox2;
        private ComboBox cBMediumType;
        private Panel panel4;
        private Label lblFlowResult;
        private Button button1;
        private TextBox textBox6;
        private Button btnCalculateOrifice;
        private GroupBox groupBox1;
        private RadioButton rBFlow;
        private RadioButton rBCv;
        private Label lblUnitFlow;
        private Button btnClear;
    }
}