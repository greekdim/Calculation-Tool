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

        public ConversionCv SetLabel(out String result)
        {
            if (_selectedConversion == "Cv to Kv and orifice")
            {
                result = "Cv =";
                return ConversionCv.CvToOthers;
            }
            else if (_selectedConversion == "Kv to Cv and orifice")
            {
                result = "Kv =";
                return ConversionCv.KvToOthers;
            }
            else
            {
                result = "Orifice =";
                return ConversionCv.OrificeToOthers;
            }
        }
    }
}
