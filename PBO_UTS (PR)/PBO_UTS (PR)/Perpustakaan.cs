using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS__PR_
{
    public class Perpustakaan
    {
        public List<Item> daftarItem = new List<Item>();

        public void TambahItem(Item item)
        {
            daftarItem.Add(item);
        }

        public void DaftarItem()
        {
            Console.WriteLine("=== DAFTAR ITEM DI PERPUSTAKAAN ===");
            foreach (var item in daftarItem)
            {
                item.InfoItem();
                item.Deskripsi();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
