using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tool___Rev_A.Classes
{
    internal class FlowCalculator
    {
        private String _selectedFluid;
        private String _liquidOrGas;
        private bool _cvCalculation;
        //une DM bool qui définira si on veut calculer Cv(true) ou Flow(false)
        private double _T;
        private double _G;
        private double _P1;
        private double _P2;
        private double _variable; //Cv ou Flow en fonction des radioButton

        public FlowCalculator(String selectedFluid)
        {
            _selectedFluid = selectedFluid;
        }

        public void SetTextG(out double result)
        {
            if (_selectedFluid == "Water")
                result = 1;
            else if (_selectedFluid == "Oil, Mineral")
                result = 0.88;
            else if (_selectedFluid == "Oil, Vegetable")
                result = 0.91;
            else if (_selectedFluid == "Glycerin")
                result = 1.26;
            else if (_selectedFluid == "Alcohol, Ethyl")
                result = 0.798;
            else if (_selectedFluid == "Air")
                result = 1;
            else if (_selectedFluid == "Oxygen")
                result = 1.105;
            else if (_selectedFluid == "Carbon dioxide")
                result = 1.529;
            else
                result = 1.38;
        }
    }
}
