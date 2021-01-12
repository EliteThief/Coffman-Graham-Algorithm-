using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffman_Graham_Algorithm_
{
    public class OrderByLabel : IComparer<Node>
    {
        public int Compare(Node x, Node y)
        {
            int compareLabel = y.Label.CompareTo(x.Label); 
            return compareLabel;
        }
    }
}