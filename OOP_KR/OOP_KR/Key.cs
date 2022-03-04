using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class Key : Elements
    {
        public bool active = true;
        public Key() { }
        public Key(string name) : base(name)
        { }
        public override string ToString()
        {
            string s = $"Имя ключа: {this.Name};\r\nСостояние ключа: ";
            if (active)
            {
                s += "Опущен;";
                return s;
            }
            s += "Поднят;";
            return s;
        }
    }
}