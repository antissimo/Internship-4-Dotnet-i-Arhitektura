using Data.NewFolder;
using Domain;

namespace Discount
{
    internal class Discount
    {
        public void Main() {
            
        }
        public int LoyaltyMemberDiscount(int CurrentPrice)
        {
            var nullUser = new User();
            if (nullUser.GetCurrentlySpent() > 1000)
            {
                return CurrentPrice - 100;
            }
            Console.WriteLine("Ne mozete iskoristiti ovaj popust,niste potrosili dovoljno na ovom racunu");
            return -1;
        }
        public int QuantityDiscount(int CurrentPrice)
        {
            var nullPc = new Computer();
            var reducedPrice = nullPc.QuantityDiscount();
            return CurrentPrice-reducedPrice;
        }
         public int CodeDiscount(int CurrentPrice)
            {
            Random rng = new Random();
            Dictionary<string, int> DiscountCodeSeed = new Dictionary<string, int>()
            {
                { "htoajdasat",rng.Next(0,99)},
                { "jahdfjkadh",rng.Next(0,99)},
                { "adsgahfjad",rng.Next(0,99)},
                { "ogfkhfoghk",rng.Next(0,99)},
                { "qeruqey123",rng.Next(0,99)},
                { "74huuhzjh2",rng.Next(0,99)}

            };
            Console.Clear();
            Console.WriteLine("Upisite kod koji zelite iskoristiti");
            var discountCode = Console.ReadLine();  
            while (DiscountCodeSeed.Any(stvar => stvar.Key == discountCode)!=true)
            {
                Console.WriteLine("Unijeli ste kod koji ne postoji, zelite li ponovno probati unijeti kod(1) ili nastaviti kupnju bez popusta(2)");
                var discountQuery = Console.ReadLine(); 
                while (discountQuery!= "1" && discountQuery != "2")
                {
                    Console.WriteLine("Molimo upisite broj 1 ili 2");
                    discountQuery = Console.ReadLine();
                }
                if (discountQuery == "2")
                {
                    return CurrentPrice;
                }
                else {
                    Console.WriteLine("Probajte unijeti kod koji postoji");
                    discountCode = Console.ReadLine();
                }
            }
            Console.WriteLine(DiscountCodeSeed[discountCode]);
            int newPrice =  (CurrentPrice* (100-DiscountCodeSeed[discountCode]))/100;
            DiscountCodeSeed.Remove(discountCode);
            return newPrice;
            }
            
            
        }
        
    }

