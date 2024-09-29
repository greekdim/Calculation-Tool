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
    public partial class FormUnits : Form
    {
        UnitsConversion conv;
        private bool TextBox1isUpdating = false;
        private bool TextBox2isUpdating = false;
        public FormUnits()
        {
            InitializeComponent();
            cbTypeUnit.SelectedIndex = 0;
            cBUnit1.SelectedIndex = 0; //premier élement de la combobox séléctionné par défaut
            cBUnit2.SelectedIndex = 1; //deUxième élement de la combobox séléctionné par défaut
        }

        private void cbTypeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitsConversion.SetUnits(cbTypeUnit, cBUnit1 , cBUnit2);
            UpdateTextBoxes(); // Met à jour les TextBox en fonction des nouvelles unités
        }

        private void txtUnit1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (TextBox1isUpdating)
                return;

            try
            {
                double toConvert = Double.Parse(txtUnit1.Text);
                conv = new UnitsConversion(cbTypeUnit.Text, cBUnit1.Text, cBUnit2.Text);
                double result = conv.ConvertValue(toConvert);
                TextBox2isUpdating = true;
                txtUnit2.Text = ((float)result).ToString();
                TextBox2isUpdating = false;
            }
            catch
            {
                errorProvider1.SetError(txtUnit1, "The value must be a number");
            }
        }

        private void txtUnit2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (TextBox2isUpdating)
                return;

            try
            {
                double toConvert = Double.Parse(txtUnit2.Text);
                conv = new UnitsConversion(cbTypeUnit.Text, cBUnit2.Text, cBUnit1.Text);
                double result = conv.ConvertValue(toConvert);
                TextBox1isUpdating = true;
                txtUnit1.Text = ((float)result).ToString();
                TextBox1isUpdating = false;
            }
            catch
            {
                errorProvider1.SetError(txtUnit2, "The value must be a number");
            }
        }

        private void cBUnit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxes(); // Met à jour les TextBox en fonction des nouvelles unités
        }

        private void cBUnit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxes(); // Met à jour les TextBox en fonction des nouvelles unités
        }
        private void UpdateTextBoxes()
        {
            errorProvider1.Clear();
            if (TextBox1isUpdating || TextBox2isUpdating)
                return;

            try
            {
                // Initialiser la conversion
                conv = new UnitsConversion(cbTypeUnit.Text, cBUnit1.Text, cBUnit2.Text);

                // Mettre à jour les TextBox avec les nouvelles unités
                if (!string.IsNullOrWhiteSpace(txtUnit1.Text))
                {
                    double toConvert = Double.Parse(txtUnit1.Text);
                    double result = conv.ConvertValue(toConvert);
                    TextBox2isUpdating = true;
                    txtUnit2.Text = ((float)result).ToString();
                    TextBox2isUpdating = false;
                }
                else if (!string.IsNullOrWhiteSpace(txtUnit2.Text))
                {
                    double toConvert = Double.Parse(txtUnit2.Text);
                    double result = conv.ConvertValue(toConvert);
                    TextBox1isUpdating = true;
                    txtUnit1.Text = ((float)result).ToString();
                    TextBox1isUpdating = false;
                }
            }
            catch
            {
                errorProvider1.SetError(txtUnit1, "The value must be a number");
                errorProvider1.SetError(txtUnit2, "The value must be a number");
            }
        }
    }
}
