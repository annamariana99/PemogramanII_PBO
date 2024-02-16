using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_1_714220068.model
{
    internal class M_mahasiswa
    {
        internal string noHP;
        string npm, nama, angkatan, alamat, email, Nohp;

        public M_mahasiswa()
        {

        }

        public string Npm { get; internal set; }
        public string Nama { get; internal set; }
        public string Angkatan { get; internal set; }
        public string Email { get; internal set; }
        public string Alamat { get; internal set; }
    }
}
