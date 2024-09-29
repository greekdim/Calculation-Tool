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
            this.components = new System.ComponentModel.Container();
            this.cbTypeUnit = new System.Windows.Forms.ComboBox();
            this.txtUnit1 = new System.Windows.Forms.TextBox();
            this.txtUnit2 = new System.Windows.Forms.TextBox();
            this.cBUnit1 = new System.Windows.Forms.ComboBox();
            this.cBUnit2 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeUnit
            // 
            this.cbTypeUnit.FormattingEnabled = true;
            this.cbTypeUnit.Items.AddRange(new object[] {
            "Length",
            "Area",
            "Volume",
            "Pressure",
            "Temperature",
            "Air flow",
            "Liquid flow"});
            this.cbTypeUnit.Location = new System.Drawing.Point(45, 45);
            this.cbTypeUnit.Name = "cbTypeUnit";
            this.cbTypeUnit.Size = new System.Drawing.Size(418, 33);
            this.cbTypeUnit.TabIndex = 17;
            this.cbTypeUnit.SelectedIndexChanged += new System.EventHandler(this.cbTypeUnit_SelectedIndexChanged);
            // 
            // txtUnit1
            // 
            this.txtUnit1.Location = new System.Drawing.Point(45, 115);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Size = new System.Drawing.Size(182, 31);
            this.txtUnit1.TabIndex = 18;
            this.txtUnit1.TextChanged += new System.EventHandler(this.txtUnit1_TextChanged);
            // 
            // txtUnit2
            // 
            this.txtUnit2.Location = new System.Drawing.Point(281, 115);
            this.txtUnit2.Name = "txtUnit2";
            this.txtUnit2.Size = new System.Drawing.Size(182, 31);
            this.txtUnit2.TabIndex = 19;
            this.txtUnit2.TextChanged += new System.EventHandler(this.txtUnit2_TextChanged);
            // 
            // cBUnit1
            // 
            this.cBUnit1.FormattingEnabled = true;
            this.cBUnit1.Location = new System.Drawing.Point(45, 161);
            this.cBUnit1.Name = "cBUnit1";
            this.cBUnit1.Size = new System.Drawing.Size(182, 33);
            this.cBUnit1.TabIndex = 20;
            this.cBUnit1.SelectedIndexChanged += new System.EventHandler(this.cBUnit1_SelectedIndexChanged);
            // 
            // cBUnit2
            // 
            this.cBUnit2.FormattingEnabled = true;
            this.cBUnit2.Location = new System.Drawing.Point(281, 161);
            this.cBUnit2.Name = "cBUnit2";
            this.cBUnit2.Size = new System.Drawing.Size(182, 33);
            this.cBUnit2.TabIndex = 21;
            this.cBUnit2.SelectedIndexChanged += new System.EventHandler(this.cBUnit2_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.cBUnit2);
            this.Controls.Add(this.cBUnit1);
            this.Controls.Add(this.txtUnit2);
            this.Controls.Add(this.txtUnit1);
            this.Controls.Add(this.cbTypeUnit);
            this.Name = "FormUnits";
            this.Text = "Units Conversion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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