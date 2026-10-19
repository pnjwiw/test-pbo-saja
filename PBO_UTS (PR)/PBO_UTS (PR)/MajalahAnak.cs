using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class MajalahAnak : Majalah
    {
        public MajalahAnak(string judul, int tahun, int edisi) : base(judul, tahun, edisi) { }

        public override void Deskripsi()
        {
            Console.WriteLine("[Majalah Anak] Ini adalah majalah edukasi anak-anak.");
        }

        public void KategoriAnak()
        {
            Console.WriteLine("Kategori usia pembaca: 5 - 12 Tahun.");
        }
    }
}
