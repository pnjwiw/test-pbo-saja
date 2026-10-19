using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Komik : Buku
    {
        public Komik(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }

        public override void Deskripsi()
        {
            Console.WriteLine("[Komik] Ini adalah sebuah komik bergambar.");
        }

        public void TampilkanIlustrasi()
        {
            Console.WriteLine("Menampilkan ilustrasi komik yang menarik...");
        }
    }
}
