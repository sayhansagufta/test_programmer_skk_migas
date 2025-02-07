using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program1
    {
        public static void Run()
        {
            // Input user untuk memasukkan nilai n
            Console.Write("Masukkan Nilai n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] results = new string[n];

            // loop dari 1 sampai n
            for(int i = 1; i <= n; i++)
            {
                // Cek Kelipatan
                if(i % 3 == 0 && i % 4 == 0)
                {
                    results[i - 1] = "OKYES"; // kelipatan 3 & 4
                }

                // Kelipatan 3
                else if( i % 3 == 0)
                {
                    results[i - 1] = "OK"; // Kelipatan 3
                }

                // Kelipatan 4
                else if( i % 4 == 0)
                {
                    results[i - 1] = "YES"; // Kelipatan 4
                }

                // angka biasa
                else
                {
                    results[i - 1] = i.ToString();
                }

            }
            Console.WriteLine(string.Join(" ", results));
        }    
    }
}
