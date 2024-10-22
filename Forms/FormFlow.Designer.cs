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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlow));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnClearCvKvO = new Button();
            btnCalculateOrifice = new Button();
            label2 = new Label();
            panel2 = new Panel();
            lblResult1 = new Label();
            comboBoxCvKvOr = new ComboBox();
            txtValueToCalc = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            lblUnitFlow = new Label();
            groupBox1 = new GroupBox();
            picBoxCalcType = new PictureBox();
            rBFlow = new RadioButton();
            rBCv = new RadioButton();
            panel4 = new Panel();
            lblFlowResult = new Label();
            btnCalcFlow = new Button();
            txtFlowInitial = new TextBox();
            lblUnitName = new Label();
            tBoxGravity = new TextBox();
            cBOutPressUnit = new ComboBox();
            txtPout = new TextBox();
            cBInPressUnit = new ComboBox();
            txtPin = new TextBox();
            cBMedium = new ComboBox();
            cBTempUnit = new ComboBox();
            txtTemp = new TextBox();
            cBMediumType = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnClear = new Button();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCalcType).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClearCvKvO);
            panel1.Controls.Add(btnCalculateOrifice);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBoxCvKvOr);
            panel1.Controls.Add(txtValueToCalc);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(648, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 316);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(290, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnClearCvKvO
            // 
            btnClearCvKvO.Location = new Point(226, 251);
            btnClearCvKvO.Name = "btnClearCvKvO";
            btnClearCvKvO.Size = new Size(63, 34);
            btnClearCvKvO.TabIndex = 30;
            btnClearCvKvO.Text = "Clear";
            btnClearCvKvO.UseVisualStyleBackColor = true;
            btnClearCvKvO.Click += btnClearCvKvO_Click;
            // 
            // btnCalculateOrifice
            // 
            btnCalculateOrifice.BackColor = SystemColors.ActiveCaption;
            btnCalculateOrifice.Location = new Point(35, 249);
            btnCalculateOrifice.Name = "btnCalculateOrifice";
            btnCalculateOrifice.Size = new Size(150, 38);
            btnCalculateOrifice.TabIndex = 29;
            btnCalculateOrifice.Text = "Calculate";
            btnCalculateOrifice.UseVisualStyleBackColor = false;
            btnCalculateOrifice.Click += btnCalculateOrifice_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 138);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Result";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(202, 202, 238);
            panel2.Controls.Add(lblResult1);
            panel2.Location = new Point(35, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 70);
            panel2.TabIndex = 4;
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult1.ForeColor = Color.Black;
            lblResult1.Location = new Point(3, 7);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(159, 25);
            lblResult1.TabIndex = 4;
            lblResult1.Text = "Kv = 3 // Orifice=";
            // 
            // comboBoxCvKvOr
            // 
            comboBoxCvKvOr.BackColor = SystemColors.MenuBar;
            comboBoxCvKvOr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCvKvOr.FormattingEnabled = true;
            comboBoxCvKvOr.Items.AddRange(new object[] { "Cv to Kv and orifice", "Kv to Cv and orifice", "Orifice to Cv and Kv" });
            comboBoxCvKvOr.Location = new Point(35, 93);
            comboBoxCvKvOr.Name = "comboBoxCvKvOr";
            comboBoxCvKvOr.Size = new Size(254, 33);
            comboBoxCvKvOr.TabIndex = 2;
            // 
            // txtValueToCalc
            // 
            txtValueToCalc.Location = new Point(35, 55);
            txtValueToCalc.Name = "txtValueToCalc";
            txtValueToCalc.Size = new Size(150, 31);
            txtValueToCalc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Convert Cv, Kv, Orifice ";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblUnitFlow);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnCalcFlow);
            panel3.Controls.Add(txtFlowInitial);
            panel3.Controls.Add(lblUnitName);
            panel3.Controls.Add(tBoxGravity);
            panel3.Controls.Add(cBOutPressUnit);
            panel3.Controls.Add(txtPout);
            panel3.Controls.Add(cBInPressUnit);
            panel3.Controls.Add(txtPin);
            panel3.Controls.Add(cBMedium);
            panel3.Controls.Add(cBTempUnit);
            panel3.Controls.Add(txtTemp);
            panel3.Controls.Add(cBMediumType);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 635);
            panel3.TabIndex = 1;
            // 
            // lblUnitFlow
            // 
            lblUnitFlow.AutoSize = true;
            lblUnitFlow.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitFlow.ForeColor = Color.Black;
            lblUnitFlow.Location = new Point(374, 460);
            lblUnitFlow.Name = "lblUnitFlow";
            lblUnitFlow.Size = new Size(42, 22);
            lblUnitFlow.TabIndex = 30;
            lblUnitFlow.Text = "Unit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picBoxCalcType);
            groupBox1.Controls.Add(rBFlow);
            groupBox1.Controls.Add(rBCv);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(37, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 76);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculation Type";
            // 
            // picBoxCalcType
            // 
            picBoxCalcType.Image = (Image)resources.GetObject("picBoxCalcType.Image");
            picBoxCalcType.Location = new Point(331, 11);
            picBoxCalcType.Name = "picBoxCalcType";
            picBoxCalcType.Size = new Size(32, 32);
            picBoxCalcType.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxCalcType.TabIndex = 31;
            picBoxCalcType.TabStop = false;
            picBoxCalcType.Click += picBoxCalcType_Click;
            // 
            // rBFlow
            // 
            rBFlow.AutoSize = true;
            rBFlow.Location = new Point(181, 36);
            rBFlow.Name = "rBFlow";
            rBFlow.Size = new Size(116, 26);
            rBFlow.TabIndex = 1;
            rBFlow.Text = "Flow Rate";
            rBFlow.UseVisualStyleBackColor = true;
            // 
            // rBCv
            // 
            rBCv.AutoSize = true;
            rBCv.Checked = true;
            rBCv.Location = new Point(6, 36);
            rBCv.Name = "rBCv";
            rBCv.Size = new Size(57, 26);
            rBCv.TabIndex = 0;
            rBCv.TabStop = true;
            rBCv.Text = "Cv";
            rBCv.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(202, 202, 238);
            panel4.Controls.Add(lblFlowResult);
            panel4.Location = new Point(374, 524);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 50);
            panel4.TabIndex = 28;
            // 
            // lblFlowResult
            // 
            lblFlowResult.AutoSize = true;
            lblFlowResult.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFlowResult.ForeColor = Color.Black;
            lblFlowResult.Location = new Point(20, 14);
            lblFlowResult.Name = "lblFlowResult";
            lblFlowResult.Size = new Size(53, 22);
            lblFlowResult.TabIndex = 29;
            lblFlowResult.Text = "Cv = ";
            // 
            // btnCalcFlow
            // 
            btnCalcFlow.BackColor = SystemColors.ActiveCaption;
            btnCalcFlow.Location = new Point(218, 522);
            btnCalcFlow.Name = "btnCalcFlow";
            btnCalcFlow.Size = new Size(150, 52);
            btnCalcFlow.TabIndex = 27;
            btnCalcFlow.Text = "Calculate";
            btnCalcFlow.UseVisualStyleBackColor = false;
            btnCalcFlow.Click += btnCalcFlow_Click;
            // 
            // txtFlowInitial
            // 
            txtFlowInitial.Location = new Point(218, 455);
            txtFlowInitial.Name = "txtFlowInitial";
            txtFlowInitial.Size = new Size(150, 31);
            txtFlowInitial.TabIndex = 25;
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitName.ForeColor = Color.Black;
            lblUnitName.Location = new Point(37, 460);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(91, 22);
            lblUnitName.TabIndex = 23;
            lblUnitName.Text = "Flow Rate";
            // 
            // tBoxGravity
            // 
            tBoxGravity.BackColor = SystemColors.Menu;
            tBoxGravity.Enabled = false;
            tBoxGravity.Location = new Point(218, 405);
            tBoxGravity.Name = "tBoxGravity";
            tBoxGravity.Size = new Size(82, 31);
            tBoxGravity.TabIndex = 22;
            // 
            // cBOutPressUnit
            // 
            cBOutPressUnit.BackColor = SystemColors.MenuBar;
            cBOutPressUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cBOutPressUnit.FormattingEnabled = true;
            cBOutPressUnit.Items.AddRange(new object[] { "PSIA", "bar" });
            cBOutPressUnit.Location = new Point(306, 355);
            cBOutPressUnit.Name = "cBOutPressUnit";
            cBOutPressUnit.Size = new Size(94, 33);
            cBOutPressUnit.TabIndex = 21;
            toolTip1.SetToolTip(cBOutPressUnit, "Enter absolute pressure value");
            // 
            // txtPout
            // 
            txtPout.Location = new Point(218, 355);
            txtPout.Name = "txtPout";
            txtPout.Size = new Size(82, 31);
            txtPout.TabIndex = 20;
            // 
            // cBInPressUnit
            // 
            cBInPressUnit.BackColor = SystemColors.MenuBar;
            cBInPressUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cBInPressUnit.FormattingEnabled = true;
            cBInPressUnit.Items.AddRange(new object[] { "PSIA", "bar" });
            cBInPressUnit.Location = new Point(306, 305);
            cBInPressUnit.Name = "cBInPressUnit";
            cBInPressUnit.Size = new Size(94, 33);
            cBInPressUnit.TabIndex = 19;
            toolTip1.SetToolTip(cBInPressUnit, "Enter absolute pressure value");
            // 
            // txtPin
            // 
            txtPin.Location = new Point(218, 305);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(82, 31);
            txtPin.TabIndex = 18;
            // 
            // cBMedium
            // 
            cBMedium.BackColor = SystemColors.MenuBar;
            cBMedium.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMedium.FormattingEnabled = true;
            cBMedium.Location = new Point(218, 255);
            cBMedium.Name = "cBMedium";
            cBMedium.Size = new Size(182, 33);
            cBMedium.TabIndex = 17;
            cBMedium.SelectedIndexChanged += cBMedium_SelectedIndexChanged;
            // 
            // cBTempUnit
            // 
            cBTempUnit.BackColor = SystemColors.MenuBar;
            cBTempUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTempUnit.FormattingEnabled = true;
            cBTempUnit.Items.AddRange(new object[] { "°C", "°F" });
            cBTempUnit.Location = new Point(306, 210);
            cBTempUnit.Name = "cBTempUnit";
            cBTempUnit.Size = new Size(94, 33);
            cBTempUnit.TabIndex = 16;
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(218, 210);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(82, 31);
            txtTemp.TabIndex = 15;
            // 
            // cBMediumType
            // 
            cBMediumType.BackColor = SystemColors.Menu;
            cBMediumType.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMediumType.ForeColor = SystemColors.WindowText;
            cBMediumType.FormattingEnabled = true;
            cBMediumType.Items.AddRange(new object[] { "Liquid", "Gas" });
            cBMediumType.Location = new Point(218, 155);
            cBMediumType.Name = "cBMediumType";
            cBMediumType.Size = new Size(182, 33);
            cBMediumType.TabIndex = 14;
            cBMediumType.SelectedIndexChanged += cBMediumType_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(37, 160);
            label11.Name = "label11";
            label11.Size = new Size(118, 22);
            label11.TabIndex = 12;
            label11.Text = "Medium Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(37, 210);
            label10.Name = "label10";
            label10.Size = new Size(113, 22);
            label10.TabIndex = 11;
            label10.Text = "Temperature";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(37, 260);
            label9.Name = "label9";
            label9.Size = new Size(72, 22);
            label9.TabIndex = 10;
            label9.Text = "Medium";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(37, 310);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 9;
            label8.Text = "Inlet Pressure";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(37, 360);
            label7.Name = "label7";
            label7.Size = new Size(135, 22);
            label7.TabIndex = 8;
            label7.Text = "Outlet Pressure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(37, 410);
            label6.Name = "label6";
            label6.Size = new Size(67, 22);
            label6.TabIndex = 7;
            label6.Text = "Gravity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 21);
            label4.Name = "label4";
            label4.Size = new Size(256, 25);
            label4.TabIndex = 5;
            label4.Text = "Detailed Flow Calculation";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(688, 524);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 52);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormFlow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 634);
            Controls.Add(btnClear);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormFlow";
            Text = "Flow - Orifice - Cv";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCalcType).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
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
        private TextBox txtPout;
        private ComboBox cBInPressUnit;
        private TextBox txtPin;
        private ComboBox cBMedium;
        private ComboBox cBTempUnit;
        private TextBox txtTemp;
        private ComboBox cBMediumType;
        private Panel panel4;
        private Label lblFlowResult;
        private Button btnCalcFlow;
        private TextBox txtFlowInitial;
        private Button btnCalculateOrifice;
        private GroupBox groupBox1;
        private RadioButton rBFlow;
        private RadioButton rBCv;
        private Label lblUnitFlow;
        private Button btnClear;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
        private Button btnClearCvKvO;
        private PictureBox pictureBox1;
        private PictureBox picBoxCalcType;
    }
}