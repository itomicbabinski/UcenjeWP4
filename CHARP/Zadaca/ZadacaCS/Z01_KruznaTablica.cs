
namespace ZadacaCS
{
    internal class Z01_KruznaTablica
    {
        public static void Izvedi()
        {
            int imax;
            Console.WriteLine("Unesi broj redaka: ");
            imax = int.Parse(Console.ReadLine());
            int jmax;
            Console.WriteLine("Unesi broj stupaca: ");
            jmax = int.Parse(Console.ReadLine());

            int max = imax * jmax;
            int[,] tablica = new int[100, 100];

            int A0 = jmax - 1;
            int A1 = 0;
            int B0 = imax - 2;
            int B1 = 0;
            int ij = max;
            int i;
            int j;

            //Punjenje polja
            for (; ; )
            {

                for (j = A0; j >= A1; j--)
                {
                    i = B0 + 1;
                    tablica[i, j] = ij;
                    ij = ij - 1;
                    if (ij == 0) { break; }
                }
                if (ij == 0) { break; }

                for (i = B0; i >= B1; i--)
                {
                    j = A1;
                    tablica[i, j] = ij;
                    ij = ij - 1;
                    if (ij == 0) { break; }
                }
                if (ij == 0) { break; }

                for (j = B1 + 1; j <= A0; j++)
                {
                    i = B1;
                    tablica[i, j] = ij;
                    ij = ij - 1;
                    if (ij == 0) { break; }
                }
                if (ij == 0) { break; }

                for (i = A1 + 1; i <= B0; ++i)
                {
                    j = A0;
                    tablica[i, j] = ij;
                    ij = ij - 1;
                    if (ij == 0) { break; }
                }
                if (ij == 0) { break; }

                A0 = A0 - 1;
                A1 = A1 + 1;
                B0 = B0 - 1;
                B1 = B1 + 1;

            }
            int val;
            //Ispis polja

            for (i = 0; i < imax; i++)
            {
                Console.WriteLine("   ");
                for (j = 0; j < jmax; j++)
                {
                    val = tablica[i, j];
                    if (val<10)
                    {
                        Console.Write(" ");
                    }
                    if (val < 100)
                    {
                        Console.Write(" ");
                    }
                    if (val < 1000)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(val);
                    Console.Write(" ");
                }


            }

        }
    }
}
