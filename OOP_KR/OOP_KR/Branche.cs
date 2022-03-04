using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OOP_KR
{
    [Serializable]
    public class Branche : IDirection
    {
        private double currentBranch=0;
        private double conductivityBranch=0;//??????????
        private Node incumingNode=null;
        private Node outcumingNode=null;
        public CollectionElements elements = new CollectionElements();
        public Branche()
        {}
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
        public double CurrentBranch
        {
            get => currentBranch;
            set => currentBranch = value;
        }
        public double ConductivityBranch { get => conductivityBranch; set => conductivityBranch = value; }

        public void CalculateСonductivity(Branche br)
        {
            foreach (Elements el in elements)
            {
                if (el is Resister)
                {
                    Resister r = (Resister)el;
                    conductivityBranch += r.Conductibvity;
                }
            }
        }
        public void CalculatecurrentBranch()
        {
            currentBranch = outcumingNode.Potencial - incumingNode.Potencial;
            foreach (Elements el in elements)
            {
                if (el is CCS)
                {
                    CCS c = (CCS)el;
                    currentBranch = (currentBranch + c.Voltage) * conductivityBranch;
                    return;
                }
            }
            currentBranch = currentBranch * conductivityBranch;
        }
    }
}