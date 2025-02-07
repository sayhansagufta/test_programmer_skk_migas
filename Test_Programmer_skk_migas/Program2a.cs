using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program2a
    {
        public static void Run()
        {
            // Input user untuk memasukkan nilai n
            Console.Write("Masukkan Nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // loop dari i  hingga ke n
            for(int i = 1; i <= n; i++ )
            {
                // menyimpan hasil;
                string result = "";

                for(int j = 1; j <= i; j++ )
                {
                    result += i.ToString();
                }
                // Tambahkan Hasil
                Console.WriteLine(result);
            }
        }
    }
}
