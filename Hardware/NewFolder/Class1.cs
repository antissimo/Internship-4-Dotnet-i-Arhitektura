using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.NewFolder
{
    public class Computer
    {
        public Component _Cpu { get; set; }

        public Component _Ram { get; set; }

        public int _NumberOfRams { get; set; }

        public Component _Gpu { get; set; }

        public Component _Hdd { get; set; }

        public Component Component { get; set; }
        public Computer(Component Cpu, Component Ram, Component Gpu, Component Hdd, int NumberOfRams)
        {
            _NumberOfRams = NumberOfRams;
            _Cpu = Cpu;
            _Ram = Ram;
            _Gpu = Gpu;
            _Hdd = Hdd;
        }

    }
}
