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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblWattage = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtWattage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcOhmLaw = new System.Windows.Forms.Button();
            this.btnClearOhmLaw = new System.Windows.Forms.Button();
            this.picURIPUI = new System.Windows.Forms.PictureBox();
            this.picBoxURIPUI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picURIPUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxURIPUI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 2 values ";
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVoltage.Location = new System.Drawing.Point(35, 103);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(101, 22);
            this.lblVoltage.TabIndex = 1;
            this.lblVoltage.Text = "U (Voltage)";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrent.Location = new System.Drawing.Point(35, 155);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(91, 22);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "I (Current)";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblR.Location = new System.Drawing.Point(35, 207);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(129, 22);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "R (Resistance)";
            // 
            // lblWattage
            // 
            this.lblWattage.AutoSize = true;
            this.lblWattage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWattage.Location = new System.Drawing.Point(35, 262);
            this.lblWattage.Name = "lblWattage";
            this.lblWattage.Size = new System.Drawing.Size(172, 22);
            this.lblWattage.TabIndex = 4;
            this.lblWattage.Text = "P (Power / Wattage)";
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(254, 103);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(150, 31);
            this.txtVoltage.TabIndex = 5;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(254, 155);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(150, 31);
            this.txtCurrent.TabIndex = 6;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(254, 207);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(150, 31);
            this.txtR.TabIndex = 7;
            // 
            // txtWattage
            // 
            this.txtWattage.Location = new System.Drawing.Point(254, 262);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(150, 31);
            this.txtWattage.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(410, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "V (Volts)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(410, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "A (Ampere)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(410, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(410, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ω (Ohm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(410, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "W (Watt)";
            // 
            // btnCalcOhmLaw
            // 
            this.btnCalcOhmLaw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcOhmLaw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcOhmLaw.Location = new System.Drawing.Point(254, 328);
            this.btnCalcOhmLaw.Name = "btnCalcOhmLaw";
            this.btnCalcOhmLaw.Size = new System.Drawing.Size(150, 52);
            this.btnCalcOhmLaw.TabIndex = 28;
            this.btnCalcOhmLaw.Text = "Calculate";
            this.btnCalcOhmLaw.UseVisualStyleBackColor = false;
            this.btnCalcOhmLaw.Click += new System.EventHandler(this.btnCalcOhmLaw_Click);
            // 
            // btnClearOhmLaw
            // 
            this.btnClearOhmLaw.Location = new System.Drawing.Point(254, 392);
            this.btnClearOhmLaw.Name = "btnClearOhmLaw";
            this.btnClearOhmLaw.Size = new System.Drawing.Size(150, 35);
            this.btnClearOhmLaw.TabIndex = 29;
            this.btnClearOhmLaw.Text = "Clear";
            this.btnClearOhmLaw.UseVisualStyleBackColor = true;
            this.btnClearOhmLaw.Click += new System.EventHandler(this.btnClearOhmLaw_Click);
            // 
            // picURIPUI
            // 
            this.picURIPUI.Image = ((System.Drawing.Image)(resources.GetObject("picURIPUI.Image")));
            this.picURIPUI.Location = new System.Drawing.Point(538, 35);
            this.picURIPUI.Name = "picURIPUI";
            this.picURIPUI.Size = new System.Drawing.Size(449, 441);
            this.picURIPUI.TabIndex = 30;
            this.picURIPUI.TabStop = false;
            // 
            // picBoxURIPUI
            // 
            this.picBoxURIPUI.Image = ((System.Drawing.Image)(resources.GetObject("picBoxURIPUI.Image")));
            this.picBoxURIPUI.Location = new System.Drawing.Point(488, 35);
            this.picBoxURIPUI.Name = "picBoxURIPUI";
            this.picBoxURIPUI.Size = new System.Drawing.Size(32, 32);
            this.picBoxURIPUI.TabIndex = 31;
            this.picBoxURIPUI.TabStop = false;
            this.picBoxURIPUI.Click += new System.EventHandler(this.picBoxURIPUI_Click);
            // 
            // FormElectrical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.picBoxURIPUI);
            this.Controls.Add(this.picURIPUI);
            this.Controls.Add(this.btnClearOhmLaw);
            this.Controls.Add(this.btnCalcOhmLaw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWattage);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.lblWattage);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.label1);
            this.Name = "FormElectrical";
            this.Text = "Electrical Formulas";
            ((System.ComponentModel.ISupportInitialize)(this.picURIPUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxURIPUI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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