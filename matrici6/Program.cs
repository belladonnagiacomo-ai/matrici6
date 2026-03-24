namespace matrici6
{
    internal class Program
    {
        static int[,] riempimento(int[,] m)
        {
            int n = 100, n2 = 10, n3 = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = n;
                    n = n - n2;
                    
                }
                n3 += 10;
                n2--;
                n = 100 - n3;
            }
            return m;
        }
        static void stampa(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int intervallo(int[,] m2, int x, int y)
        {
            Console.WriteLine("matrice numero 2: ");
            Random r = new Random();
            int k = 0;
            for(int i = 0; i < m2.GetLength(0); i++)
            {
                for(int j = 0; j < m2.GetLength(1); j++)
                {
                    int rand = r.Next(0, 100);
                    m2[i, j] = rand;
                    if (m2[i, j] > x && m2[i, j] < y)
                    {
                        k++;
                    }
                    Console.Write(m2[i,j] + "\t");
                }
                Console.WriteLine();
            }
            return k;
        }
        static float[] Media(int[,] m2)
        {
            float[] media = new float[m2.GetLength(0)];
            int somma = 0;
            for(int i = 0; i < m2.GetLength(0); i++)
            {
                somma = 0;
                for(int j = 0; j < m2.GetLength(1); j++)
                {
                    somma = somma + m2[i, j];
                }
                media[i] = somma/m2.GetLength(0);
                Console.WriteLine("La media della riga " + i + " e di: " + media[i]);
            }
            return media;
        }
        static int[] SommaC(int[,] m2)
        {
            int[] sommaC = new int[m2.GetLength(1)];
            int somma = 0;
            for(int i = 0; i < m2.GetLength(1);i++)
            {
                somma = 0;
                for(int j = 0;j < m2.GetLength(0); j++)
                {
                    somma = somma + m2[j, i];
                }
                sommaC[i] = somma;
                Console.WriteLine("La somma della colonna " + i + " e di: " + sommaC[i]);
            }
            return sommaC;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            int[,] m2 = new int[10, 10];
            Console.WriteLine("Dammi l'inizio dell'intervallo");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dammi la fine dell'intervallo");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            riempimento(m);
            stampa(m);
            Console.WriteLine();

            Console.WriteLine("I numeri che sono nell'intervallo dato sono: " + intervallo(m2, x, y));
            Console.WriteLine();

            Media(m2);
            Console.WriteLine();

            SommaC(m2);
        }
    }
}
