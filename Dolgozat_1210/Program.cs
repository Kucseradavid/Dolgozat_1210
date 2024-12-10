namespace Dolgozat_1210
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dr. Pol! :)");
            Console.WriteLine("Az alább lévő program Easter egg-eket tartalmaz.");
            Console.WriteLine();

            Pet haziallat1 = new Pet("Apollo", "African Grey", 4, "123456", "001");
            Pet haziallat2 = new Pet("Soleil", "White-bellied Caique", 2, "123456", "002");
            Pet haziallat3 = new Pet("Ophelia", "White-bellied Caique", 2, "123456", "003");
            //Console.WriteLine(haziallat1);

            HashSet<Pet> allatok1 = new HashSet<Pet>();
            allatok1.Add(haziallat1);
            allatok1.Add(haziallat2);
            allatok1.Add(haziallat3);

            Owner gazdi1 = new Owner("123456", "Dalton", "06704206969", "apolloandfrens@gmail.com", "FL, something st. 0", allatok1);
            //Console.WriteLine(gazdi1);

            string[] fajok1 = { "African Grey", "White-bellied Caique", "Any other kind of bird" };

            Vet orvos1 = new Vet("987654", "Mr. Jacob Gypsum", "06202222122", "dr@gmail.com", "1001", fajok1, allatok1);
            Console.WriteLine(orvos1);
        }
    }
}
