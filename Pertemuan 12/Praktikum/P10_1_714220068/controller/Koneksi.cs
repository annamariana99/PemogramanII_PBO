﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_1_714220068
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Database=ulbi;Uid=root;Pwd=;";
        MySqlConnection kon;

        public void OpenConnecttion()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }

        internal void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
