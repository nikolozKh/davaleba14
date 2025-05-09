using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba14
{
    public class Temperature 
    {
        public double Celsius { get; set; }

        public Temperature(double celsius)
        {
            Celsius = celsius;
        }

       
        public static explicit operator double(Temperature temp)
        {
            return temp.Celsius;
        }


        public static implicit operator Fahrenheit(Temperature temp)
        {
            return new Fahrenheit(temp.Celsius * 9 / 5 + 32);
        }

        public override string ToString()
        {
            return $"{Celsius} C";
        }
    }

   

}
