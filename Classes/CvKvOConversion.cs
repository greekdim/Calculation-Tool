using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tool___Rev_A.ClassesCalculs
{
    enum ConversionCv
    {
        CvToOthers,
        KvToOthers,
        OrificeToOthers,
        Fail
    }
    class CvKvOConversion
    {
        private String _selectedConversion;

        public CvKvOConversion(String selectedConversion)
        {
            _selectedConversion = selectedConversion;
        }

        public ConversionCv GiveResult(double value, out double result1, out double result2)
        {
            if (value > 0)
            {
                if (_selectedConversion == "Cv to Kv and orifice")
                {
                    result1 = Math.Round(value / 1.156, 3);
                    result2 = Math.Round(Math.Sqrt(36 * value), 3);
                    return ConversionCv.CvToOthers;
                }
                else if (_selectedConversion == "Kv to Cv and orifice")
                {
                    result1 = Math.Round(1.156 * value, 3);
                    result2 = Math.Round(Math.Sqrt(36 * result1), 3);
                    return ConversionCv.KvToOthers;
                }
                else
                {
                    result1 = Math.Round((value * value) / 36, 3);
                    result2 = Math.Round(result1 / 1.156, 3);
                    return ConversionCv.OrificeToOthers;
                }
            }
            else
            {
                result1 = 0;
                result2 = 0;
                return ConversionCv.Fail;
            }

        }

}

}

