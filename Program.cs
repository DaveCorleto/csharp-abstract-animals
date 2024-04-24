namespace csharp_abstract_animals
{
    internal class Program
    {   
      
        static void Main(string[] args)
        {
            void FaiVolare(IAnimalicheVolano animale)
            {
                animale.Vola();
            }
            void FaiNuotare(IAnimalicheNuotano animale)
            {
                animale.Nuota();
            }



            Cane Holly = new Cane("Labrador", "Holly", 6);
            Console.WriteLine($"Ecco un nuovo animale: si chiama {Holly.nome}, è un {Holly.razza}, ha {Holly.età} anni. Ora farà cose...");
            Holly.Mangia();
            Holly.Dormi();
            Holly.Verso();
            FaiNuotare(Holly);
            Console.WriteLine("\n\n\n\n\n\n");

            Passerotto CippinoCippotto = new Passerotto("Cinciallegra", "CippinoCippotto", 1);
            Console.WriteLine($"Ecco un nuovo animale: si chiama {CippinoCippotto.nome}, è un {CippinoCippotto.razza}, ha {CippinoCippotto.età} anni. Ora farà cose...");
            CippinoCippotto.Mangia();
            CippinoCippotto.Dormi();
            CippinoCippotto.Verso();
            FaiVolare(CippinoCippotto);   
            Console.WriteLine("\n\n\n\n\n\n");



            Aquila Dorothy = new Aquila ("Aquila dalla testa bianca", "Dorothy", 10);
            Console.WriteLine($"Ecco un nuovo animale: si chiama {Dorothy.nome}, è un {Dorothy.razza}, ha {Dorothy.età} anni. Ora farà cose...");
            Dorothy.Mangia();
            Dorothy.Dormi();
            Dorothy.Verso();
            FaiVolare(Dorothy);
            Console.WriteLine("\n\n\n\n\n\n");

            Delfino Asdrubale = new Delfino("Tursiope Troncato", "Asdrubale", 4);

            Console.WriteLine($"Ecco un nuovo animale: si chiama {Asdrubale.nome}, è un {Asdrubale.razza}, ha {Asdrubale.età} anni. Ora farà cose...");
            Asdrubale.Mangia();
            Asdrubale.Dormi();
            Asdrubale.Verso();
            FaiNuotare(Asdrubale);
            Console.WriteLine("\n\n\n\n\n\n");

            FaiNuotare(Asdrubale);



        }
    }
}
