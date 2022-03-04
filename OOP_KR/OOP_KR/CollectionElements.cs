using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    [Serializable]
    public class CollectionElements:IEnumerable
    {
        private List<Elements> Elements = new List<Elements>();
        public CollectionElements() { }
        public void AddElementAfter(Elements after, Elements el)
        {
            if (Elements.Count == 0)
            {
                return;
            }
            if (Elements[Elements.Count-1]==after)
            {
                Elements.Add(el);
                return;
            }
            int i = 0;
                foreach(Elements a in Elements)
                {
                    i++;
                    if (a.Name == after.Name)
                    {
                        Elements.Insert(i + 1, el);
                        return;
                    }
                }
            
            return;
        }
        public void DeleteListElements()
        {
            Elements.Clear();
        }
        public void DeleteElement(Elements el)
        {
            Elements.Remove(el);
        }
        public int CountResistor()
        {
            int i = 0;
            foreach(Elements el in Elements)
            {
                if (el is Resister)
                {
                    i++;
                }
            }
            return i;
        }
        public void AddElementBefore(Elements before, Elements el)
        {
            if (Elements.Count == 0)
            {
                return;
            }
            if (Elements[0] == before)
            {
                Elements.Insert(0, el);
                return;
            }
            int i = 0;
                foreach(Elements a in Elements)
                {
                    i++;
                    if (a.Name == before.Name)
                    {
                        Elements.Insert(i, el);
                        return;
                    }
                }
            
            return;
        }
        public void AddElementLast(Elements el)
        {
            
            Elements.Add(el);
            return;
        }
        public void AddElementHead(Elements el)
        {
            Elements.Insert(0, el);
            return;
        }
        public int Count()
        {
            int count = 0;
            foreach (Elements el in Elements)
            {
                count++;
            }
            return count;
        }
        public void Add(Object obj) 
        {
            if (obj is CCS)
            {
                CCS c = (CCS)obj;
                switch (c.IncumingNode.Name)
                {
                    case ("1"):
                        c.IncumingNode = Form1.electricalСircuit.FNode;
                        break;
                    case ("2"):
                        c.IncumingNode = Form1.electricalСircuit.SNode;
                        break;
                    case ("3"):
                        c.IncumingNode = Form1.electricalСircuit.TNode;
                        break;
                }
                switch (c.OutcummingNode.Name)
                {
                    case ("1"):
                        c.OutcummingNode = Form1.electricalСircuit.FNode;
                        break;
                    case ("2"):
                        c.OutcummingNode = Form1.electricalСircuit.SNode;
                        break;
                    case ("3"):
                        c.OutcummingNode = Form1.electricalСircuit.TNode;
                        break;
                }
                Elements.Add(c);
                return;
            }
            Elements el = (Elements)obj;
            Elements.Add(el);
        }
        public IEnumerator GetEnumerator()
        {
           foreach(Elements el in Elements)
            {
                yield return el;
            }
        }
    }
}