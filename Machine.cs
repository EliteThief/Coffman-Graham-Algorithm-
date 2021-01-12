using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Coffman_Graham_Algorithm_
{
    public class Machine
    {
        private List<Node> taskList;
        private bool isFree ;

        public Machine()
        {
            TaskList = new List<Node>();
        }

        public List<Node> TaskList
        {
            get{ return taskList;}
            set{ taskList = value;}
        }

        public bool IsFree
        {
            get { return isFree;}
            set { isFree = value;}
        }

        public void AddTask(Node node)
        {
            TaskList.Add(node);
        }

        public void Print()
        {
            foreach(Node task in TaskList)
            {
                if(task is null)
                {
                    break;
                }
                Console.Write(task.Name+" ");
            }
        }

    }
}