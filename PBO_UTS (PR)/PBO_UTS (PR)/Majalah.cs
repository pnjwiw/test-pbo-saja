using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Majalah : Item
    {
        public int edisi { get; set; }

        public Majalah(string judul, int tahun, int edisi) : base(judul, tahun)
        {
            this.edisi = edisi;
        }

        public override void Deskripsi()
        {
            Console.WriteLine($"[Majalah] Ini adalah sebuah majalah edisi {edisi}.");
        }

        public void InfoEdisi()
        {
            Console.WriteLine($"Info Edisi: Majalah ini adalah edisi ke-{edisi}");
        }
    }
}
