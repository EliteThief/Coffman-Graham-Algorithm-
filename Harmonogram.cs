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
           
        }

        public void AddMachine()
        {
            MachineList.Add(new Machine());
        }

        public void AddTask(Node node)
        {
            Boolean Added = false;
            foreach(Machine machine in MachineList)
            {
                
            }  

            if(!Added)
                {
                    AddMachine();
                    Machine lastMachine = MachineList[MachineList.Count()-1];
                    lastMachine.AddTask(node);

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
            Console.Write("Iter =\t");
           
        }


    }
}