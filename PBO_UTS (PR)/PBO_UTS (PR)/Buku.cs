using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Buku : Item
    {
        public string penulis { get; set; }

        public Buku(string judul, int tahun, string penulis) : base(judul, tahun)
        {
            this.penulis = penulis;
        }

        public override void Deskripsi()
        {
            Console.WriteLine($"[Buku] Ini adalah sebuah buku karya {penulis}.");
        }

        public void CekPenulis()
        {
            Console.WriteLine($"Penulis buku ini adalah: {penulis}");
        }
    }
}
