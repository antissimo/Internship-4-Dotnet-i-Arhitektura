using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.NewFolder
{
    public class Component
    {
        public String _Type { get; set; }
        public double _Weight { get; set; }

        public int _Price { get; set; }

        public Component(String Type, double Weight, int Price)
        {
            _Type = Type;
            _Weight = Weight;
            _Price = Price;
        }

    }
    public class Processor : Component

    {
        public String _Manufacturer { get; set; }
        public int _NumberOfCores { get; set; }
        public Processor(String Manufacturer, int NumberOfCores, int Price):base ("Processor",0,Price)
        {
            _Manufacturer = Manufacturer;
            _NumberOfCores = NumberOfCores;
        }
    }
    public class Ram : Component

    {
        public int _NumberOfRams { get; set; }
        public int _NumberOfGigaBytes { get; set; }
        public Ram(int NumberOfRams, int NumberOfGigaBytes, int Price) : base("RAM", 0, Price)
        {
            _NumberOfRams = NumberOfRams;
            _NumberOfGigaBytes = NumberOfGigaBytes;
        }
    }
    public class HardDisk : Component

    {
        public String _State { get; set; }
        public int _Capacity { get; set; }
        public HardDisk(String State, int Capacity, int Price, int Weight) : base("HardDisk", Weight, Price)
        {
            _State = State;
            _Capacity = Capacity;
        }
    }
    public class Case : Component

    {
        public String _Material { get; set; }
        public Case(String Material, double Weight, int Price) : base("Processor", Weight, Price)
        {
            _Material = Material;
        }
    }
}
