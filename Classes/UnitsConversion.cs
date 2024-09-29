using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calc_Tool___Rev_A.Classes
{

    internal class UnitsConversion
    {
        private String _conversionType;
        private String _conversionUnit1;
        private String _conversionUnit2;
        public UnitsConversion(String conversionType, String conversionUnit1, String conversionUnit2)
        {
            _conversionType = conversionType;
            _conversionUnit1 = conversionUnit1;
            _conversionUnit2 = conversionUnit2;
        }

        public static void SetUnits(System.Windows.Forms.ComboBox comboBoxConversion, System.Windows.Forms.ComboBox comboBoxUnite1, System.Windows.Forms.ComboBox comboBoxUnite2)
        {
            switch (comboBoxConversion.SelectedIndex)
            {
                case 0: // Longueur
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "m", "mm", "µm", "inch", "feet" });
                    comboBoxUnite2.Items.AddRange(new string[] { "m", "mm", "µm", "inch", "feet" });
                    break;
                case 1: // Aire
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "m²", "mm²", "inch²", "feet²" });
                    comboBoxUnite2.Items.AddRange(new string[] { "m²", "mm²", "inch²", "feet²" });
                    break;
                case 2: // Volume
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "m³", "mm³", "inch³", "feet³", "ml", "l", "gallon" });
                    comboBoxUnite2.Items.AddRange(new string[] { "m³", "mm³", "inch³", "feet³", "ml", "l", "gallon" });
                    break;
                case 3: // Pression
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "bar", "psi", "mmHg", "Pa", "kPa", "atm" });
                    comboBoxUnite2.Items.AddRange(new string[] { "bar", "psi", "mmHg", "Pa", "kPa", "atm" });
                    break;
                case 4: // Température
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "°C", "°F", "°K" });
                    comboBoxUnite2.Items.AddRange(new string[] { "°C", "°F", "°K" });
                    break;
                case 5: // Débit d'air
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "NL/min", "NL/h", "Nm³/min", "Nm³/h", "SCFM" });
                    comboBoxUnite2.Items.AddRange(new string[] { "NL/min", "NL/h", "Nm³/min", "Nm³/h", "SCFM" });
                    break;
                case 6: // Débit liquide
                    comboBoxUnite1.Items.Clear();
                    comboBoxUnite2.Items.Clear();
                    comboBoxUnite1.Items.AddRange(new string[] { "GPM", "LPM", "m³/h" });
                    comboBoxUnite2.Items.AddRange(new string[] { "GPM", "LPM", "m³/h" });
                    break;
            }
            comboBoxUnite1.SelectedIndex = 0;
            comboBoxUnite2.SelectedIndex = 1;
        }

        public double ConvertValue(double value)
        {
            double result = 0;
            switch (_conversionType)
            {
                case "Length":
                    result = ConvertLength(value);
                    break;
                case "Area":
                    result = ConvertArea(value);
                    break;
                case "Volume":
                    result = ConvertVolume(value);
                    break;
                case "Pressure":
                    result = ConvertPressure(value);
                    break;
                case "Temperature":
                    result = ConvertTemperature(value);
                    break;
                case "Air flow":
                    result = ConvertAirFlow(value);
                    break;
                case "Liquid flow":
                    result = ConvertLiquidFlow(value);
                    break;
            }
            return result;
        }

        private double ConvertLength(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "m", 1.0 },
                { "mm", 0.001 },
                { "µm", 0.000001 },
                { "inch", 0.0254 },
                { "feet", 0.3048 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }

        private double ConvertArea(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "m²", 1.0 },
                { "mm²", 0.000001 },
                { "inch²", 0.00064516 },
                { "feet²", 0.092903 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }

        private double ConvertVolume(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "m³", 1.0 },
                { "mm³", 1e-9 },
                { "inch³", 0.0000163871 },
                { "feet³", 0.0283168 },
                { "ml", 1e-6 },
                { "l", 0.001 },
                { "gallon", 1 / 264.172 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }

        private double ConvertPressure(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "bar", 1.0 },
                { "psi", 0.0689476 },
                { "mmHg", 0.00133322 },
                { "Pa", 0.00001 },
                { "kPa", 0.01 },
                { "atm", 1.01325 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }

        private double ConvertTemperature(double value)
        {
            switch (_conversionUnit1)
            {
                case "°C":
                    switch (_conversionUnit2)
                    {
                        case "°F":
                            return (value * 9 / 5) + 32;
                        case "°K":
                            return value + 273.15;
                    }
                    break;
                case "°F":
                    switch (_conversionUnit2)
                    {
                        case "°C":
                            return (value - 32) * 5 / 9;
                        case "°K":
                            return (value + 459.67) * 5 / 9;
                    }
                    break;
                case "°K":
                    switch (_conversionUnit2)
                    {
                        case "°C":
                            return value - 273.15;
                        case "°F":
                            return (value * 9.0 / 5) - 459.67;
                    }
                    break;
            }
            return value;
        }

        private double ConvertAirFlow(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "NL/min", 1.0 },
                { "NL/h", 1.0 / 60 },
                { "Nm³/min", 1000.0 },
                { "Nm³/h", 1000.0 / 60 },
                { "SCFM", 28.32 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }

        private double ConvertLiquidFlow(double value)
        {
            var conversions = new Dictionary<string, double>()
            {
                { "GPM", 1.0 },
                { "LPM", 1 / 3.78541 },
                { "m³/h", 1 / 0.227124 }
            };
            return value * conversions[_conversionUnit1] / conversions[_conversionUnit2];
        }


    }
}
