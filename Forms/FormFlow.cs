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
            InitializeComponent();
            lblResult1.Text = "";
        }



       private void btnCalculateOrifice_Click(object sender, EventArgs e)
        {
            
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
                        lblResult1.Text = "Cv = " + result1 + "\n" + "Orifice = " + result2 + "mm";
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


    }
}
