using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffman_Graham_Algorithm_
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Z1 = new Node("Z1",  new List<Node> { });
            Node Z2 = new Node("Z2",  new List<Node> { });
            Node Z4 = new Node("Z4",  new List<Node> { Z1 });
            Node Z5 = new Node("Z5",  new List<Node> { Z1 });
            Node Z6 = new Node("Z6",  new List<Node> { Z2 });
            Node Z7 = new Node("Z7",  new List<Node> { Z2 });
            Node Z8 = new Node("Z8",  new List<Node> { Z4 });
            Node Z9 = new Node("Z9",  new List<Node> { Z5, Z2 });
            Node Z10 = new Node("Z10", new List<Node> { Z5, Z2, Z6 });
            Node Z11 = new Node("Z11",  new List<Node> { Z7 });
            Node Z12 = new Node("Z12",  new List<Node> { Z7 });
            Node Z13 = new Node("Z13",  new List<Node> { Z8, Z9 });
            Node Z14 = new Node("Z14",  new List<Node> { Z10 });
            Node Z15 = new Node("Z15",  new List<Node> { Z10, Z11 });
            Node Z16 = new Node("Z16",  new List<Node> { Z10, Z11 });
            Node Z17 = new Node("Z17",  new List<Node> { Z12 });
            Node Z18 = new Node("Z18",  new List<Node> { Z13, Z14 });
            Node Z19 = new Node("Z19",  new List<Node> { Z16, Z17 });
            Node Z20 = new Node("Z20",  new List<Node> { Z19 });
            Calculate CGA = new Calculate();
            CGA.AddNode(Z1, Z2, Z4, Z5, Z6, Z7, Z8, Z9, Z10, Z11, Z12, Z13, Z14, Z15, Z16, Z17, Z18, Z19, Z20);
            CGA.CoffmanGrahamAlgo();
          
        }
    }
}
