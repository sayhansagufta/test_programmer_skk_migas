using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program2d
    {
        public static void Run()
        {
            Console.Write("Masukkan ukuran matriks (n): ");
            int n;

            // Memastikan input adalah angka yang valid
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Silakan masukkan angka positif yang valid: ");
            }

            int[,] matrix = new int[n, n];

            // Mengisi matriks dengan angka dari 1 hingga n*n
            int num = 1;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j % 2 == 0) // Kolom genap
                    {
                        matrix[i, j] = num++;
                    }
                    else // Kolom ganjil
                    {
                        matrix[n - 1 - i, j] = num++;
                    }
                }
            }

            // Mencetak matriks
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
