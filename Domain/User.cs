using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public String _Name { get; set; }
        public String _Surname { get; set; }

        public String _Adress { get; set; }

        public int _Distance { get; set; }


        public User(String Name, String Surname, String Adress)
        {
            _Name = Name;
            _Surname = Surname;
            _Adress = Adress;
            _Distance = GenerateDistance();
        }
        public int GenerateDistance()
        {
            Random rnd = new Random();
            return (rnd.Next(50, 999));
        }
    }
}
