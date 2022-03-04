using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class Lamp : Elements
    {

        public bool isOn = false;
        public Lamp() { }
        public Lamp(string name) : base(name) { }
    }
}