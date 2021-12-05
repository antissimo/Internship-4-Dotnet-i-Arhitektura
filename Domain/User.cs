﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        static int distanceFromUserOne=0;
        static bool userExists = false;
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
        public User()
        {
            _Name = null;
            _Surname = null;
            _Adress = null;
            _Distance = distanceFromUserOne;
        }
        public int GenerateDistance()
        {
            Random rnd = new Random();
            int broj = rnd.Next(50, 999);
            distanceFromUserOne = broj;
            return (broj);
           
        }
        public void UserExists()
        {
            userExists = true;  
        }
        public bool DoesUserExists()
        {
            return userExists;
        }
    }
}
