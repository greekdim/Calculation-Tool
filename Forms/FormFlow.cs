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
            comboBoxCvKvOr.SelectedIndex = 0;
        }

        private void comboBoxCvKvOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text;
            conv=new CvKvOConversion(comboBoxCvKvOr.Text);

            ConversionCv typeConv=conv.SetLabel(out text);
            switch (typeConv)
            {
                case ConversionCv.CvToOthers:
                    lblResult.Text = text;
                    break;
                case ConversionCv.KvToOthers:
                    lblResult.Text = text;
                    break ;
                case ConversionCv.OrificeToOthers:
                    lblResult.Text = text;
                    break;
            }
        }

        private void btnCalculateOrifice_Click(object sender, EventArgs e)
        {

        }


    }
}
