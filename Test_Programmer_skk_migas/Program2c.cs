using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program2c
    {
        public static void Run()
        {
            // Minta pengguna untuk memasukkan nilai n
            Console.Write("Masukkan Nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop dari 1 hingga n
            for (int i = 1; i <= n; i++)
            {
                // Buat string kosong untuk menyimpan hasil
                string result = "";

                if (i % 2 == 1) // Jika i ganjil
                {
                    // Tambahkan angka dari i hingga 1
                    for (int j = i; j >= 1; j--)
                    {
                        result += j.ToString();
                    }
                }
                else // Jika i genap
                {
                    // Tambahkan angka dari i hingga 1
                    for (int j = i; j >= 1; j--)
                    {
                        result += j.ToString();
                    }
                    // Tambahkan angka dari 2 hingga i
                    for (int j = 2; j <= i; j++)
                    {
                        result += j.ToString();
                    }
                }

                // Tampilkan hasil
                Console.WriteLine(result);
            }
        }
    }
}
