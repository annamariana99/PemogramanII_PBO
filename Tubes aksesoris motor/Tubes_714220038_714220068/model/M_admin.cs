using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_714220038_714220068.model
{
    internal class M_admin
    {
        string nama, username, password;
        public M_admin()
        {

        }

        public M_admin(string nama, string username, string password)
        {
            this.Nama = nama;
            this.Username = username;
            this.Password = password;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
