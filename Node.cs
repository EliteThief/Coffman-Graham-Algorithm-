using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffman_Graham_Algorithm_
{
    public class Node
    {
        private string _name;
        private List<Node> _fathers = new List<Node>();
        private List<Node> _sons = new List<Node>();
        private List<int> _s_list = new List<int>();
        private int _label;
        private Boolean _isLabeled = false;
        public Node(string name, List<Node> fathers)
        {
            Name = name;
            Fathers = fathers;
            UpdateSons();
            SortS_List();
        }
        public Boolean IsLabeled {get => _isLabeled; set => _isLabeled = value;}
        public string Name { get => _name; set => _name = value; }
        public List<Node> Fathers { get => _fathers; set => _fathers = value; }
        public List<Node> Sons { get => _sons; set => _sons = value; }
        public List<int> S_List 
        {
            get 
            {
                 _s_list.Distinct().ToList();
                _s_list.Sort();
                _s_list.Reverse();
                return _s_list;
            } 
            set  
            {
                _s_list.Distinct().ToList();
                _s_list = value; 
                _s_list.Sort();
                _s_list.Reverse();
            }
        }
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

        public void Print()
        {
            foreach(int i in this.S_List)
            {
                Console.Write(i+",");
            }
             Console.WriteLine("");
        }
        public string S_ListToString(List<int> s_List)
        {
            string text = "{";
            foreach(int s_element in s_List)
            {
                if(s_element == s_List[0])
                {
                    text+=s_element;
                }
                else
                {
                text+=","+s_element;
                }
                
            }
            text += "}" ;
            return text;
        }
        private void SortS_List()
        {
            S_List.Sort();
            S_List.Reverse();
        }
    }
}
