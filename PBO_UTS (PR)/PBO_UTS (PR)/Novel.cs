using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Novel : Buku
    {
        public Novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }

        public override void Deskripsi()
        {
            Console.WriteLine("[Novel] Ini adalah sebuah novel fiksi.");
        }

        public void BacaSinopsis()
        {
            Console.WriteLine("Membaca sinopsis novel: Di sebuah desa terpencil...");
        }
    }
}
