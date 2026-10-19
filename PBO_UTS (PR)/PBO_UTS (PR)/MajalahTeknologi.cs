using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class MajalahTeknologi : Majalah
    {
        public MajalahTeknologi(string judul, int tahun, int edisi) : base(judul, tahun, edisi) { }

        public override void Deskripsi()
        {
            Console.WriteLine("[Majalah Teknologi] Ini adalah majalah tentang perkembangan teknologi.");
        }

        public void TopikTeknologi()
        {
            Console.WriteLine("Topik edisi ini: Kecerdasan Buatan dan Robotika.");
        }
    }
}
