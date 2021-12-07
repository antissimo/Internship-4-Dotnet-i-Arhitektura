using Domain;
namespace Presentation
{
    class Program
    {

        static void Main(string[] args)
        {
            var nullUser = new User();
            if (nullUser.DoesUserExists() == false)
            {
                InitialOpening();
                Console.WriteLine("Uspjesno ste se prijavili u sustav");
            }
            Console.Clear();
            Console.WriteLine("Izaberite kojoj funkciji zelite pristupiti");
            Console.WriteLine("1-Sastavi i naruci novo racunalo");
            Console.WriteLine("2-Prikazi moje narudzbe");
            Console.WriteLine("3-Odjava");
            Console.WriteLine("4-Zakljuci narudzbu");
            var selectionMain = Console.ReadLine();
            while (selectionMain != "1" && selectionMain != "2" && selectionMain != "3" && selectionMain != "4")
            {
                Console.WriteLine("Neispravan unos molimo unesite broj od 1 do 4");
                selectionMain = Console.ReadLine();
            }
            var domain = new Domain.Domain();
            domain.Meni(selectionMain);
        }
        static User InitialOpening()
        {
            Console.WriteLine("Dobrodosli u ovaj hardware shop");
            Console.WriteLine("Molimo upisite svoje ime");
            var name = Console.ReadLine();
            while (name=="")
            {
                Console.Clear();
                Console.WriteLine("Vase ime nam je potrebno,molimo ga upisite");
                name = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Molimo upisite svoje prezime");
            var surname = Console.ReadLine();
            while (surname == "")
            {
                Console.Clear();
                Console.WriteLine("Vase prezime nam je potrebno,molimo ga upisite");
                surname = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Molimo upisite svoju adresu");
            var adress = Console.ReadLine();
            while (adress == "")
            {
                Console.Clear();
                Console.WriteLine("Vasa adresa nam je potrebna,molimo je upisite");
                adress = Console.ReadLine();
            }
            var CurrentUser = new User(name, surname, adress);
            CurrentUser.UserExists();
            return CurrentUser;

        }


    }
}

