using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Coffman_Graham_Algorithm_
{
    public class Calculate
    {
        private List<Node> _graph = new List<Node>();


        static Calculate() { }

        public List<Node> Graph 
        {
            get {return _graph ; }
        }


        public void AddNode(params Node[] node)
        {
        foreach (Node add in node)
            {
                _graph.Add(add);
            }
        }
        public void CoffmanGrahamAlgo()
        {
            int iterator = 1 ;
            List<Node> startingList = new List<Node>();
            List<Node> A = new List<Node>();
            ListSorterComparer comparer = new ListSorterComparer();
            startingList = FindSonsWithoutSons();
            foreach(Node node in startingList)
            {
                GiveIteratorNumber(ref iterator,node);
            }
            A =  A.Union(FindListA(startingList)).ToList();
            while(A.Any())
            {
                A.Sort(comparer);
                GiveIteratorNumber(ref iterator,A.First());
                A = A.Union(FindListA(A)).ToList(); 
                A.Remove(A.First());
            }
        }
        
        public List<Node> FindSonsWithoutSons()
        {
            List<Node> SonsWithoutSons = new List<Node>();
            foreach(Node node in Graph)
            {
                if(!node.Sons.Any())
                {
                    SonsWithoutSons.Add(node);
                }
            }
            return SonsWithoutSons;
        }

        public List<Node> FindListA(List<Node> previousListA)
        {
            List<Node> found = new List<Node>();
            foreach(Node node in previousListA)
            {
                foreach(Node father in node.Fathers )
                {
                   if(CheckAll( father, previousListA))
                    {
                        found.Add(father);
                    }
                }
            }
            return found;
        }

        public void GiveIteratorNumber(ref int i,Node node)
        {
            if(node.Label==0)
            {
                node.IsLabeled = true;
                node.Label = i;
                i++;
            }
            
        }
        public Boolean CheckAll(Node father,List<Node> listOfSons)
        {
            if(father.Sons.Any(i => !(i.IsLabeled)))
            {
                return false;
            }
            else
            {
                foreach(Node son in father.Sons)
                {
                    if(son.Label!=0 && !father.S_List.Contains(son.Label))
                        father.S_List.Add(son.Label);         
                }
                return true;
            }
        }

        public void PrintAll()
        {
            foreach(Node node in _graph)
            {
                Console.WriteLine(node.Name +": Label="+node.Label+"     S_List{"+S_List_ToString(node.S_List)+"}");
            }
        }

        public string S_List_ToString(List<int> nodes)
        {
            string lista = "";
            foreach(int i in nodes)
            {
                lista += " "+i+",";
            }
            return lista;
        }

    }
}