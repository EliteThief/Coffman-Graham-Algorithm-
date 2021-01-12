using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffman_Graham_Algorithm_
{
    public class ListSorterComparer : IComparer<Node>
    {
        public int Compare(Node x, Node y)
        {
            int compareFirstElement = x.S_List.FirstOrDefault().CompareTo(y.S_List.FirstOrDefault()); 
            if (compareFirstElement == 0)
            {
                int compareListLenght = x.S_List.Count().CompareTo(y.S_List.Count());  
                if(compareListLenght == 0 )
                {
                    int compareName = x.Name.CompareTo(y.Name);  
                    return compareName;
                }            
                return compareListLenght;
            }
            return compareFirstElement;
        }
    }
}