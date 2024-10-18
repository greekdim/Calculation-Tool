using Calc_Tool___Rev_A.Classes;
using Calc_Tool___Rev_A.ClassesCalculs;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calc_Tool___Rev_A.Forms
{
    public partial class FormFlow : Form
    {
        CvKvOConversion conv;
        public FormFlow()
        {
            // Calculs Cv Kv Orifice
            InitializeComponent();
            lblResult1.Text = "";
            comboBoxCvKvOr.SelectedIndex = 1;

            // Calculs Débit - Cv or Flow
            // Ajouter un événement CheckedChanged pour les RadioButtons
            rBCv.CheckedChanged += RadioButton_CheckedChanged;
            rBFlow.CheckedChanged += RadioButton_CheckedChanged;
            lblUnitFlow.Text = "";
            cBMediumType.SelectedIndexChanged += cBMediumType_SelectedIndexChanged;
        }


        //
        // Calculs Cv Kv Orifice
        //


        private void btnCalculateOrifice_Click(object sender, EventArgs e)
        {
            // Vérifier si une option est sélectionnée dans la ComboBox
            if (comboBoxCvKvOr.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conversion type", "Selection error");
                return; // Sortir de la méthode si aucune sélection n'est faite
            }
            conv = new CvKvOConversion(comboBoxCvKvOr.Text);
            try
            {
                // Remplacer les points par des virgules si présents dans la chaîne
                string userInput = txtValueToCalc.Text.Replace('.', ',');
                double val = Double.Parse(userInput);
                ConversionCv typeConv = conv.GiveResult(val, out double result1, out double result2);
                switch (typeConv)
                {
                    case ConversionCv.CvToOthers:
                        lblResult1.Text= "Kv = " + result1 + "\n" + "Orifice = " + result2 + " mm";
                        break;
                    case ConversionCv.KvToOthers:
                        lblResult1.Text = "Cv = " + result1 + "\n" + "Orifice = " + result2 + " mm";
                        break;
                    case ConversionCv.OrificeToOthers:
                        lblResult1.Text = "Cv = " + result1 + "\n" + "Kv = " + result2;
                        break;
                    case ConversionCv.Fail:
                        //throw new Exception();   
                        throw new ApplicationException("Please enter a positive value");
                }

                // Griser la ComboBox et le TextBox après le calcul
                comboBoxCvKvOr.Enabled = false;
                txtValueToCalc.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value", "Format error");
            }
            catch (Exception ex)
            {
                // Gérer l'exception générée dans le cas ConversionCv.Fail
                MessageBox.Show("An error has occured: " + ex.Message, "Execution error");
            }

        }
        private void comboBoxCvKvOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des contrôles
            lblResult1.Text = string.Empty;
            txtValueToCalc.Text = string.Empty;
        }
        private void btnClearCvKvO_Click(object sender, EventArgs e)
        {
            // Dégriser la ComboBox et le TextBox
            comboBoxCvKvOr.Enabled = true;
            txtValueToCalc.Enabled = true;

            // Réinitialiser la ComboBox à l'index 1
            comboBoxCvKvOr.SelectedIndex = 1;

            // Vider les champs de texte
            txtValueToCalc.Text = string.Empty;
            lblResult1.Text = string.Empty;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Detailed help message explaining the difference between Cv and Kv and their connection to the orifice
            string message = "Cv (Imperial System):\n" +
                             "- Flow factor measuring GPM through an orifice with a 1 psi pressure drop at 60°F.\n" +
                             "- Commonly used in the U.S. and represents the valve's capacity.\n\n" +
                             "Kv (Metric System):\n" +
                             "- Flow coefficient measuring m³/h through an orifice with a 1 bar pressure drop at 20°C.\n" +
                             "- Used in the metric system (SI units), representing valve efficiency.\n\n" +
                             "Relation to Orifice Size:\n" +
                             "- Both Cv and Kv values are critical in determining the appropriate orifice size.\n" +
                             "- Orifice size directly impacts the flow rate, influencing the valve selection.\n" +
                             "- Larger orifices allow greater flow rates, affecting both Cv and Kv calculations.";

            // Display the message in a pop-up dialog box
            MessageBox.Show(message, "Flow Coefficients - Help", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        //
        // Calculs Débit - Cv or Flow
        //

        private void SetFlowResultLabel()
        {
            if (rBCv.Checked)
            {
                // Afficher le texte de rBCv dans le label
                lblFlowResult.Text = rBCv.Text + " =";
                lblUnitFlow.Text = "";
                lblUnitName.Text = rBFlow.Text;
            }
            else if (rBFlow.Checked)
            {
                // Afficher le texte de rBFlow dans le label
                lblFlowResult.Text = rBFlow.Text + " =";
                lblUnitFlow.Text = "";
                lblUnitName.Text = rBCv.Text;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearFormControls(this.Controls);
            // Vérifier lequel des RadioButtons est coché
            SetFlowResultLabel();

            /*if (rBCv.Checked)
            {
                // Afficher le texte de rBCv dans le label
                lblFlowResult.Text = rBCv.Text + " =";
                lblUnitFlow.Text = "";
                lblUnitName.Text = rBFlow.Text;
            }
            else if (rBFlow.Checked)
            {
                // Afficher le texte de rBFlow dans le label
                lblFlowResult.Text = rBFlow.Text + " =";
                lblUnitFlow.Text = "";
                lblUnitName.Text= rBCv.Text ;
            }*/
        }

        // Fonction pour clear. 
        private void ClearFormControls(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    ClearFormControls(control.Controls);
                }
                
            }
        }

        private void cBMediumType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBMedium.Items.Clear();
            cBMedium.Text = "";
            tBoxGravity.Text = "";
            // Ajoute les éléments appropriés en fonction de la sélection de la première ComboBox
            // Le if sert a vérifier que l'item séléctionnée est != de null. Si on l'utilise pas, on ne peut pas clear.
            if (cBMediumType.SelectedItem != null)
            {
                switch (cBMediumType.SelectedItem.ToString())
                {
                    case "Liquid":
                        cBMedium.Items.AddRange(new string[] { "Water", "Oil, Mineral", "Oil, Vegetable", "Glycerin", "Alcohol, Ethyl" });
                        if (rBCv.Checked)
                            lblUnitFlow.Text = "L/min";
                        break;
                    case "Gas":
                        cBMedium.Items.AddRange(new string[] { "Air", "Oxygen", "Carbon dioxide", "Argon" });
                        if (rBCv.Checked)
                            lblUnitFlow.Text = "NL/min";
                        break;
                }
            }


        }
        FlowCalculator calc;

        private void cBMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc = new FlowCalculator(cBMedium.Text);
            calc.SetTextG(out double G);
            tBoxGravity.Text = G.ToString();
        }





        private void btnCalcFlow_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();


            try
            {
                double T;
                if (cBTempUnit.SelectedItem.ToString() == "°C")
                {
                    T = ParseDouble(txtTemp.Text);
                }
                else // "°F" selected
                {
                    double tempF = ParseDouble(txtTemp.Text);
                    T = (tempF - 32) * 5 / 9; // Conversion de °F à °C
                }
                
                double P1 = ParseDouble(txtPin.Text);
                double P2 = ParseDouble(txtPout.Text);
                double G = Double.Parse(tBoxGravity.Text);
                double val = ParseDouble(txtFlowInitial.Text);

                // Convertir les pressions en bars si PSIA est sélectionné
                if (cBInPressUnit.Text == "PSIA")
                {
                    P1 /= 14.503768; // Convertir PSIA en bar
                }
                if (cBOutPressUnit.Text == "PSIA")
                {
                    P2 /= 14.503768; // Convertir PSIA en bar
                }

                calc = new FlowCalculator(rBCv.Checked, cBMediumType.Text, T, P1, P2, G, val);

                CalculationTypeFlow calcType = calc.GiveResult(out double result);
                switch (calcType)
                {
                    case CalculationTypeFlow.Cv:
                        lblFlowResult.Text = "Cv = " + ((float)result).ToString("F3");
                        break;
                    case CalculationTypeFlow.Flowliquid:
                        lblFlowResult.Text = "Flow = " + ((float)result).ToString("F3") + " L/min";
                        break;
                    case CalculationTypeFlow.FlowGas:
                        lblFlowResult.Text = "Flow = " + ((float)result).ToString("F3") + " NL/min";
                        break;
                }
            }
            catch
            {
                errorProvider1.SetError(btnCalcFlow, "Check the variables");
            }
        }



        private double ParseDouble(string input)
        {
            // Remplacer les virgules par des points avant de convertir en double
            string cleanedInput = input.Replace('.', ',');
            return Double.Parse(cleanedInput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormControls(this.Controls);
            SetFlowResultLabel();
        }

        private void picBoxCalcType_Click(object sender, EventArgs e)
        {
            // Display a message box with information on how to use the calculation options.
            MessageBox.Show("Select the appropriate option to calculate a valve's Cv using a flow rate in L/min for liquids or NL/min for gases, or to determine the flow rate using the Cv.",
                            "Calculation Type Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
