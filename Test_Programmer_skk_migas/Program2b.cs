using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program2b
    {
        public static void Run()
        {
            // Minta pengguna untuk memasukkan nilai n
            Console.Write("Masukkan nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop dari n hingga 1
            for (int i = 1; i <= n; i++)
            {
                // Buat string kosong untuk menyimpan hasil
                string result = "";

                // Tambahkan angka dari i hingga 1
                for (int j = i; j >= 1; j--)
                {
                    result += j.ToString();
                }

                // Tampilkan hasil
                Console.WriteLine(result);
            }

        }    
    }
}
