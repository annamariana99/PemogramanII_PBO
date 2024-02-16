using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_714220038_714220068.model
{
    internal class M_supplier
    {
        string nama_perusahaan,nama_sparepart, nomor_telepon, alamat, email;

        public M_supplier()
        {

        }

        public M_supplier(string nama_perusahaan, string nama_sparepart, string nomor_telepon, string alamat, string email)
        {
            this.Nama_perusahaan = nama_perusahaan;
            this.Nama_sparepart = nama_sparepart;
            this.Nomor_telepon = nomor_telepon;
            this.Alamat = alamat;
            this.Email = email;
        }

        public string Nama_perusahaan { get => nama_perusahaan; set => nama_perusahaan = value; }
        public string Nama_sparepart { get => nama_sparepart; set => nama_sparepart = value; }
        public string Nomor_telepon { get => nomor_telepon; set => nomor_telepon = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
    }
}