using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Scheduling
{
    public class PriorityQueue
    {
        List<PCB> pCBs = new List<PCB>();


        public void Enqueue(PCB pcb)
        {
            pCBs.Add(pcb);
            pCBs = pCBs.OrderBy(x => x.ProcessPriority).ToList();
        }
        public void Dequeue()
        {
            PCB temp;
            temp = pCBs.First();
            pCBs.Remove(temp);
        }
        
        public void Reprioritize(string processName, int newPriority)
        {
            foreach (PCB pcb in pCBs)
            {
                if (pcb.ProcessName == processName)
                {
                    pcb.ProcessPriority = newPriority;
                }
            }
            pCBs = pCBs.OrderBy(x => x.ProcessPriority).ToList();
        }

        public override string ToString()
        {
            string temp = string.Join(",", pCBs);
            return "{" + temp + "}";
        }
    }
}
