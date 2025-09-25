using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class namasiswaarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DAFTAR NAMA SISWA ===\n");
           
            string[] siswa = { "Andi", "Budi", "Citra", "Dedi", "Eka" };

           
            foreach (string nama in siswa)
            {
                Console.WriteLine($"- {nama}");
            }

            Console.WriteLine("\\nProgram selesai. Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
