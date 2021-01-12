using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace Coffman_Graham_Algorithm_
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Z1 = new Node("Z1",  new List<Node> { });
            Node Z2 = new Node("Z2",  new List<Node> { });
            Node Z3 = new Node("Z3",new List<Node> {Z2});
            Node Z4 = new Node("Z4",  new List<Node> { Z1,Z3 }); 
            Node Z6 = new Node("Z6",  new List<Node> { });
            Node Z5 = new Node("Z5",  new List<Node> { Z1,Z2,Z6 });
            Node Z7 = new Node("Z7",  new List<Node> { Z1,Z3 });
            Node Z8 = new Node("Z8",  new List<Node> { Z3 });
            Node Z9 = new Node("Z9",  new List<Node> { Z4, Z5,Z7 });
            Node Z10 = new Node("Z10", new List<Node> { Z5 });
            Node Z11 = new Node("Z11",  new List<Node> { Z7 });
            Node Z12 = new Node("Z12",  new List<Node> { Z5,Z6,Z8 });
            Node Z13 = new Node("Z13",  new List<Node> { Z6, Z8 });
            Node Z14 = new Node("Z14",  new List<Node> { Z7,Z13 });
            Node Z15 = new Node("Z15",  new List<Node> { Z9,Z10,Z11,Z12 });
            Node Z16 = new Node("Z16",  new List<Node> { Z11, Z13 });
            Node Z18 = new Node("Z18",  new List<Node> { Z13, Z14 });
            Node Z17 = new Node("Z17",  new List<Node> { Z10, Z12, Z16, Z18 });
            Node Z19 = new Node("Z19",  new List<Node> { Z11, Z14 });
            Calculate CGA = new Calculate();
            CGA.AddNode(Z1, Z2,Z3, Z4, Z5, Z6, Z7, Z8, Z9, Z10, Z11, Z12, Z13, Z14, Z15, Z16, Z17, Z18, Z19);
            CGA.CoffmanGrahamAlgo();
            OrderByLabel comparator = new OrderByLabel();
            CGA.Graph.Sort(comparator);
            Harmonogram harmonogram = new Harmonogram();
            WriteToDigraph(CGA.Graph);
            harmonogram.LoopAndAdd(CGA.Graph);
            harmonogram.PrintMachines();
        }

        static void WriteToDigraph(List<Node> lines)
        {
            string path = "D:\\VisualStudioCode\\Coffman-Graham Algorythm\\Coffman-Graham-Algorithm-\\Digraph.dot";
            if(File.Exists(path))
            {
                File.Delete(path);
            }
          using(StreamWriter graph = File.CreateText(path))
           {

                graph.WriteLine("Digraph {");
                graph.WriteLine("graph [pad=\"0.5\", nodesep =\"0.5\", ranksep=\"2\"];");
                graph.WriteLine("node [shape = plain]");
                graph.WriteLine("rankdir = LR");
               foreach(Node node in lines )
               {
                   graph.WriteLine( node.Name + "[label =<<table border=\"0\" cellborder=\"1\" cellspacing=\"0\" >");
                   graph.WriteLine("<tr><td>"+node.Name+"</td><td PORT =\""+node.Name+"\" colspan =\"2\">Duration: 1 </td></tr>");
                   graph.WriteLine("<tr><td>Label: "+node.Label+"</td><td>S_List:"+node.S_ListToString(node.S_List)+"</td></tr>");
                   graph.WriteLine("</table>>];");
                   graph.WriteLine("");
                   graph.WriteLine("");
               }
               
                foreach(Node node in lines)
                {
                    foreach(Node father in node.Fathers)
                    graph.WriteLine(father.Name +":"+father.Name+"->"+node.Name+":"+node.Name);
                }
                graph.WriteLine("}");
           }
            

        }
    }
}
