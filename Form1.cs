using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calc_Tool___Rev_A
{
    public partial class Form1 : Form
    {
        // Fields
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();

            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Les lignes suivants permettent de pouvoir deplacer la fenêtre quand on est sur la bande du haut. Risque de problème de compatibilité
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor() // We select a random color from the list of colors for the theme (it is optional, we could use only one color)
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            } // If color has already been selected, we select again to choose a different one
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        /* On surligne le bouton qui a été cliqué  (Active Form):
        1. On séléctionne une couleur random pour le theme (optionnel, on pourrait uiliser la mm)
        2. On change le background en couleur du bouton cliqué
        3. On change la couleur du bouton
        4. On change la taille du bouton
        */
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    /*   ThemeColor.PrimaryColor = color;
                      ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);*/
                    btnCloseChildForm.Visible = true;
                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        // Creation of metgod to open the forms in the container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text; // we show the title (text) of the child form in the title bar (lbltitle)
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender);
            OpenChildForm(new Forms.FormFlow(), sender);
        }

        private void btnElec_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender);
            OpenChildForm(new Forms.FormElectrical(), sender);
        }

        private void btnLeakage_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender);
            OpenChildForm(new Forms.FormLeakage(), sender);
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender);
            OpenChildForm(new Forms.FormUnits(), sender);
        }

        private void btnDutyCycle_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormDutyCycle(), sender);
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormVolumeFilling(), sender);
        }

        private void btnThreads_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormThreads(), sender);
        }
        private void btnWebsiteTools_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMacWebsiteTools(), sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.macvalves.com/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }


    }



}