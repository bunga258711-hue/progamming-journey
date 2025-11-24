using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_7._2_bunga_xpplg1
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Hallo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini!");
        } 
     static void Main(String[]args)
        {
            Console.Write("Masukkan nama Anda: ");
            string namaSiswa = Console.ReadLine();
            SapaNama(namaSiswa);
        }
    }
}
