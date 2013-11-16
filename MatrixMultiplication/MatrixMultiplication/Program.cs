using System;
//using System.Text;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер матриц: ");
            int size = Int32.Parse(Console.ReadLine());
            int[,] Nonidentity = new int[size, size];
            int[,] Identity = new int[size, size];

            for (int i = 0; i < Nonidentity.Length; i++) {
                for (int j = 0; j < Nonidentity.Length; j++) {
                    Random rand = new Random();
                    Nonidentity[i, j] = rand.Next(0, 9);
                    Console.Write(Nonidentity[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
