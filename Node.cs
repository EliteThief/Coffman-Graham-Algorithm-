using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffman_Graham_Algorithm_
{
    public class Node
    {
        private string _name;
        private List<Node> _fathers = new List<Node>();
        private List<Node> _sons = new List<Node>();
        private List<int> _s_list = new List<int>();
        private int _label;

        public Node(string name, List<Node> fathers)
        {
            Name = name;
            Fathers = fathers;
            UpdateSons();
        }

        public string Name { get => _name; set => _name = value; }
        public List<Node> Fathers { get => _fathers; set => _fathers = value; }
        public List<Node> Sons { get => _sons; set => _sons = value; }
        public List<int> S_List { get => _s_list; set => _s_list = value; }
           
        public int Label {get => _label; set => _label = value;}
        private void UpdateSons()
        {
            foreach(Node father in Fathers)
            {
                if (!father.Sons.Contains(this))
                {
                    father.Sons.Add(this);
                }           
            }
        }

        private void SortS_List()
        {
            S_List.Sort();
            S_List.Reverse();
        }
    }
}
