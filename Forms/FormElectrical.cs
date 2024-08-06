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
    public partial class FormElectrical : Form
    {
        public FormElectrical()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void InitializeTextBoxEvents()
        {
            txtVoltage.TextChanged += TextBox_TextChanged;
            txtCurrent.TextChanged += TextBox_TextChanged;
            txtR.TextChanged += TextBox_TextChanged;
            txtWattage.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxStates();
        }

        private void UpdateTextBoxStates()
        {
            int filledCount = 0;
            filledCount += string.IsNullOrWhiteSpace(txtVoltage.Text) ? 0 : 1;
            filledCount += string.IsNullOrWhiteSpace(txtCurrent.Text) ? 0 : 1;
            filledCount += string.IsNullOrWhiteSpace(txtR.Text) ? 0 : 1;
            filledCount += string.IsNullOrWhiteSpace(txtWattage.Text) ? 0 : 1;

            bool enableTextBoxes = filledCount < 2;

            txtVoltage.Enabled = enableTextBoxes || !string.IsNullOrWhiteSpace(txtVoltage.Text);
            txtCurrent.Enabled = enableTextBoxes || !string.IsNullOrWhiteSpace(txtCurrent.Text);
            txtR.Enabled = enableTextBoxes || !string.IsNullOrWhiteSpace(txtR.Text);
            txtWattage.Enabled = enableTextBoxes || !string.IsNullOrWhiteSpace(txtWattage.Text);

            btnCalcOhmLaw.Enabled = filledCount == 2;
        }

        private void btnCalcOhmLaw_Click(object sender, EventArgs e)
        {
            try
            {
                var conversion = new UIRPConversion
                {
                    Voltage = ParseDouble(txtVoltage.Text),
                    Current = ParseDouble(txtCurrent.Text),
                    Resistance = ParseDouble(txtR.Text),
                    Power = ParseDouble(txtWattage.Text)
                };

                conversion.Calculate();

                // Affichage des résultats dans les textboxes
                txtVoltage.Text = conversion.Voltage?.ToString("F2");
                txtCurrent.Text = conversion.Current?.ToString("F2");
                txtR.Text = conversion.Resistance?.ToString("F2");
                txtWattage.Text = conversion.Power?.ToString("F2");

                // Désactiver les textboxes qui ne sont pas utilisées
                txtVoltage.Enabled = !conversion.Voltage.HasValue;
                txtCurrent.Enabled = !conversion.Current.HasValue;
                txtR.Enabled = !conversion.Resistance.HasValue;
                txtWattage.Enabled = !conversion.Power.HasValue;

                // Mettre à jour l'état des textboxes après le calcul
                //UpdateTextBoxStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearOhmLaw_Click(object sender, EventArgs e)
        {
            txtVoltage.Clear();
            txtCurrent.Clear();
            txtR.Clear();
            txtWattage.Clear();
            UpdateTextBoxStates();
        }

        private double? ParseDouble(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            // Remplacer la virgule par le point pour assurer une conversion correcte
            text = text.Replace(',', '.');

            if (double.TryParse(text, out double result))
            {
                return result;
            }
            return null;
        }


    }
}
