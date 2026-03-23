namespace matrici6
{
    internal class Program
    {
        static int[,] stampa(int[,] m)
        {
            int n = 100, n2 = 10, n3 = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = n;
                    n = n - n2;
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
                n3 += 10;
                n2--;
                n = 100 - n3;
            }
            return m;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            stampa(m);
        }
    }
}
