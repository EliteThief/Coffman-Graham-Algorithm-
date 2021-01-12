using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffman_Graham_Algorithm_
{
    public class Harmonogram
    {
        private List<Machine> machineList;


        public Harmonogram()
        {
            MachineList = new List<Machine>();

        }

        public List<Machine> MachineList
        {
            get{return machineList;}
            set{machineList= value;}
        }


        public void LoopAndAdd(List<Node> nodeList)
        {
            while(MachineList.Count()<2)
            {
                MachineList.Add(new Machine());
            }
            int end =  nodeList.Count();
            for(int i = 0; i<(end/2+1);i++)
            {
                Node task1 = nodeList.FirstOrDefault(i=>!i.Fathers.Any());
                Node task2 = nodeList.Skip(1).FirstOrDefault(i=>!i.Fathers.Any());
                MachineList[0].AddTask(task1);
                if(!nodeList.Any())
                {
                    continue;
                }
                MachineList[1].AddTask(task2);
                RemoveNodeFromSons(task1,nodeList);              
                RemoveNodeFromSons(task2,nodeList);
                nodeList.Remove(task1);
                nodeList.Remove(task2);
                if(!nodeList.Any())
                {
                    break;
                }
            }
        }


        public void AddTask(Node node)
        {
            Boolean Added = false;
            foreach(Machine machine in MachineList)
            {
                if(machine.IsFree)
                {
                    machine.AddTask(node);
                    Added = true;
                    break;
                }
            }  

            if(!Added)
                {
                    Machine lastMachine = MachineList[MachineList.Count()-1];
                    lastMachine.AddTask(node);

                }
        }
        public void RemoveNodeFromSons(Node node,List<Node> listOfNodes)
        {
            foreach(Node listElement in listOfNodes)
            {
                if(listElement.Fathers.Contains(node))
                {
                    listElement.Fathers.Remove(node);
                }
            }
        }   
        
        public void PrintMachines()
        {
            int i = 1;
            foreach(Machine machine in MachineList)
            {
                Console.Write("M["+i+"] =\t");
                machine.Print();
                Console.WriteLine("");
                i++;
            }
           Console.WriteLine("C_Max = "+ MachineList.Max(x=>x.TaskList.Count()));
           
        }
    }
}