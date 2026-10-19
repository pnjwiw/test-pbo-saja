using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_UTS__PR_
{
    class Program
    {
        static void Main(string[] args)
        {
            Perpustakaan perpus = new Perpustakaan();

            Novel novelLaskar = new Novel("Laskar Pelangi", 2005, "Andrea Hirata");
            MajalahTeknologi majalahKomputer = new MajalahTeknologi("InfoKomputer", 2023, 150);
            Komik komikNaruto = new Komik("Naruto Vol 1", 1999, "Masashi Kishimoto");

            perpus.TambahItem(novelLaskar);
            perpus.TambahItem(majalahKomputer);
            perpus.TambahItem(komikNaruto);

            perpus.DaftarItem();

            Console.WriteLine("=== DEMONSTRASI JAWABAN ===");

            novelLaskar.Deskripsi();
            majalahKomputer.Deskripsi();

            novelLaskar.BacaSinopsis();

            Console.WriteLine($"Informasi Lengkap Novel - Judul: {novelLaskar.judul}, Tahun: {novelLaskar.tahun}, Penulis: {novelLaskar.penulis}");

            majalahKomputer.TopikTeknologi();

            Item itemKomik = new Komik("One Piece", 1997, "Eiichiro Oda");
            itemKomik.Deskripsi();
        }
    }
}
