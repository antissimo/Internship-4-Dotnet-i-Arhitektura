using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.NewFolder
{
    public class Computer
    {
        static List<Computer> listOfPcs = new List<Computer>();
        public Processor _Cpu { get; set; }

        public Ram _Ram { get; set; }

        public Case _Case { get; set; }

        public HardDisk _Hdd { get; set; }

        public Computer(Processor Cpu, Ram Ram, HardDisk Hdd, Case Case)
        {
            _Cpu = Cpu;
            _Ram = Ram;
            _Hdd = Hdd;
            _Case = Case;
            
        }
        public Computer()
        {
            _Cpu = null;
            _Ram = null;
            _Case = null;
            _Hdd = null;
        }

        public int CalculatePrice()
        {
            var ukupno=this._Cpu._Price+this._Ram._Price+this._Hdd._Price+this._Case._Price;
            return ukupno;
        }
        public double CalculateWeight()
        {
            double tezina= this._Cpu._Weight + this._Ram._Weight + this._Hdd._Weight + this._Case._Weight;
            return tezina;
        }
        public void AddToListOfPcs() 
        {
            listOfPcs.Add(this);
        }
        public void PrintListOfPcs()
        {
            var ukupnaCijena = 0;
            foreach(Computer pc in listOfPcs)
            {
                Console.WriteLine("Lista dijelova ovog kompjutera:");
                Console.WriteLine("Procesor:");
                Console.WriteLine(pc._Cpu._Manufacturer+" "+pc._Cpu._NumberOfCores+" Cores");
                Console.WriteLine("Ram:");
                Console.WriteLine(pc._Ram._NumberOfGigaBytes+"GB X"+pc._Ram._NumberOfRams);
                Console.WriteLine("Hard disk:");
                Console.WriteLine(pc._Hdd._State+ " " + pc._Hdd._Capacity+ "TB ");
                Console.WriteLine("Case:");
                Console.WriteLine(pc._Case._Material);
                var cijena = pc.CalculatePrice();
                Console.WriteLine("Cijena tog kompjutera je " + cijena);
                ukupnaCijena += cijena;
            }
            Console.WriteLine("Trenutna ukupna cijena je "+ukupnaCijena);
        }
        public int  PriceOfAllPcs()
        {
            var totalPrice = 0;
            foreach (Computer pc in listOfPcs)
            {
                var price = pc.CalculatePrice();
                totalPrice += price;
            }
            return totalPrice;
        }
        public double TotalWeight()
        {
            double totalWeight = 0.0;
            foreach (var pc in listOfPcs)
            {
                totalWeight += pc.CalculateWeight();
            }
            return totalWeight;
        }
        //public int threeforpriceoftwo()
        //{
        //    bool flag;
        //    int priceDeducted = 0;
        //   Dictionary<Computer, int> pcDict = new Dictionary<Computer, int>();
        //        foreach(var pc in listOfPcs)
        //        {

                
        //            foreach(var key in pcDict.Keys)
        //            {
        //                if (pc._Cpu== key._Cpu)
        //                {
                        
        //                }
        //            }
        //        }
        //        return priceDeducted;
        //    }
       }
}
