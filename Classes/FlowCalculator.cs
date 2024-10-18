using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tool___Rev_A.Classes
{
    enum CalculationTypeFlow
    {
        Cv,
        Flowliquid,
        FlowGas
    }

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

        public FlowCalculator(bool cvChecked, String liquidOrGas, double Temperature, double inP, double outP, double Gravity, double val)
        {
            _cvCalculation = cvChecked;
            _liquidOrGas = liquidOrGas;
            _T = Temperature;
            P1 = inP;
            P2 = outP;
            _G = Gravity;
            Variable = val;
        }
        public double P1
        {
            set
            {
                if (value <= 0)
                    throw new Exception();
                _P1 = value;
            }
        }
        public double P2
        {
            set
            {
                if (value <= 0)
                    throw new Exception();
                _P2 = value;
            }
        }

        public double Variable
        {
            set
            {
                if (value <= 0)
                    throw new Exception();
                _variable = value;
            }
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

        public CalculationTypeFlow GiveResult(out double result)
        {
            double dP = _P1 - _P2;
            if (dP <= 0)
                throw new Exception();

            double Tk = _T + 273;

            if (_cvCalculation == true) //on calcule Cv
            {
                if (_liquidOrGas == "Liquid")
                {
                    result = (_variable / 14.42) / Math.Sqrt(dP / _G);
                    return CalculationTypeFlow.Cv;
                }
                else
                {
                    if (_P1 < 2 * _P2)
                        result = (_variable / (6950 * _P1)) / ((1 - ((2 * dP) / (3 * _P1))) * Math.Sqrt(dP / (_P1 * _G * Tk)));
                    else
                        result = (_variable / (0.471 * 6950 * _P1)) / Math.Sqrt(1 / (_G * Tk));
                    return CalculationTypeFlow.Cv;
                }
            }
            else //on calcule Flow
            {
                if (_liquidOrGas == "Liquid")
                {
                    result = 14.42 * _variable * Math.Sqrt(dP / _G);
                    return CalculationTypeFlow.Flowliquid;
                }
                else
                {
                    if (_P1 < 2 * _P2)
                        result = 6950 * _variable * _P1 * (1 - ((2 * dP) / (3 * _P1))) * Math.Sqrt(dP / (_P1 * _G * Tk));
                    else
                        result = 0.471 * 6950 * _variable * _P1 * Math.Sqrt(1 / (_G * Tk));
                    return CalculationTypeFlow.FlowGas;
                }
            }
        }

    }
}
