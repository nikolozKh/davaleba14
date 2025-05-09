using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba14
{
    public class Fahrenheit
    {
        public double FValue { get; set; }

        public Fahrenheit(double fValue)
        {
            FValue = fValue;
        }

        public override string ToString()
        {
            return $"{FValue} F";
        }
    }
}
