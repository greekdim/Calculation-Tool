using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tool___Rev_A.Classes
{
    internal class LeakageCalculator
    {
        public double CalculateLeakage(double valueLeak, string pressureUnit, double pressure, string temperatureUnit, double temperature, int formulaType)
        {
            //const double standardPressure = 1.01325; // Pression standard en bar
            const double kelvinConversion = 273.15; // Conversion de °C à K

            // Conversion de la pression
            double convertedPressure = ConvertPressure(pressureUnit, pressure); //+ standardPressure; // Ajouter 1.013 pour pression absolue

            // Conversion de la température
            double convertedTemperature = ConvertTemperature(temperatureUnit, temperature); // Convertir en Kelvin

            double result = 0;

            // Calcul de la fuite en fonction de la formule sélectionnée
            if (formulaType == 0) // sccm to ccm
            {
                result = (valueLeak * convertedTemperature) / (convertedPressure * kelvinConversion);
            }
            else if (formulaType == 1) // ccm to sccm
            {
                result = (valueLeak * convertedPressure * kelvinConversion) / convertedTemperature;
            }

            return result;
        }
        private double ConvertPressure(string unit, double value)
        {
            // Calculer la pression absolue en fonction de l'unité
            switch (unit)
            {
                case "bar":
                    return (value + 1.01325) / 1.01325; // Convertir la pression relative en absolue, puis en atm
                case "psi":
                    return (value + 14.6959) / 14.6959; // Convertir la pression relative en absolue, puis en atm
                case "mmHg":
                    return (value + 760) / 760; // Convertir la pression relative en absolue, puis en atm
                case "Pa":
                    return (value + 101325) / 101325; // Convertir la pression relative en absolue, puis en atm
                case "kPa":
                    return (value + 101.325) / 101.325; // Convertir la pression relative en absolue, puis en atm
                case "atm":
                    return value + 1; // Si l'unité est déjà en atm, ajouter 1 pour passer de relative à absolue
                default:
                    throw new ArgumentException("Unité de pression non reconnue.");
            }
        }



        private double ConvertTemperature(string unit, double value)
        {
            const double kelvinConversion = 273.15; // Conversion de °C à K

            switch (unit)
            {
                case "°C":
                    return value + kelvinConversion; // Convertir en Kelvin
                case "°F":
                    return (value - 32) * 5 / 9 + kelvinConversion; // Conversion de °F à Kelvin
                case "°K":
                    return value; // Kelvin
                default:
                    throw new ArgumentException("Unité de température non reconnue.");
            }
        }


    }
}
