namespace Calc_Tool___Rev_A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            label2 = new Label();
            button7 = new Button();
            btnThreads = new Button();
            btnVol = new Button();
            btnDutyCycle = new Button();
            btnUnits = new Button();
            btnLeakage = new Button();
            btnElec = new Button();
            btnFlow = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            pictureMac = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMac).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(btnThreads);
            panelMenu.Controls.Add(btnVol);
            panelMenu.Controls.Add(btnDutyCycle);
            panelMenu.Controls.Add(btnUnits);
            panelMenu.Controls.Add(btnLeakage);
            panelMenu.Controls.Add(btnElec);
            panelMenu.Controls.Add(btnFlow);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(158, 441);
            panelMenu.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Dubai", 7F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 424);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "by Dimitri Soultis";
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Gainsboro;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 312);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Padding = new Padding(4, 0, 0, 0);
            button7.Size = new Size(158, 36);
            button7.TabIndex = 9;
            button7.Text = "  ?";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnThreads
            // 
            btnThreads.Dock = DockStyle.Top;
            btnThreads.FlatAppearance.BorderSize = 0;
            btnThreads.FlatStyle = FlatStyle.Flat;
            btnThreads.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThreads.ForeColor = Color.Gainsboro;
            btnThreads.Image = (Image)resources.GetObject("btnThreads.Image");
            btnThreads.ImageAlign = ContentAlignment.MiddleLeft;
            btnThreads.Location = new Point(0, 276);
            btnThreads.Margin = new Padding(2, 2, 2, 2);
            btnThreads.Name = "btnThreads";
            btnThreads.Padding = new Padding(4, 0, 0, 0);
            btnThreads.Size = new Size(158, 36);
            btnThreads.TabIndex = 8;
            btnThreads.Text = "  Threads";
            btnThreads.TextAlign = ContentAlignment.MiddleLeft;
            btnThreads.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThreads.UseVisualStyleBackColor = true;
            btnThreads.Click += btnThreads_Click;
            // 
            // btnVol
            // 
            btnVol.Dock = DockStyle.Top;
            btnVol.FlatAppearance.BorderSize = 0;
            btnVol.FlatStyle = FlatStyle.Flat;
            btnVol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVol.ForeColor = Color.Gainsboro;
            btnVol.Image = (Image)resources.GetObject("btnVol.Image");
            btnVol.ImageAlign = ContentAlignment.MiddleLeft;
            btnVol.Location = new Point(0, 240);
            btnVol.Margin = new Padding(2, 2, 2, 2);
            btnVol.Name = "btnVol";
            btnVol.Padding = new Padding(4, 0, 0, 0);
            btnVol.Size = new Size(158, 36);
            btnVol.TabIndex = 7;
            btnVol.Text = "  Volume Filling";
            btnVol.TextAlign = ContentAlignment.MiddleLeft;
            btnVol.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVol.UseVisualStyleBackColor = true;
            btnVol.Click += btnVol_Click;
            // 
            // btnDutyCycle
            // 
            btnDutyCycle.Dock = DockStyle.Top;
            btnDutyCycle.FlatAppearance.BorderSize = 0;
            btnDutyCycle.FlatStyle = FlatStyle.Flat;
            btnDutyCycle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDutyCycle.ForeColor = Color.Gainsboro;
            btnDutyCycle.Image = (Image)resources.GetObject("btnDutyCycle.Image");
            btnDutyCycle.ImageAlign = ContentAlignment.MiddleLeft;
            btnDutyCycle.Location = new Point(0, 204);
            btnDutyCycle.Margin = new Padding(2, 2, 2, 2);
            btnDutyCycle.Name = "btnDutyCycle";
            btnDutyCycle.Padding = new Padding(4, 0, 0, 0);
            btnDutyCycle.Size = new Size(158, 36);
            btnDutyCycle.TabIndex = 6;
            btnDutyCycle.Text = "  Duty Cycle";
            btnDutyCycle.TextAlign = ContentAlignment.MiddleLeft;
            btnDutyCycle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDutyCycle.UseVisualStyleBackColor = true;
            btnDutyCycle.Click += btnDutyCycle_Click;
            // 
            // btnUnits
            // 
            btnUnits.Dock = DockStyle.Top;
            btnUnits.FlatAppearance.BorderSize = 0;
            btnUnits.FlatStyle = FlatStyle.Flat;
            btnUnits.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUnits.ForeColor = Color.Gainsboro;
            btnUnits.Image = (Image)resources.GetObject("btnUnits.Image");
            btnUnits.ImageAlign = ContentAlignment.MiddleLeft;
            btnUnits.Location = new Point(0, 168);
            btnUnits.Margin = new Padding(2, 2, 2, 2);
            btnUnits.Name = "btnUnits";
            btnUnits.Padding = new Padding(4, 0, 0, 0);
            btnUnits.Size = new Size(158, 36);
            btnUnits.TabIndex = 5;
            btnUnits.Text = "  Units Conversions";
            btnUnits.TextAlign = ContentAlignment.MiddleLeft;
            btnUnits.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUnits.UseVisualStyleBackColor = true;
            btnUnits.Click += btnUnits_Click;
            // 
            // btnLeakage
            // 
            btnLeakage.Dock = DockStyle.Top;
            btnLeakage.FlatAppearance.BorderSize = 0;
            btnLeakage.FlatStyle = FlatStyle.Flat;
            btnLeakage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeakage.ForeColor = Color.Gainsboro;
            btnLeakage.Image = (Image)resources.GetObject("btnLeakage.Image");
            btnLeakage.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeakage.Location = new Point(0, 132);
            btnLeakage.Margin = new Padding(2, 2, 2, 2);
            btnLeakage.Name = "btnLeakage";
            btnLeakage.Padding = new Padding(4, 0, 0, 0);
            btnLeakage.Size = new Size(158, 36);
            btnLeakage.TabIndex = 4;
            btnLeakage.Text = "  Leakage Formulas";
            btnLeakage.TextAlign = ContentAlignment.MiddleLeft;
            btnLeakage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeakage.UseVisualStyleBackColor = true;
            btnLeakage.Click += btnLeakage_Click;
            // 
            // btnElec
            // 
            btnElec.Dock = DockStyle.Top;
            btnElec.FlatAppearance.BorderSize = 0;
            btnElec.FlatStyle = FlatStyle.Flat;
            btnElec.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnElec.ForeColor = Color.Gainsboro;
            btnElec.Image = (Image)resources.GetObject("btnElec.Image");
            btnElec.ImageAlign = ContentAlignment.MiddleLeft;
            btnElec.Location = new Point(0, 96);
            btnElec.Margin = new Padding(2, 2, 2, 2);
            btnElec.Name = "btnElec";
            btnElec.Padding = new Padding(4, 0, 0, 0);
            btnElec.Size = new Size(158, 36);
            btnElec.TabIndex = 3;
            btnElec.Text = "  Electrical Formulas";
            btnElec.TextAlign = ContentAlignment.MiddleLeft;
            btnElec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnElec.UseVisualStyleBackColor = true;
            btnElec.Click += btnElec_Click;
            // 
            // btnFlow
            // 
            btnFlow.Dock = DockStyle.Top;
            btnFlow.FlatAppearance.BorderSize = 0;
            btnFlow.FlatStyle = FlatStyle.Flat;
            btnFlow.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlow.ForeColor = Color.Gainsboro;
            btnFlow.Image = (Image)resources.GetObject("btnFlow.Image");
            btnFlow.ImageAlign = ContentAlignment.MiddleLeft;
            btnFlow.Location = new Point(0, 60);
            btnFlow.Margin = new Padding(2, 2, 2, 2);
            btnFlow.Name = "btnFlow";
            btnFlow.Padding = new Padding(4, 0, 0, 0);
            btnFlow.Size = new Size(158, 36);
            btnFlow.TabIndex = 2;
            btnFlow.Text = "  Flow - Orifice - Cv";
            btnFlow.TextAlign = ContentAlignment.MiddleLeft;
            btnFlow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFlow.UseVisualStyleBackColor = true;
            btnFlow.Click += btnFlow_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 2, 2, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(158, 60);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Mac Valves Europe";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(158, 0);
            panelTitleBar.Margin = new Padding(2, 2, 2, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(715, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Calibri", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(661, 1);
            btnMaximize.Margin = new Padding(2, 2, 2, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(24, 45);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "o";
            btnMaximize.TextAlign = ContentAlignment.TopCenter;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Calibri", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(633, 2);
            btnMinimize.Margin = new Padding(2, 2, 2, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 43);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "–";
            btnMinimize.TextAlign = ContentAlignment.TopCenter;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(690, 1);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 59);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.crossouttransp;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Margin = new Padding(2, 2, 2, 2);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(78, 60);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(317, 20);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktopPane.Controls.Add(label3);
            panelDesktopPane.Controls.Add(linkLabel1);
            panelDesktopPane.Controls.Add(pictureMac);
            panelDesktopPane.Location = new Point(158, 60);
            panelDesktopPane.Margin = new Padding(2, 2, 2, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(715, 381);
            panelDesktopPane.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(214, 46);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(502, 52);
            label3.TabIndex = 2;
            label3.Text = "This software will allow you to make easy calculation around the Mac Valves technology.\r\nStrictly reserved for MDN - not for customer use.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(214, 289);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(182, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.macvalves.com/";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureMac
            // 
            pictureMac.Image = Properties.Resources.Macvalves2;
            pictureMac.Location = new Point(32, 29);
            pictureMac.Margin = new Padding(2, 2, 2, 2);
            pictureMac.Name = "pictureMac";
            pictureMac.Size = new Size(157, 259);
            pictureMac.TabIndex = 0;
            pictureMac.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 441);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(633, 339);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMac).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnFlow;
        private Button button7;
        private Button btnThreads;
        private Button btnVol;
        private Button btnDutyCycle;
        private Button btnUnits;
        private Button btnLeakage;
        private Button btnElec;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureMac;
        private Button btnCloseChildForm;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnClose;
    }
}