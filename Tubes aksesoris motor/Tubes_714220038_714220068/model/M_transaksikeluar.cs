using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_714220038_714220068.model
{
    internal class M_transaksikeluar
    {
        string nama_konsumen, nama_sparepart, jumlah_sparepart, harga_jual, tanggal;

        public M_transaksikeluar()
        {

        }

        public M_transaksikeluar(string nama_konsumen, string nama_obat, string jumlah_obat, string harga_jual, string tanggal)
        {
            this.Nama_konsumen = nama_konsumen;
            this.nama_sparepart = nama_sparepart;
            this.Jumlah_sparepart = jumlah_sparepart;
            this.Harga_jual = harga_jual;
            this.Tanggal = tanggal;
        }

        public string Nama_konsumen { get => nama_konsumen; set => nama_konsumen = value; }
        public string Nama_sparepart { get => nama_sparepart; set => nama_sparepart = value; }
        public string Jumlah_sparepart { get => jumlah_sparepart; set => jumlah_sparepart = value; }
        public string Harga_jual { get => harga_jual; set => harga_jual = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}

