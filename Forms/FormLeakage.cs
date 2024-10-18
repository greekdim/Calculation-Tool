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

            ////////////    Tool 2 of the form:        ////////////////
            // Sélectionner par défaut le premier radiobutton
            rbLeakCalc.Checked = true;

        }

        private void InitializeLeakageUnits()
        {
            // Peupler cbPressureUnit et cbP1 avec les unités de pression
            string[] pressureUnits = new string[] { "bar", "psi", "mmHg", "Pa", "kPa", "atm" };
            cbPressureUnit.Items.Clear();
            cbP1.Items.Clear();
            cbPressureUnit.Items.AddRange(pressureUnits);
            cbP1.Items.AddRange(pressureUnits);
            cbPressureUnit.SelectedIndex = 0; // Optionnel, sélectionne le premier élément
            cbP1.SelectedIndex = 0;

            // Peupler cvTempUnit avec les unités de température
            cvTempUnit.Items.Clear();
            cvTempUnit.Items.AddRange(new string[] { "°C", "°F", "°K" });
            cvTempUnit.SelectedIndex = 0; // Optionnel, sélectionne le premier élément

            // Peupler cbVolume avec les unités de volume
            cbVolume.Items.Clear();
            cbVolume.Items.AddRange(new string[] { "L", "cm³" });
            cbVolume.SelectedIndex = 0;

            // Peupler cbDeltaTime avec les unités de temps
            cbDeltaTime.Items.Clear();
            cbDeltaTime.Items.AddRange(new string[] { "min", "sec" });
            cbDeltaTime.SelectedIndex = 0;
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
                    MessageBox.Show("Enter a positive or zero value for the leak rate");
                    return;
                }

                if (pressure < 0)
                {
                    MessageBox.Show("Enter a positive or zero value for the pressure");
                    return;
                }
                // Désactiver les contrôles
                //DisableControls();
                // Désactiver les contrôles de l'outil 1
                DisableControls(true);

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
                MessageBox.Show("Please enter valid values.");
            }
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
            //EnableControls();
            // Réactiver les contrôles de l'outil 1
            EnableControls(true);

            // Réinitialiser le résultat
            lblResultLeak1.Text = "Result:";
        }
        private void DisableControls(bool isTool1)
        {
            if (isTool1)
            {
                // Désactiver les contrôles de l'outil 1
                txtValueLeak.Enabled = false;
                lblPressure.Enabled = false;
                txtTemperature.Enabled = false;
                cbPressureUnit.Enabled = false;
                cvTempUnit.Enabled = false;
                cbLeakFormulaSelection.Enabled = false;
            }
            else
            {
                // Désactiver les contrôles de l'outil 2
                txtP1.Enabled = false;
                txtVolume.Enabled = false;
                txtDeltaTime.Enabled = false;
                cbP1.Enabled = false;
                cbVolume.Enabled = false;
                cbDeltaTime.Enabled = false;
                txtP1orLeak.Enabled = false;
                cbP1orLeak.Enabled = false;
            }
        }

        private void EnableControls(bool isTool1)
        {
            if (isTool1)
            {
                // Réactiver les contrôles de l'outil 1
                txtValueLeak.Enabled = true;
                lblPressure.Enabled = true; // Assurez-vous que lblPressure est modifiable si besoin
                txtTemperature.Enabled = true;
                cbPressureUnit.Enabled = true;
                cvTempUnit.Enabled = true;
                cbLeakFormulaSelection.Enabled = true;
            }
            else
            {
                // Réactiver les contrôles de l'outil 2
                txtP1.Enabled = true;
                txtVolume.Enabled = true;
                txtDeltaTime.Enabled = true;
                cbP1.Enabled = true;
                cbVolume.Enabled = true;
                cbDeltaTime.Enabled = true;
                txtP1orLeak.Enabled = true;
                cbP1orLeak.Enabled = true;
            }
        }



        /// /////////////////////////////////////////////////////////////////////////

        //////////////////////////// Tool 2 /////////////////////////////////////////
        private void rbLeakCalc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeakCalc.Checked)
            {
                // Mettre à jour l'interface utilisateur pour l'option "Leak Calculation"
                lblP1orLeak.Text = "Final Pressure";
                lblResult1Tool2.Text = "Leakrate = ";
                lblResult2Tool2.Text = string.Empty; // Effacer le second label
                PopulateCbP1orLeak(true); // Afficher les unités de cbP1
            }
        }

        private void rbDeltaPCalc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeltaPCalc.Checked)
            {
                // Mettre à jour l'interface utilisateur pour l'option "Delta Pressure Calculation"
                lblP1orLeak.Text = "Valve Leakrate";
                lblResult1Tool2.Text = "Final Pressure = ";
                lblResult2Tool2.Text = "Pressure drop over time = ";
                PopulateCbP1orLeak(false); // Afficher uniquement "sccm"
            }
        }
        private void PopulateCbP1orLeak(bool isLeakCalc)
        {
            cbP1orLeak.Items.Clear();

            if (isLeakCalc)
            {
                // Afficher les mêmes unités que dans cbP1
                foreach (var item in cbP1.Items)
                {
                    cbP1orLeak.Items.Add(item);
                }
            }
            else
            {
                // Afficher uniquement "sccm"
                cbP1orLeak.Items.Add("sccm");
            }
            cbP1orLeak.SelectedIndex = 0; // Optionnel, sélectionne le premier élément
        }

        private void btnCalcLeak2_Click(object sender, EventArgs e)
        {
            try
            {

                // Récupération des valeurs des textboxes et comboboxes
                double p1 = Convert.ToDouble(txtP1.Text.Replace('.', ','));
                double p1OrLeak = Convert.ToDouble(txtP1orLeak.Text.Replace('.', ','));
                double volume = Convert.ToDouble(txtVolume.Text.Replace('.', ','));
                double deltaTime = Convert.ToDouble(txtDeltaTime.Text.Replace('.', ','));

                // Validation pour s'assurer que les valeurs sont positives ou nulles
                if (p1 < 0 || p1OrLeak < 0 || volume < 0 || deltaTime < 0)
                {
                    MessageBox.Show("Please enter positive values.");
                    return;
                }
                // Désactiver les contrôles de l'outil 2
                DisableControls(false);
                // Unité pour p1
                string pressureUnitP1 = cbP1.SelectedItem.ToString();

                // Unité pour p1OrLeak
                string pressureUnitP1OrLeak = cbP1orLeak.SelectedItem.ToString();

                string volumeUnit = cbVolume.SelectedItem.ToString();
                string deltaTimeUnit = cbDeltaTime.SelectedItem.ToString();

                // Utilisation de la classe LeakageCalculator
                LeakageCalculator calculator = new LeakageCalculator();

                // Si le premier radiobutton est coché (Leak Calculation)
                if (rbLeakCalc.Checked)
                {
                    // Appel de la méthode pour calculer la fuite
                    double leakRate = calculator.CalculateLeakRateORPressureDrop(
                        p1, p1OrLeak, volume, deltaTime, pressureUnitP1, pressureUnitP1OrLeak, volumeUnit, deltaTimeUnit
                            );

                    // Affichage du résultat dans lblResult1Tool2
                    lblResult1Tool2.Text = $"Leakage = {leakRate:F2} sccm"; // Format avec 2 décimales
                    lblResult2Tool2.Text = string.Empty; // Vider le second label
                }
                else if (rbDeltaPCalc.Checked)
                {
                    // Appel de la méthode pour calculer la chute de pression
                    double finalPressureRelative = calculator.CalculatePressureDrop(
                        p1, p1OrLeak, volume, deltaTime, pressureUnitP1, volumeUnit, deltaTimeUnit // Ajout de deltaTimeUnit ici
                    );

                    // Affichage du résultat dans lblResult1Tool2
                    lblResult1Tool2.Text = $"Final Pressure = {finalPressureRelative:F2} {pressureUnitP1}"; // Affiche le résultat avec l'unité
                                                                                                            // Calcul de la différence pour lblResult2Tool2
                    double pressureDifference = p1 - finalPressureRelative; // Calcul de p1 - finalPressure
                    lblResult2Tool2.Text = $"Pressure Difference = {pressureDifference:F2} {pressureUnitP1}"; // Affichage de la différence
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des contrôles de l'outil 2
            txtP1.Text = string.Empty;
            txtVolume.Text = string.Empty;
            txtDeltaTime.Text = string.Empty;
            txtP1orLeak.Text = string.Empty;

            // Réinitialiser les ComboBox
            cbP1.SelectedIndex = 0; // Assurez-vous que cbP1 a des éléments
            cbVolume.SelectedIndex = 0; // Assurez-vous que cbVolume a des éléments
            cbDeltaTime.SelectedIndex = 0; // Assurez-vous que cbDeltaTime a des éléments
            cbP1orLeak.SelectedIndex = 0; // Cela dépend de l'état du radiobutton

            // Réactiver les contrôles de l'outil 2
            EnableControls(false);

            // Réinitialiser les résultats
            lblResult1Tool2.Text = string.Empty;
            lblResult2Tool2.Text = string.Empty;


            // Si le premier radiobutton est sélectionné, vous pouvez également réinitialiser le texte du label
            // Réinitialiser les résultats en fonction du radiobutton sélectionné
            if (rbLeakCalc.Checked)
            {
                lblP1orLeak.Text = "Final Pressure";
                lblResult1Tool2.Text = "Leakrate = "; // Réinitialisation pour le premier radiobutton
                lblResult2Tool2.Text = string.Empty; // Effacer le second label pour cette option
            }
            else if (rbDeltaPCalc.Checked)
            {
                lblP1orLeak.Text = "Valve Leakrate";
                lblResult1Tool2.Text = "Final Pressure = "; // Réinitialisation pour le deuxième radiobutton
                lblResult2Tool2.Text = "Pressure drop over time = "; // Réinitialisation du deuxième label
            }
        }
        
    }
}
