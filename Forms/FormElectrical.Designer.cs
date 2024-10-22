namespace Calc_Tool___Rev_A.Forms
{
    partial class FormElectrical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElectrical));
            label1 = new Label();
            lblVoltage = new Label();
            lblCurrent = new Label();
            lblR = new Label();
            lblWattage = new Label();
            txtVoltage = new TextBox();
            txtCurrent = new TextBox();
            txtR = new TextBox();
            txtWattage = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcOhmLaw = new Button();
            btnClearOhmLaw = new Button();
            picURIPUI = new PictureBox();
            picBoxURIPUI = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picURIPUI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxURIPUI).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter 2 values ";
            // 
            // lblVoltage
            // 
            lblVoltage.AutoSize = true;
            lblVoltage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltage.Location = new Point(35, 103);
            lblVoltage.Name = "lblVoltage";
            lblVoltage.Size = new Size(101, 22);
            lblVoltage.TabIndex = 1;
            lblVoltage.Text = "U (Voltage)";
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrent.Location = new Point(35, 155);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(91, 22);
            lblCurrent.TabIndex = 2;
            lblCurrent.Text = "I (Current)";
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblR.Location = new Point(35, 207);
            lblR.Name = "lblR";
            lblR.Size = new Size(129, 22);
            lblR.TabIndex = 3;
            lblR.Text = "R (Resistance)";
            // 
            // lblWattage
            // 
            lblWattage.AutoSize = true;
            lblWattage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblWattage.Location = new Point(35, 262);
            lblWattage.Name = "lblWattage";
            lblWattage.Size = new Size(172, 22);
            lblWattage.TabIndex = 4;
            lblWattage.Text = "P (Power / Wattage)";
            // 
            // txtVoltage
            // 
            txtVoltage.Location = new Point(254, 103);
            txtVoltage.Name = "txtVoltage";
            txtVoltage.Size = new Size(150, 31);
            txtVoltage.TabIndex = 5;
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(254, 155);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(150, 31);
            txtCurrent.TabIndex = 6;
            // 
            // txtR
            // 
            txtR.Location = new Point(254, 207);
            txtR.Name = "txtR";
            txtR.Size = new Size(150, 31);
            txtR.TabIndex = 7;
            // 
            // txtWattage
            // 
            txtWattage.Location = new Point(254, 262);
            txtWattage.Name = "txtWattage";
            txtWattage.Size = new Size(150, 31);
            txtWattage.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(410, 108);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 9;
            label2.Text = "V (Volts)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(410, 160);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 10;
            label3.Text = "A (Ampere)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(410, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 11;
            label4.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(410, 212);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 12;
            label5.Text = "Ω (Ohm)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(410, 267);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 13;
            label6.Text = "W (Watt)";
            // 
            // btnCalcOhmLaw
            // 
            btnCalcOhmLaw.BackColor = SystemColors.ActiveCaption;
            btnCalcOhmLaw.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcOhmLaw.Location = new Point(254, 328);
            btnCalcOhmLaw.Name = "btnCalcOhmLaw";
            btnCalcOhmLaw.Size = new Size(150, 52);
            btnCalcOhmLaw.TabIndex = 28;
            btnCalcOhmLaw.Text = "Calculate";
            btnCalcOhmLaw.UseVisualStyleBackColor = false;
            btnCalcOhmLaw.Click += btnCalcOhmLaw_Click;
            // 
            // btnClearOhmLaw
            // 
            btnClearOhmLaw.Location = new Point(254, 392);
            btnClearOhmLaw.Name = "btnClearOhmLaw";
            btnClearOhmLaw.Size = new Size(150, 35);
            btnClearOhmLaw.TabIndex = 29;
            btnClearOhmLaw.Text = "Clear";
            btnClearOhmLaw.UseVisualStyleBackColor = true;
            btnClearOhmLaw.Click += btnClearOhmLaw_Click;
            // 
            // picURIPUI
            // 
            picURIPUI.Image = (Image)resources.GetObject("picURIPUI.Image");
            picURIPUI.Location = new Point(538, 35);
            picURIPUI.Name = "picURIPUI";
            picURIPUI.Size = new Size(449, 441);
            picURIPUI.SizeMode = PictureBoxSizeMode.Zoom;
            picURIPUI.TabIndex = 30;
            picURIPUI.TabStop = false;
            // 
            // picBoxURIPUI
            // 
            picBoxURIPUI.Image = (Image)resources.GetObject("picBoxURIPUI.Image");
            picBoxURIPUI.Location = new Point(488, 35);
            picBoxURIPUI.Name = "picBoxURIPUI";
            picBoxURIPUI.Size = new Size(32, 32);
            picBoxURIPUI.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxURIPUI.TabIndex = 31;
            picBoxURIPUI.TabStop = false;
            picBoxURIPUI.Click += picBoxURIPUI_Click;
            // 
            // FormElectrical
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 579);
            Controls.Add(picBoxURIPUI);
            Controls.Add(picURIPUI);
            Controls.Add(btnClearOhmLaw);
            Controls.Add(btnCalcOhmLaw);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtWattage);
            Controls.Add(txtR);
            Controls.Add(txtCurrent);
            Controls.Add(txtVoltage);
            Controls.Add(lblWattage);
            Controls.Add(lblR);
            Controls.Add(lblCurrent);
            Controls.Add(lblVoltage);
            Controls.Add(label1);
            Name = "FormElectrical";
            Text = "Electrical Formulas";
            ((System.ComponentModel.ISupportInitialize)picURIPUI).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxURIPUI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVoltage;
        private Label lblCurrent;
        private Label lblR;
        private Label lblWattage;
        private TextBox txtVoltage;
        private TextBox txtCurrent;
        private TextBox txtR;
        private TextBox txtWattage;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcOhmLaw;
        private Button btnClearOhmLaw;
        private PictureBox picURIPUI;
        private PictureBox picBoxURIPUI;
    }
}