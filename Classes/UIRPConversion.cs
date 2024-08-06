using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tool___Rev_A.Classes
{
    internal class UIRPConversion
    {
        public double? Voltage { get; set; }
        public double? Current { get; set; }
        public double? Resistance { get; set; }
        public double? Power { get; set; }

        public void Calculate()
        {
            if (Voltage.HasValue && Current.HasValue)
            {
                Resistance = Voltage.Value / Current.Value;
                Power = Voltage.Value * Current.Value;
            }
            else if (Voltage.HasValue && Resistance.HasValue)
            {
                Current = Voltage.Value / Resistance.Value;
                Power = Voltage.Value * Current.Value;
            }
            else if (Voltage.HasValue && Power.HasValue)
            {
                Current = Power.Value / Voltage.Value;
                Resistance = Voltage.Value / Current.Value;
            }
            else if (Current.HasValue && Resistance.HasValue)
            {
                Voltage = Current.Value * Resistance.Value;
                Power = Voltage.Value * Current.Value;
            }
            else if (Current.HasValue && Power.HasValue)
            {
                Voltage = Power.Value / Current.Value;
                Resistance = Voltage.Value / Current.Value;
            }
            else if (Resistance.HasValue && Power.HasValue)
            {
                Current = Math.Sqrt(Power.Value / Resistance.Value);
                Voltage = Current.Value * Resistance.Value;
            }
            else
            {
                throw new InvalidOperationException("Exactly 2 fields must be filled to perform calculation.");
            }
        }

    }
}
