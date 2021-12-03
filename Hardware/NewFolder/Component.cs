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
        public decimal _Weight { get; set; }

        public int _Price { get; set; }

        public Component(String Type, decimal Weight, int Price)
        {
            _Type = Type;
            _Weight = Weight;
            _Price = Price;
        }

    }
}
