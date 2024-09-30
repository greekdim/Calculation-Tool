using Calc_Tool___Rev_A.Classes;
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

            // Sélectionne par défaut le premier item de cbLeakFormulaSelection
            cbLeakFormulaSelection.SelectedIndex = 0;
            InitializeLeakageUnits(); // Appel de la méthode pour peupler les unités
        }

        private void InitializeLeakageUnits()
        {
            // Peupler cbPressureUnit avec les unités de pression
            cbPressureUnit.Items.Clear();
            cbPressureUnit.Items.AddRange(new string[] { "bar", "psi", "mmHg", "Pa", "kPa", "atm" });
            cbPressureUnit.SelectedIndex = 0; // Optionnel, sélectionne le premier élément

            // Peupler cvTempUnit avec les unités de température
            cvTempUnit.Items.Clear();
            cvTempUnit.Items.AddRange(new string[] { "°C", "°F", "°K" });
            cvTempUnit.SelectedIndex = 0; // Optionnel, sélectionne le premier élément
        }

        private void CbLeakFormulaSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLeakFormulaSelection.SelectedIndex)
            {
                case 0: // "sccm to ccm"
                    lblValueLeak.Text = "sccm"; // Afficher "sccm" pour le premier item
                    break;
                case 1: // "ccm to sccm"
                    lblValueLeak.Text = "ccm"; // Afficher "ccm" pour le deuxième item
                    break;
                default:
                    lblValueLeak.Text = string.Empty; // Optionnel, pour le cas où rien n'est sélectionné
                    break;
            }
        }
        private void btnCalcLeak1_Click(object sender, EventArgs e)
        {
            try
            {
                double valueLeak = Convert.ToDouble(txtValueLeak.Text.Replace('.', ','));
                double pressure = Convert.ToDouble(lblPressure.Text.Replace('.', ','));
                double temperature = Convert.ToDouble(txtTemperature.Text.Replace('.', ','));

                if (valueLeak < 0)
                {
                    MessageBox.Show("Enter a positive or null value for the leak rate");
                    return;
                }

                if (pressure < 0)
                {
                    MessageBox.Show("Enter a positive or null value for the pressure");
                    return;
                }
                // Désactiver les contrôles
                DisableControls();

                LeakageCalculator calculator = new LeakageCalculator();
                double result = calculator.CalculateLeakage(
                    valueLeak,
                    cbPressureUnit.SelectedItem.ToString(), // Unité de pression
                    pressure, // Pression
                    cvTempUnit.SelectedItem.ToString(), // Unité de température
                    temperature, // Température
                    cbLeakFormulaSelection.SelectedIndex // Type de formule
                );

                // Détermination de l'unité en fonction de lblValueLeak
                string unit = lblValueLeak.Text == "sccm" ? "ccm" : "sccm";

                // Affichage du résultat dans lblResultLeak1
                lblResultLeak1.Text = $"{txtValueLeak.Text} {lblValueLeak.Text} = {result:F2} {unit}"; // Affiche avec 2 décimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides.");
            }
        }

        // Méthode pour désactiver les contrôles
        private void DisableControls()
        {
            txtValueLeak.Enabled = false;
            lblPressure.Enabled = false;
            txtTemperature.Enabled = false;
            cbPressureUnit.Enabled = false;
            cvTempUnit.Enabled = false;
            cbLeakFormulaSelection.Enabled = false;
        }

        private void btnClearLeak1_Click(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des contrôles
            txtValueLeak.Text = string.Empty;
            lblPressure.Text = string.Empty; // Assurez-vous que lblPressure est modifiable si besoin
            txtTemperature.Text = string.Empty;

            // Réinitialiser les ComboBox
            cbPressureUnit.SelectedIndex = 0;
            cvTempUnit.SelectedIndex = 0;
            cbLeakFormulaSelection.SelectedIndex = 0;

            // Réactiver les contrôles
            EnableControls();

            // Réinitialiser le résultat
            lblResultLeak1.Text = string.Empty;
        }

        // Méthode pour activer les contrôles
        private void EnableControls()
        {
            txtValueLeak.Enabled = true;
            lblPressure.Enabled = true; // Assurez-vous que lblPressure est modifiable si besoin
            txtTemperature.Enabled = true;
            cbPressureUnit.Enabled = true;
            cvTempUnit.Enabled = true;
            cbLeakFormulaSelection.Enabled = true;
        }
    }
}
