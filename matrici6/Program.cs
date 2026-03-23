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
            Random r = new Random();
            int k = 0;
            for(int i = 0; i < m2.GetLength(0); i++)
            {
                for(int j = 0; j < m2.GetLength(1); j++)
                {
                    int rand = r.Next(0, 100);
                    m2[i, j] = rand;
                    if (m2[i, j] > x || m2[i, j] < y)
                    {
                        k++;
                    }
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            int[,] m2 = new int[10, 10];
            Console.WriteLine("Dammi l'inizio dell'intervallo");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dammi la fine dell'intervallo");
            int y = Convert.ToInt32(Console.ReadLine());
            riempimento(m);
            stampa(m);
            Console.WriteLine("I numeri che sono nell'intervallo dato sono: " + intervallo(m2, x, y));
            
        }
    }
}
