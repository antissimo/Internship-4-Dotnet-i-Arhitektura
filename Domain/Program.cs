using Data.NewFolder;
namespace Domain
{
    public class Domain
    {
        static void Main(string[] args)
        {

        }
        public void Meni(string choice)
        {
            Console.Clear();
            switch (choice)
            {
                case "1":
                    MakeANewPc();
                    break;
                case "2":
                    CurrentOrder();
                    break;
                case "3":
                    break;
                case "4":
                    EndOrder();
                    break;

            }
        }
        public void CurrentOrder()
        {
            var pc = new Computer();
            pc.PrintListOfPcs();
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Izaberite kojoj funkciji zelite pristupiti");
            Console.WriteLine("1-Sastavi i naruci novo racunalo");
            Console.WriteLine("2-Prikazi moje narudzbe");
            Console.WriteLine("3-Odjava");
            Console.WriteLine("4-Zakljuci narudzbu");
            var selectionMain1 = Console.ReadLine();
            while (selectionMain1 != "1" && selectionMain1 != "2" && selectionMain1 != "3" && selectionMain1 != "4")
            {
                Console.WriteLine("Neispravan unos molimo unesite broj od 1 do 4");
                selectionMain1 = Console.ReadLine();
            }
            Meni(selectionMain1);
        }
        public void EndOrder()
        {
            var nullUser = new User();
            var nullPc = new Computer();
            int totalPrice = 0;
            Console.WriteLine("Zelite li sami doc po paket(1) ili da vam bude dostavljen(2)");
            var shippingQuery = Console.ReadLine();
            while (shippingQuery != "1" && shippingQuery != "2")
            {
                Console.WriteLine("Neispravan unos,molim vas upisite broj 1 ili 2");
                shippingQuery = Console.ReadLine();

            }
            if (shippingQuery == "2")
            {
                double weight = nullPc.TotalWeight();
                int distance = nullUser._Distance;
                if (weight < 3.0)
                {
                    totalPrice += (distance / 10) * 5;
                }
                else if (weight < 10)
                {
                    totalPrice += (distance / 5) * 3;
                }
                else
                {
                    totalPrice += 50 + (distance / 20) * 10;

                }
            }
            totalPrice += nullPc.PriceOfAllPcs();
            Console.WriteLine($"Trenutna totalna cijena je {totalPrice}, zelite li iskoristiti neki popust?");
            Console.WriteLine("1 - Ne zelim popust");
            Console.WriteLine("2 - Zelim iskoristiti kupon za vjerne clanove(morate imati potrosenih preko 1000kn za ovaj popust)");
            Console.WriteLine("3 - Zelim iskoristiti popust na kolicinu(ako imate 3 iste komponente jednu dobivate besplatno)");
            Console.WriteLine("4 - Zelim popust upisom koda");
            var saleQuery = Console.ReadLine();
            while (saleQuery != "1" && saleQuery != "2" && saleQuery != "3" && saleQuery != "4")
            {
                Console.WriteLine("Molimo untesite broj izmedju 1 i 4");
                saleQuery = Console.ReadLine();
            }
            int newPrice = 0;
            switch (saleQuery)
            {
                case "1":
                    FinalPrint(totalPrice);
                    break;
                case "2":
                    var discountLoyalty = new Discount.Discount();
                    newPrice = discountLoyalty.LoyaltyMemberDiscount(totalPrice);
                    break;
                case "3":
                    var discountQuantity = new Discount.Discount();
                    newPrice = discountQuantity.QuantityDiscount(totalPrice);
                    break;
                case "4":
                    var discountCode = new Discount.Discount();
                    newPrice = discountCode.CodeDiscount(totalPrice);
                    break;

            }
            if (newPrice == -1)
            {
                newPrice = totalPrice;
                Console.WriteLine("Mozete iskoristiti popust na kolicinu(1),upisati kod(2) ili nastaviti bez popusta(3)");
                saleQuery = Console.ReadLine();
                while (saleQuery != "1" && saleQuery != "2" && saleQuery != "3" && saleQuery != "4")
                {
                    Console.WriteLine("Molimo unesite broj izmedju 1 i 4");
                    saleQuery = Console.ReadLine();
                }
                switch (saleQuery)
                {
                    case "1":
                        var discountQuantity = new Discount.Discount();
                        newPrice = discountQuantity.QuantityDiscount(totalPrice);
                        break;
                    case "2":
                        var discountCode = new Discount.Discount();
                        newPrice = discountCode.CodeDiscount(totalPrice);

                        break;
                    case "3":
                        FinalPrint(newPrice);
                        break;

                }
            }
            if (FinalPrint(newPrice))
            {
                Console.Clear();
                Console.WriteLine("Izaberite kojoj funkciji zelite pristupiti");
                Console.WriteLine("1-Sastavi i naruci novo racunalo");
                Console.WriteLine("2-Prikazi moje narudzbe");
                Console.WriteLine("3-Odjava");
                Console.WriteLine("4-Zakljuci narudzbu");
                var selectionMain1 = Console.ReadLine();
                while (selectionMain1 != "1" && selectionMain1 != "2" && selectionMain1 != "3" && selectionMain1 != "4")
                {
                    Console.WriteLine("Neispravan unos molimo unesite broj od 1 do 4");
                    selectionMain1 = Console.ReadLine();
                }
                Meni(selectionMain1);
            }
            else { Environment.Exit(0); }
        }

        public bool FinalPrint(int price)
        {
            var nullUser = new User();
            nullUser.AddToCurrentltySpent(price);
            Console.Clear();
            var pc = new Computer();
            pc.PrintListOfPcs();
            pc.ClearList();
            Console.WriteLine("Cijena za platiti je " + price);
            Console.WriteLine("Zelite li izaci iz ducana(1) ili nastaviti kupovati(2)");
            var continueQuery = Console.ReadLine();
            while (continueQuery != "1" && continueQuery != "2")
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj izmedju 1 i 2");
                continueQuery = Console.ReadLine();
            }
            if (continueQuery == "1")
            {
                return false;
            }
            return true;

        }
        public void MakeANewPc()
        {
            var nullPc = new Computer();
            Console.Clear();
            Console.WriteLine("Pocinje proces izgradnje vaseg novog racunala");
            Console.WriteLine("Prva stvar koju trebate izabrati je koji procesor zelite");
            Console.WriteLine("1 - vrsta:Deca-core, proizvodjac:AMD, cijena:900kn");
            Console.WriteLine("2 - vrsta:Octa-core, proizvodjac:AMD, cijena:650kn");
            Console.WriteLine("3 - vrsta:Octa-core, proizvodjac:Intel, cijena:625kn");
            Console.WriteLine("4 - vrsta:Quad-core, proizvodjac:Intel, cijena:450kn");
            var processorQuery = Console.ReadLine();
            while (processorQuery != "1" && processorQuery != "2" & processorQuery != "3" & processorQuery != "4")
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj od 1 do 4");
                processorQuery = Console.ReadLine();
            }
            Processor processor;
            switch (processorQuery)
            {
                case "1":
                    processor = new Processor("AMD", 10, 900);
                    nullPc.AddToComponentCounter(processor);
                    break;
                case "2":
                    processor = new Processor("AMD", 8, 650);
                    nullPc.AddToComponentCounter(processor);
                    break;
                case "3":
                    processor = new Processor("Intel", 8, 625);
                    nullPc.AddToComponentCounter(processor);
                    break;
                case "4":
                    processor = new Processor("Intel", 4, 450);
                    nullPc.AddToComponentCounter(processor);
                    break;
                default:
                    processor = new Processor("Null", 0, 0);
                    //Do ove linije nemoze doc jer while provjerava da je jedan od ova 4 broja,ali bez ove linije javlja "Use of unassigned local variable"
                    break;
            }
            Console.Clear();
            Console.WriteLine("Vas procesor je dodan, sada izaberite koji ram zelite");
            Console.WriteLine("1 - card od 4GB,svaki je 150kn");
            Console.WriteLine("2 - card od 8GB,svaki je 250kn");
            var ramQuery = Console.ReadLine();
            while (ramQuery != "1" && ramQuery != "2")
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj 1 ili 2");
                ramQuery = Console.ReadLine();
            }
            Console.WriteLine("Koliko tih kartica zelite, 1,2,3 ili 4?");
            int ramAmountQuery = Convert.ToInt32(Console.ReadLine());
            while (ramAmountQuery != 1 && ramAmountQuery != 2 && ramAmountQuery != 3 && ramAmountQuery != 4)
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj od 1 do 4");
                ramAmountQuery = Convert.ToInt32(Console.ReadLine());
            }
            Ram ram;
            switch (ramQuery)
            {
                case "1":
                    ram = new Ram(ramAmountQuery, 4, ramAmountQuery * 150);
                    nullPc.AddToComponentCounter(ram);
                    break;
                case "2":
                    ram = new Ram(ramAmountQuery, 8, ramAmountQuery * 250);
                    nullPc.AddToComponentCounter(ram);
                    break;
                default:
                    ram = new Ram(0, 0, 0);
                    break;
            }
            Console.Clear();
            Console.WriteLine("Vas ram je uspjesno dodan,sad izaberite koji Hard disk zelite");
            Console.WriteLine("1 - kapacitet:2TB, tip:HDD,cijena:200kn");
            Console.WriteLine("2 - kapacitet:1TB, tip:HDD,cijena:125kn");
            Console.WriteLine("3 - kapacitet:2TB, tip:SSD,cijena:600kn");
            Console.WriteLine("4 - kapacitet:1TB, tip:SSD,cijena:350kn");

            var hardDiskQuery = Console.ReadLine();
            while (hardDiskQuery != "1" && hardDiskQuery != "2" & hardDiskQuery != "3" & hardDiskQuery != "4")
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj od 1 do 4");
                hardDiskQuery = Console.ReadLine();
            }
            HardDisk hardDisk;
            switch (hardDiskQuery)
            {
                case "1":
                    hardDisk = new HardDisk("HDD", 2, 200, 2);
                    nullPc.AddToComponentCounter(hardDisk);
                    break;
                case "2":
                    hardDisk = new HardDisk("HDD", 1, 125, 1);
                    nullPc.AddToComponentCounter(hardDisk);
                    break;
                case "3":
                    hardDisk = new HardDisk("SSD", 2, 600, 0);
                    nullPc.AddToComponentCounter(hardDisk);
                    break;
                case "4":
                    hardDisk = new HardDisk("SSD", 1, 350, 0);
                    nullPc.AddToComponentCounter(hardDisk);
                    break;
                default:
                    hardDisk = new HardDisk("Null", 0, 0, 0);
                    break;
            }
            Console.Clear();
            Console.WriteLine("Vas Hard disk je uspjesno dodan,sad izaberite koje kuciste zelite");
            Console.WriteLine("1 - metalno 100kn");
            Console.WriteLine("2 - plasticno 180kn");
            Console.WriteLine("3 - karbonsko 450kn");
            var caseQuery = Console.ReadLine();
            while (caseQuery != "1" && caseQuery != "2" & caseQuery != "3")
            {
                Console.WriteLine("Neispravan unos, molimo unesite broj od 1 do 3");
                caseQuery = Console.ReadLine();
            }
            Case case1;

            switch (caseQuery)
            {
                case "1":
                    case1 = new Case("Metal", 1.5, 100);
                    nullPc.AddToComponentCounter(case1);
                    break;
                case "2":
                    case1 = new Case("Plastic", 1.0, 180);
                    nullPc.AddToComponentCounter(case1);
                    break;
                case "3":
                    case1 = new Case("Carbon", 0.5, 450);
                    nullPc.AddToComponentCounter(case1);
                    break;
                default:
                    case1 = new Case("Null", 0, 0);
                    break;
            }

            var computer = new Computer(processor, ram, hardDisk, case1);
            computer.AddToListOfPcs();

            Console.WriteLine("Izaberite kojoj funkciji zelite pristupiti");
            Console.WriteLine("1-Sastavi i naruci novo racunalo");
            Console.WriteLine("2-Prikazi moje narudzbe");
            Console.WriteLine("3-Odjava");
            Console.WriteLine("4-Zakljuci narudzbu");
            var selectionMain1 = Console.ReadLine();
            while (selectionMain1 != "1" && selectionMain1 != "2" && selectionMain1 != "3" && selectionMain1 != "4")
            {
                Console.WriteLine("Neispravan unos molimo unesite broj od 1 do 4");
                selectionMain1 = Console.ReadLine();
            }
            Meni(selectionMain1);


        }
    }
}



