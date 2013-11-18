using System;
//using System.Text;

namespace MatrixMultiplication {

    class Program {

        static void Main() {
            // давай теперь у нас интерфейс на английском будет
            Console.WriteLine("Введите размер матриц: ");
            int size = Int32.Parse(Console.ReadLine());
            // имена переменных с маленькой буквы
            int[,] Nonidentity = new int[size, size];
            int[,] Identity = new int[size, size];
            int[,] Result = new int[Nonidentity.GetLength(0), Identity.GetLength(1)];
            Random rand = new Random();

            // Nonidentity.Length можно просто использовать
            for (int i = 0; i < Nonidentity.GetLength(0); i++) {
                for (int j = 0; j < Nonidentity.GetLength(1); j++) {
                    Nonidentity[i, j] = rand.Next(0, 9);
                    Console.Write(Nonidentity[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < Identity.GetLength(0); i++) {
                for (int j = 0; j < Identity.GetLength(1); j++) {
                    if (i == j)
                        Identity[i, j] = 1;
                    else {
                        Identity[i, j] = 0;
                    }
                    Console.Write(Identity[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Полученная матрица: ");

            for (int i = 0; i < Nonidentity.GetLength(0); i++) {
                for (int j = 0; j < Nonidentity.GetLength(1); j++) {
                    Result[i, j] = Nonidentity[i, j] * Identity[i, j];
                    Console.Write( Result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
