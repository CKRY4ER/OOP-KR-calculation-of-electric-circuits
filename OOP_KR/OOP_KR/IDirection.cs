using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_KR
{
    public interface IDirection
    {
        Node IncumingNode { get; set; }
        Node OutcummingNode { get; set; }
    }
}