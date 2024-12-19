namespace Calc_Tool___Rev_A.Forms
{
    partial class FormUnits
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
            cbTypeUnit = new ComboBox();
            txtUnit1 = new TextBox();
            txtUnit2 = new TextBox();
            cBUnit1 = new ComboBox();
            cBUnit2 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbTypeUnit
            // 
            cbTypeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeUnit.FormattingEnabled = true;
            cbTypeUnit.Items.AddRange(new object[] { "Length", "Area", "Volume", "Pressure", "Temperature", "Air flow", "Liquid flow" });
            cbTypeUnit.Location = new Point(45, 45);
            cbTypeUnit.Name = "cbTypeUnit";
            cbTypeUnit.Size = new Size(418, 33);
            cbTypeUnit.TabIndex = 17;
            cbTypeUnit.SelectedIndexChanged += cbTypeUnit_SelectedIndexChanged;
            // 
            // txtUnit1
            // 
            txtUnit1.Location = new Point(45, 115);
            txtUnit1.Name = "txtUnit1";
            txtUnit1.Size = new Size(182, 31);
            txtUnit1.TabIndex = 18;
            txtUnit1.TextChanged += txtUnit1_TextChanged;
            // 
            // txtUnit2
            // 
            txtUnit2.Location = new Point(281, 115);
            txtUnit2.Name = "txtUnit2";
            txtUnit2.Size = new Size(182, 31);
            txtUnit2.TabIndex = 19;
            txtUnit2.TextChanged += txtUnit2_TextChanged;
            // 
            // cBUnit1
            // 
            cBUnit1.DropDownStyle = ComboBoxStyle.DropDownList;
            cBUnit1.FormattingEnabled = true;
            cBUnit1.Location = new Point(45, 161);
            cBUnit1.Name = "cBUnit1";
            cBUnit1.Size = new Size(182, 33);
            cBUnit1.TabIndex = 20;
            cBUnit1.SelectedIndexChanged += cBUnit1_SelectedIndexChanged;
            // 
            // cBUnit2
            // 
            cBUnit2.DropDownStyle = ComboBoxStyle.DropDownList;
            cBUnit2.FormattingEnabled = true;
            cBUnit2.Location = new Point(281, 161);
            cBUnit2.Name = "cBUnit2";
            cBUnit2.Size = new Size(182, 33);
            cBUnit2.TabIndex = 21;
            cBUnit2.SelectedIndexChanged += cBUnit2_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormUnits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 579);
            Controls.Add(cBUnit2);
            Controls.Add(cBUnit1);
            Controls.Add(txtUnit2);
            Controls.Add(txtUnit1);
            Controls.Add(cbTypeUnit);
            Name = "FormUnits";
            Text = "Units Conversion";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbTypeUnit;
        private TextBox txtUnit1;
        private TextBox txtUnit2;
        private ComboBox cBUnit1;
        private ComboBox cBUnit2;
        private ErrorProvider errorProvider1;
    }
}