using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14_1_dziedziczenie.classess
{
    internal class MachineSimulator
    {
        private List<maszyna> machineList {  get; set; }

        

        public void AddMachine(maszyna machine)
        {
            machineList.Add(machine);
        }


        public void StartAll()
        {
            if(machineList.Count > 0)
            {
                foreach (var machine in machineList)
                {
                    machine.Start();
                }
            }
            else
            {
                Console.WriteLine("Lista maszyn jest pusta");
            }
        }


        public void WorkAll()
        {
            foreach (var machine  in machineList)
            {
               machine.Work();
            }
        }


        public void StopAll()
        {
            foreach(var machine in machineList)
            {
                machine.Stop();
            }
        }


    }
    
}
