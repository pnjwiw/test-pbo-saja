using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Item
    {
        public string judul { get; set; }
        public int tahun { get; set; }

        public Item(string judul, int tahun)
        {
            this.judul = judul;
            this.tahun = tahun;
        }

        public virtual void Deskripsi()
        {
            Console.WriteLine("Ini adalah sebuah item di perpustakaan.");
        }

        public void InfoItem()
        {
            Console.WriteLine($"Judul: {judul}, Tahun Rilis: {tahun}");
        }
    }
}
