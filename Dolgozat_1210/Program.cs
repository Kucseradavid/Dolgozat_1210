using System.Collections.Immutable;

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
            Console.WriteLine();

            //Állatok
            Pet haziallat1 = new Pet("Apollo", "African Grey", 4, "123456", "001");
            Pet haziallat2 = new Pet("Soleil", "White-bellied Caique", 3, "123456", "002");
            Pet haziallat3 = new Pet("Ophelia", "White-bellied Caique", 3, "123456", "003");
            Pet haziallat4 = new Pet("Géza", "House Cat", 6, "999999", "004");
            Pet haziallat5 = new Pet("Pama", "Puli", 14, "999999", "005");
            Pet haziallat6 = new Pet("Auróra", "House Cat", 1, "987654", "006");
            Pet haziallat7 = new Pet("Prim", "German Shepard", 3, "007007", "007");

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

            //Gazdák
            Owner gazdi1 = new Owner("123456", "Dalton", "06 70 420 6969", "apolloandfrens@gmail.com", "FL, something st. 0", allatok1);
            Owner gazdi2 = new Owner("999999", "PistaBéla", "06 30 55 55 440", "pamkutya@gmail.com", "Valami random budapesti cím", allatok2);
            Owner gazdi3 = new Owner("987654", "Nikus2200", "06 20 111 1111", "nikus@gmail.com", "Kecskemét asszem", allatok3);
            Owner gazdi4 = new Owner("007007", "James Bond", "06 70 007 0007", "nullanullahetesugynok@universal.com", "Holywood?", allatok4);

            //Fajok Vet-eknek
            string[] fajok1 = { "African Grey", "White-bellied Caique", "Any other kind of bird" };
            string[] fajok2 = { "Puli", "Pumi", "German Shepard" };
            string[] fajok3 = { "House Cat", "Floppa", "Lion" };
            string[] fajok4 = { "Turtle" };

            //Üres Pet hashset Vet-eknek
            HashSet<Pet> allatok5 = new HashSet<Pet>();

            //Owner hashsetek Vet-eknek
            HashSet<Owner> gazdik1 = new HashSet<Owner>();
            gazdik1.Add(gazdi2);
            gazdik1.Add(gazdi3);
            gazdik1.Add(gazdi4);

            //Állatorvosok
            Vet orvos1 = new Vet("787878", "Dr. Jacob Gypsum", "06 20 22 22 122", "dr@gmail.com", "1001", fajok1, allatok1);
            Vet orvos2 = new Vet("121212", "Dr. Bubó", "06 30 100 2000", "bubo@gmail.hu", "1002", fajok2, gazdik1);
            Vet orvos3 = new Vet("343434", "Dr. Pol", "06 50 300 4000", "janpol@gmail.com", "1003", fajok3, gazdik1);
            Vet orvos4 = new Vet("565656", "Dávid Kucsera (alternatív univerzumben)", "06 20 999 9999", "kd@gmail.hu", "1004", fajok4, allatok5);

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

            //kiírások
            //a konzolos kiírás érthetőségének javítása érdekében van ennyi üres sor
            Console.WriteLine(haziallat1);
            Console.WriteLine();
            Console.WriteLine(haziallat2);
            Console.WriteLine();
            Console.WriteLine(haziallat3);
            Console.WriteLine();
            Console.WriteLine(haziallat4);
            Console.WriteLine();
            Console.WriteLine(haziallat5);
            Console.WriteLine();
            Console.WriteLine(haziallat6);
            Console.WriteLine();
            Console.WriteLine(haziallat7);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(gazdi1);
            Console.WriteLine();
            Console.WriteLine(gazdi2);
            Console.WriteLine();
            Console.WriteLine(gazdi3);
            Console.WriteLine();
            Console.WriteLine(gazdi4);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(orvos1);
            Console.WriteLine();
            Console.WriteLine(orvos2);
            Console.WriteLine();
            Console.WriteLine(orvos3);
            Console.WriteLine();
            Console.WriteLine(orvos4);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(klinika1);
            Console.WriteLine();
            Console.WriteLine(klinika2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(haziallat1.IsTreatedByWho(klinika1));
            Console.WriteLine(haziallat4.IsTreatedByWho(klinika1));
            Console.WriteLine(haziallat6.IsTreatedByWho(klinika2));
            Console.WriteLine(haziallat7.IsTreatedByWho(klinika2));


            //Utólagosan hozzáadott egy másik feladatból

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------");

            //Új Pet-ek (és Owner) létrehozása
            Pet haziallat101 = new Pet("101");
            Pet haziallat102 = new Pet("Ismeretlen", "102");
            Pet haziallat103 = new Pet("Nemtudott", "000000", "103");

            HashSet<Pet> allatok0 = new HashSet<Pet>();
            allatok0.Add(haziallat101);
            allatok0.Add(haziallat102); //allatok0.ass
            allatok0.Add(haziallat103);

            Owner gazdi0 = new Owner("000000", "Dooku gróf", "06200000000", "dookugrof@swmail.cor", "Coruscant, valahol", allatok0);
            
            //klinika1-hez egy másik Vet hozzáadása hogy ne legyenek ugyanakkorák
            string[] fajok0 = { "Hal", "Másik Hal" }; //új
            Vet orvos0 = new Vet("000001", "Dr. Hal", "06 70 800 9000", "palettas@gmail.hu", "0000", fajok0, allatok0); //új
            orvosok1.Add(orvos0);
            klinika1.ListOfVets = orvosok1;

            //Owner array IComparable teszteléshez
            Owner[] gazdik = { gazdi1, gazdi2, gazdi3, gazdi4 };

            Console.WriteLine();
            Console.WriteLine("Szortírozás előtti gazdik:");
            foreach (Owner g in gazdik)
            {
                Console.WriteLine(g);
            }

            Array.Sort(gazdik);

            Console.WriteLine();
            Console.WriteLine("Szortírozás utáni gazdik:");
            foreach (Owner g in gazdik)
            {
                Console.WriteLine(g);
            }

            //Vet array IComparable teszteléshez
            Vet[] orvosok = { orvos1, orvos2, orvos3, orvos4 };

            Console.WriteLine();
            Console.WriteLine("Szortírozás előtti orvosok:");
            foreach (Vet v in orvosok)
            {
                Console.WriteLine(v);
            }

            Array.Sort(orvosok);

            Console.WriteLine();
            Console.WriteLine("Szortírozás utáni orvosok:");
            foreach (Vet v in orvosok)
            {
                Console.WriteLine(v);
            }

            //VetClinic array IComparable teszteléshez
            VetClinic[] klinikak = { klinika1, klinika2};

            Console.WriteLine();
            Console.WriteLine("Szortírozás előtti klinikák:");
            foreach (VetClinic k in klinikak)
            {
                Console.WriteLine(k);
            }

            Array.Sort(klinikak);

            Console.WriteLine();
            Console.WriteLine("Szortírozás utáni klinikák:");
            foreach (VetClinic k in klinikak)
            {
                Console.WriteLine(k);
            }
        }
    }
}
