namespace Dolgozat_1210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Üdvözletem
            Console.WriteLine("Hello, Dr. Pol! :)");
            Console.WriteLine("Az alább lévő program Easter egg-eket tartalmaz.");
            Console.WriteLine();

            //Állatok
            Pet haziallat1 = new Pet("Apollo", "African Grey", 4, "123456", "001");
            Pet haziallat2 = new Pet("Soleil", "White-bellied Caique", 3, "123456", "002");
            Pet haziallat3 = new Pet("Ophelia", "White-bellied Caique", 3, "123456", "003");
            Pet haziallat4 = new Pet("Géza", "House Cat", 6, "999999", "004");
            Pet haziallat5 = new Pet("Pama", "Puli", 14, "999999", "005");
            Pet haziallat6 = new Pet("Auróra", "House Cat", 1, "987654", "006");
            Pet haziallat7 = new Pet("Prim", "German Shepard", 3, "007007", "007");
            //Console.WriteLine(haziallat1);

            //Pet hashsetek Owner-eknek (és egy esetben Vet-eknek)
            HashSet<Pet> allatok1 = new HashSet<Pet>(); //Dalton //Jacob Gypsum
            allatok1.Add(haziallat1);
            allatok1.Add(haziallat2);
            allatok1.Add(haziallat3);
            HashSet<Pet> allatok2 = new HashSet<Pet>(); //PistaBéla
            allatok2.Add(haziallat4);
            allatok2.Add(haziallat5);
            HashSet<Pet> allatok3 = new HashSet<Pet>(); //Nikus
            allatok3.Add(haziallat6);
            HashSet<Pet> allatok4 = new HashSet<Pet>(); //007
            allatok4.Add(haziallat7);

            //Pet hashsetek Vet-eknek
            HashSet<Pet> allatok5 = new HashSet<Pet>(); //Pol
            allatok5.Add(haziallat4);
            allatok5.Add(haziallat6);
            HashSet<Pet> allatok6 = new HashSet<Pet>(); //Bubó
            allatok6.Add(haziallat5);
            allatok6.Add(haziallat7);
            HashSet<Pet> allatok7 = new HashSet<Pet>(); //Én

            //Gazdák
            Owner gazdi1 = new Owner("123456", "Dalton", "06 70 420 6969", "apolloandfrens@gmail.com", "FL, something st. 0", allatok1);
            Owner gazdi2 = new Owner("999999", "PistaBéla", "06 30 55 55 440", "pamkutya@gmail.com", "Valami random budapesti cím", allatok2);
            Owner gazdi3 = new Owner("987654", "Nikus2200", "06 20 111 1111", "nikus@gmail.com", "Kecskemét asszem", allatok3);
            Owner gazdi4 = new Owner("007007", "James Bond", "06 70 007 0007", "nullanullahetesugynok@universal.com", "Holywood?", allatok4);
            //Console.WriteLine(gazdi1);

            //Fajok Vet-eknek
            string[] fajok1 = { "African Grey", "White-bellied Caique", "Any other kind of bird" };
            string[] fajok2 = { "Puli", "Pumi", "German Shepard" };
            string[] fajok3 = { "House Cat", "Floppa", "Lion" };
            string[] fajok4 = { "Turtle" };

            //Állatorvosok
            Vet orvos1 = new Vet("787878", "Dr. Jacob Gypsum", "06 20 22 22 122", "dr@gmail.com", "1001", fajok1, allatok1);
            Vet orvos2 = new Vet("121212", "Dr. Bubó", "06 30 100 2000", "bubo@gmail.hu", "1002", fajok2, allatok6);
            Vet orvos3 = new Vet("343434", "Dr. Pol", "06 50 300 4000", "janpol@gmail.com", "1003", fajok3, allatok5);
            Vet orvos4 = new Vet("565656", "Dávid Kucsera (alternatív univerzumban)", "06 20 999 9999", "kd@gmail.hu", "1004", fajok4, allatok7);
            //Console.WriteLine(orvos1);

            //Vet hashsetek VetClinic-eknek
            HashSet<Vet> orvosok1 = new HashSet<Vet>();
            orvosok1.Add(orvos1);
            orvosok1.Add(orvos2);
            HashSet<Vet> orvosok2 = new HashSet<Vet>();
            orvosok2.Add(orvos3);
            orvosok2.Add(orvos4);

            //Állatorvosi klinikák
            VetClinic klinika1 = new VetClinic("Gipsz Jakab klinikája", "B, Izé utca 7", "06 20 454 5454", "emil@emil.emil", orvosok1);
            VetClinic klinika2 = new VetClinic("The amazing Doctor Pol", "Amerika", "06 30 545 4545", "emal@emal.emal", orvosok2);
            //Console.WriteLine(klinika1);
        }
    }
}
