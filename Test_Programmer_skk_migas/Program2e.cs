using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program2e
    {
        public static void Run()
        {
            // Array awal
            int[] n = { 12, 9, 13, 6, 10, 4, 7, 2 };

            // List untuk menyimpan nilai yang bukan kelipatan 3
            List<int> filteredList = new List<int>();

            // Mengisi list dengan nilai yang bukan kelipatan 3
            foreach (int number in n)
            {
                if (number % 3 != 0)
                {
                    filteredList.Add(number);
                }
            }

            // Mengubah list menjadi array
            int[] filteredArray = filteredList.ToArray();

            // Mengurutkan array secara ascending
            Array.Sort(filteredArray);

            // Mencetak hasil
            Console.WriteLine("Array setelah membuang kelipatan 3 dan diurutkan:");
            foreach (int number in filteredArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}
