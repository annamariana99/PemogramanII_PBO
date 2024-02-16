using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_714220038_714220068.model
{
    internal class M_sparepart
    {
        string kode_barang, nama_barang, harga, stok;

        public M_sparepart()
        {

        }

        public M_sparepart(string kode_barang, string nama_barang, string harga, string stok)
        {
            this.Kode_barang = kode_barang;
            this.Nama_barang = nama_barang;
            this.Harga = harga;
            this.Stok = stok;
        }
        public string Kode_barang { get => kode_barang; set => kode_barang = value; }
        public string Nama_barang { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Stok { get => stok; set => stok = value; }
    }
}
