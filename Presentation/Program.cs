// See https://aka.ms/new-console-template for more information
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
namespace Presentation
{

    class Program
    {
        
        static void Main(string[] args)
        {
            var CurrentUser=InitialOpening();
            Console.Clear();
            Console.WriteLine("Uspjesno ste se prijavili u sustav");
            Console.WriteLine("Izaberite kojoj funkciji zelite pristupiti");
            Console.WriteLine("1-Sastavi i naruci novo racunalo");
            Console.WriteLine("2-Prikazi moje narudzbe");
            Console.WriteLine("3-Odjava");
            var selectionMain = Console.ReadLine();
            Meni();



            //switch (selectionMain)
            //{
            //    case "1":
                    
            //        break;
            //    case "2"
            //    case "3"
            //}




        }

        static User InitialOpening()
        {
            Console.WriteLine("Dobrodosli u ovaj hardware shop");
            Console.WriteLine("Molimo upisite svoje ime");
            var name = Console.ReadLine();
            Console.WriteLine("Molimo upisite svoje prezime");
            var surname = Console.ReadLine();
            Console.WriteLine("Molimo upisite svoju adresu");
            var adress = Console.ReadLine();
            var CurrentUser = new User(name, surname, adress);
            return CurrentUser;

        }

    }
}

