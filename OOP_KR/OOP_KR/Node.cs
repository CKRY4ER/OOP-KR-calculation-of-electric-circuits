using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class Node
    {
        private string name="";
        private double conductivityNode=0;
        private double potencial=0;
        private double sumEg = 0;
        public double ConductivityNode { get => conductivityNode; set => conductivityNode = value; }
        public double Potencial { get => potencial; set => potencial = value; }
        public string Name { get => name; set => name = value; }
        public double SumeEg { get => sumEg; set => sumEg = value; }
        public void CalculateEg(ElectricalСircuit elcir)
        {
            foreach(Branche br in elcir.branches)
            {
                if (br.IncumingNode.Name == name || br.OutcummingNode.Name == name)
                {
                    bool key = true;
                    foreach(Elements el in br.elements)
                    {
                        if (el is Key)
                        {
                            Key k = (Key)el;
                            if (k.active)
                            {
                                key = true;
                            }
                            else
                                key = false;
                            break;
                        }
                    }
                    if (key)
                    {


                        foreach (Elements el in br.elements)
                        {
                            if (el is CCS)
                            {
                                CCS c = (CCS)el;
                                if (c.IncumingNode.Name == name)
                                {
                                    sumEg += c.Voltage * br.ConductivityBranch;
                                }
                                else
                                {
                                    sumEg -= c.Voltage * br.ConductivityBranch;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void CalculateConductivityNode(ElectricalСircuit elcir)
        {
            bool key = true;
            foreach (Branche br in elcir.branches)
            {
                if (br.IncumingNode.Name == name || br.OutcummingNode.Name == name)
                {
                    foreach(Elements el in br.elements)
                    {
                        if (el is Key)
                        {
                            Key k = (Key)el;
                            if (k.active)
                            {
                                key = true;
                            }
                            else
                            {
                                key = false;
                                
                            }
                            break;
                        }
                    }
                    if (key)
                        conductivityNode += br.ConductivityBranch;
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public Node() { }
        public Node(string name)
        {
            this.name = name;
        }
    }
}