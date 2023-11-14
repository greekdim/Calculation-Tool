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
                    result1 = value / 1.156;
                    result2 = Math.Sqrt(36 * value);
                    return ConversionCv.CvToOthers;
                }
                else if (_selectedConversion == "Kv to Cv and orifice")
                {
                    result1 = 1.156 * value;
                    result2 = Math.Sqrt(36 * result1);
                    return ConversionCv.KvToOthers;
                }
                else
                {
                    result1 = (value * value) / 36;
                    result2 = result1 / 1.156;
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

