
namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void Izvedi()
        {
            int broj;
            broj = 7;
            Console.WriteLine("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);

            Console.WriteLine("Unesi decimalni broj: ");
            decimal db = decimal.Parse(Console.ReadLine());
            Console.WriteLine(db/10);

        }
    }
}
