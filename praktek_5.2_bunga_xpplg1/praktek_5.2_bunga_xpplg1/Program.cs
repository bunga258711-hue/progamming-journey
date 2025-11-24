using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktek_5._2_bunga_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumalahan
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 sampai 5: ");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                //Tambahkan nilai i saat ini ke variabel total
                total = total + i;

                Console.WriteLine("Menambahkan " + i + ", total semnatara = " + total);

            }
            Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);

        }
    }
}
