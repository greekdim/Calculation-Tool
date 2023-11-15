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

        //
        // Calculs Débit - Cv or Flow
        //

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Vérifier lequel des RadioButtons est coché
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
                lblUnitName.Text= rBCv.Text ;
            }
        }

        private void cBMediumType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBMedium.Items.Clear();
            // Ajoute les éléments appropriés en fonction de la sélection de la première ComboBox
            switch(cBMediumType.SelectedItem.ToString())
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
}
