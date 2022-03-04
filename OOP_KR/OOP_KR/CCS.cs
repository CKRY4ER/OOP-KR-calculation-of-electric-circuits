using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class CCS : Elements, IDirection
    {
        private Node incumingNode=null;
        private Node outcumingNode=null;
        public Node IncumingNode
        {
            get => incumingNode;
            set => incumingNode = value;
        }
        public Node OutcummingNode
        {
            get => outcumingNode;
            set => outcumingNode = value;
        }
        public CCS(string name, double voltage):base(name)
        {
            Voltage = voltage;
        }
        public CCS() { }
        public override string ToString()
        {
            string s = $"Имя ЭДС источника: {this.Name};\r\nНапряжение ЭДС источника: {this.Voltage};\r\nВходной узел: {this.incumingNode.Name};\r\nВыходной узел: {this.OutcummingNode.Name};";
            return s;
        }
    }
}