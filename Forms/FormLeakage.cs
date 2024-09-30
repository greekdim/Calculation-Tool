using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Tool___Rev_A.Forms
{
    public partial class FormLeakage : Form
    {
        public FormLeakage()
        {
            InitializeComponent();
            // Abonne le gestionnaire d'événements
            //cbLeakFormulaSelection.SelectedIndexChanged += CbLeakFormulaSelection_SelectedIndexChanged;
        }

        private void CbLeakFormulaSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLeakFormulaSelection.SelectedIndex)
            {
                case 0: // "sccm to ccm"
                    lblValueLeak.Text = "sccm";
                    break;
                case 1: // "ccm to sccm"
                    lblValueLeak.Text = "ccm";
                    break;
                default:
                    lblValueLeak.Text = string.Empty; // Optionnel, pour le cas où rien n'est sélectionné
                    break;
            }
        }


    }
}
