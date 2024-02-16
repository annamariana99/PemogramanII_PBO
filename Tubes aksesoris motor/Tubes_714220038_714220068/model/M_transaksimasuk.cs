using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_714220038_714220068.model
{
    internal class M_transaksimasuk
    {
        string perusahaan, jumlah_sparepart, harga_pembelian, tanggal;

        public M_transaksimasuk()
        {

        }

        public M_transaksimasuk(string perusahaan, string jumlah_sparepart, string harga_pembelian, string tanggal)
        {
            this.Perusahaan = perusahaan;
            this.Jumlah_sparepart = jumlah_sparepart;
            this.Harga_pembelian = harga_pembelian;
            this.Tanggal = tanggal;
        }

        public string Perusahaan { get => perusahaan; set => perusahaan = value; }
        public string Jumlah_sparepart { get => jumlah_sparepart; set => jumlah_sparepart = value; }
        public string Harga_pembelian { get => harga_pembelian; set => harga_pembelian = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
