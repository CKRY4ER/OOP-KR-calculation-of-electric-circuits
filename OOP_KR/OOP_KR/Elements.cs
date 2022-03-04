using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OOP_KR
{
    [Serializable]
    abstract public class  Elements
    {
        private string name;
        private double voltage=0;
        public double Voltage
        {
            set
            {
                voltage = value;
            }
            get
            {
                return voltage;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Elements()
        {

        }
        public Elements(string name)
        {
            Name = name;
        }
    }
}