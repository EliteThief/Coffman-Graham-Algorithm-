using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffman_Graham_Algorithm_
{
    public class Machine
    {
        private List<Node> taskList;
        private int isFree ;

        public Machine()
        {
            TaskList = new List<Node>();
        }

        public List<Node> TaskList
        {
            get{ return taskList;}
            set{ taskList = value;}
        }

        public int IsFree
        {
            get { return isFree;}
            set { isFree = value;}
        }

        public void AddTask(Node node)
        {
            TaskList.Add(node);
           // IsFree=node.ErliestEndTime;
        }

        public void Print()
        {
            
        }

    }
}