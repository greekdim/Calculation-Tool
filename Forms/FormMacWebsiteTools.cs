using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calc_Tool___Rev_A.Forms
{
    public partial class FormMacWebsiteTools : Form
    {
        public FormMacWebsiteTools()
        {
            InitializeComponent();
        }

        private void linkLabelMacWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.macvalves.com/") { UseShellExecute = true });
        }

        private void linkLabelDrawing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.macvalves.com/support/cad/") { UseShellExecute = true });
        }

        private void linkLabelWinsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://mdnwinsite.com/login.php") { UseShellExecute = true });
        }

        private void linkLabelFunnel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.mdnfunnelapp.com/wp-login.php?redirect_to=https%3A%2F%2Fwww.mdnfunnelapp.com") { UseShellExecute = true });
        }

        private void linkLabelBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://macvalves.account.box.com/login") { UseShellExecute = true });
        
        }

        private void linkLabelTeesing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://teesing.com/en/tools/flow-and-cv-calculator#:~:text=This%20is%20our%20valve%20Cv%20calculator.%20It%20allows%20you%20to") { UseShellExecute = true });
        
        }

        private void linkLabeleDrawings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.edrawingsviewer.com/download-edrawings") { UseShellExecute = true });
        }

        private void linkLabelPico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.picotech.com/downloads") { UseShellExecute = true });
        
        }

        private void linkLabelKubotek_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.kubotekkosmos.com/products/keycreator-viewer?111=") { UseShellExecute = true });
        
        }

        private void linkLabelIAMeeting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://unstuckstudy.com/") { UseShellExecute = true });
        
        }
    }
    
}
