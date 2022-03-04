using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class Resister : Elements
    {

        private double resistance=0;
        private double conductivity=0;
        public double Resistance
        {
            set
            {
                resistance = value;
                conductivity = 1 / resistance;
            }
            get
            {
                return resistance;
            }
        }
        public double Conductibvity
        {
            get => conductivity;
        }
        public Resister() { }
        public Resister(string name, double res) : base(name)
        {
           Resistance = res;
           conductivity = 1 / resistance;
        }
        public override string ToString()
        {
            string s = $"Имя резистора: {this.Name};\r\nСопротивление резистора {this.resistance} Ом;";
            return s;
        }
    }
}