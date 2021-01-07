using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("1");
            int iterator = 1 ;
            List<Node> startingList = new List<Node>();
            List<Node> A = new List<Node>();

            Console.WriteLine("2");

            startingList = FindSonsWithoutSons();

            Console.WriteLine("3");

            A.AddRange(startingList);

            foreach(Node node in A)
             {
                 Console.WriteLine(node.Name);
             }

            foreach(Node node in startingList)
            {
                GiveIteratorNumber(ref iterator,node);
            }
             A.AddRange(startingList);
             A = FindListA(A);
             
             foreach(Node node in A)
             {
                 Console.WriteLine(node.Name);
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
            node.Label = i;
            i++;
        }
        public Boolean CheckAll(Node father,List<Node> listOfSons)
        {
            Node example = father;

            foreach(Node node in listOfSons)
            {
                example.Fathers.Remove(node);
            }

            if(example.Fathers.Any())
            {
                return false;
            }
            return true;
        }

    }
}