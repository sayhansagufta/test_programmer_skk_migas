using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Programmer_skk_migas
{
    class Program
    {
        static void Main(string[] args)
        {
            // string answer = "Y";
            Console.WriteLine("=== Selamat Datang di Program Test ===");

            while (true)
            {
                // DisplayMenu();
                Console.WriteLine("\n=======================================");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Program Kelipatan 3 'OK', Kelipatan 4 'YES', Kelipatan 3&4 'OKYES'");
                Console.WriteLine("2. Program Piramida (a.)");
                Console.WriteLine("3. Program Piramida (b.)");
                Console.WriteLine("4. Program Piramida (c.)");
                Console.WriteLine("5. Program Piramida (d.)");
                Console.WriteLine("6. Program Array");
                Console.WriteLine("7. Keluar");
                Console.WriteLine("=========================================");
                Console.Write("Pilih Opsi:");
                var option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Program1.Run();
                        break;

                    case "2":
                        Program2a.Run();
                        break;

                    case "3":
                        Program2b.Run();
                        break;

                    case "4":
                        Program2c.Run();
                        break;

                    case "5":
                        Program2d.Run();
                        break;

                    case "6":
                        Program2e.Run();
                        break;

                    case "7":
                        Console.WriteLine("=== Terima Kasih Telah Menggunakan Program Ini ===");
                        break;
                    default:
                        Console.WriteLine("=== Pilihan Tidak ada di Menu. Silahkan Coba Lagi!");
                        break;
                }
                Console.WriteLine("\nTekan 'ENTER' Untuk Melanjutkan ke Opsi Menu ");
                Console.ReadKey();
            }
        }

        //static void DisplayMenu()
        //{
        //    Console.WriteLine("\n=======================================");
        //    Console.WriteLine("Menu");
        //    Console.WriteLine("1. Program Kelipatan 3 'OK', Kelipatan 4 'YES', Kelipatan 3&4 'OKYES'");
        //    Console.WriteLine("2. Program Piramida (a.)");
        //    Console.WriteLine("3. Program Piramida (b.)");
        //    Console.WriteLine("4. Program Piramida (c.)");
        //    Console.WriteLine("5. Program Piramida (d.)");
        //    Console.WriteLine("6. Program Array");
        //    Console.WriteLine("=========================================");
        //    Console.ReadKey();
        //}
    }
}
