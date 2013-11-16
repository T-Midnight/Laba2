using System;
//using System.Text;

namespace MatrixMultiplication
{


    class Program
    {
        //Функция умножения матриц
        public static void MultiplyMatrix(int[,] Nonidentity, int[,] Identity)
        {
            int size = Int32.Parse(Console.ReadLine());
            Nonidentity = new int[size, size];
            Identity = new int[size, size];
            int[,] Result = new int[Nonidentity.GetLength(0), Identity.GetLength(1)];

            for (int i = 0; i < Nonidentity.GetLength(0); i++)
            {
                for (int j = 0; j < Nonidentity.GetLength(1); j++)
                {
                    Result[i, j] = Nonidentity[i, j] * Identity[i, j];
                    Console.Write("Полученная матрица: ", Result[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Единичная матрица (которая не работает)
        static int[,] Identity(int s)
        {
            s = Int32.Parse(Console.ReadLine());
            int[,] Identity = MatrixCreate(s, s);
            for (int i = 0; i < s; i++)
                Identity[i, i] = 1.0;
            return Identity;
        }

        static void Main()
        {
            Console.WriteLine("Введите размер матриц: ");
            int size = Int32.Parse(Console.ReadLine());
            int[,] Nonidentity = new int[size, size];
            int[,] Identity = new int[size, size];
            int[,] Result = new int[Nonidentity.GetLength(0), Identity.GetLength(1)];
            Random rand = new Random();

            //Первая, не единичная матрица (единственное, что работало из всего)
            for (int i = 0; i < Nonidentity.GetLength(0); i++) {
                for (int j = 0; j < Nonidentity.GetLength(1); j++) {
                    Nonidentity[i, j] = rand.Next(0, 9);
                    Console.Write(Nonidentity[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
