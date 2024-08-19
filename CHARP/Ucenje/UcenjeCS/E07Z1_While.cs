
namespace UcenjeCS
{
    internal class E07Z1_While
    {
        public static void Izvedi()
        {
            int max;
            int broj1;
            max = 0;
            Console.WriteLine("Unesi broj: ");
            broj1 = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= broj1)

            {
                
                max = max + i;
                //Console.WriteLine(max);
                i = i + 2;
            }
            Console.WriteLine(max);
        }
    }
}
