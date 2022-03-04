using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class CollectionBranches:IEnumerable
    {
        private List<Branche> branches = new List<Branche>();
        public List<Branche> Branches { get => branches; set => branches = value; }
        public CollectionBranches() { }
        public void Add(Object obj)
        {
            Branche br = (Branche)obj;
            switch (br.IncumingNode.Name)
            {
                case ("1"):
                    br.IncumingNode = Form1.electricalСircuit.FNode;
                    break;
                case ("2"):
                    br.IncumingNode = Form1.electricalСircuit.SNode;
                    break;
                case ("3"):
                    br.IncumingNode = Form1.electricalСircuit.TNode;
                    break;
            }
            switch (br.OutcummingNode.Name)
            {
                case ("1"):
                    br.OutcummingNode = Form1.electricalСircuit.FNode;
                    break;
                case ("2"):
                    br.OutcummingNode = Form1.electricalСircuit.SNode;
                    break;
                case ("3"):
                    br.OutcummingNode = Form1.electricalСircuit.TNode;
                    break;
            }
            branches.Add(br);

        }
        public void AddBranche(Branche br)
        {
            Branches.Add(br);
        }
        public void DeleteListBranch()
        {
            for(int i = branches.Count - 1; i >= 0; i--)
            {
                DeleteBranche(branches[i]);
            }
            if (branches.Count == 0)
            {
                branches.Clear();
            }
        }
        public void DeleteBranche(Branche br)
        {
            br.elements.DeleteListElements();
            branches.Remove(br);
        }
        public int Count()
        {
            int i = 0;
            foreach (Branche br in Branches)
            {
                i++;
            }
            return i;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Branche br in Branches)
            {
                yield return br;
            }
        }
    }
}