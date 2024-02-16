﻿using P10_1_714220068.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220068.controller
{
    internal class TransaksiBarang
    {
        Koneksi connect = new Koneksi();

        //Method insert
        public bool Insert(M_transaksi_barang trxbarang)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("INSERT INTO t_transaksi (id_barang, qty, total) VALUES('" + trxbarang.Id_barang + "', '" + trxbarang.Qty + "','" + trxbarang.Total + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        //Method update
        public bool Update(M_transaksi_barang trxbarang, string id)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("UPDATE t_transaksi SET id_barang='" + trxbarang.Id_barang + "'," + "qty='" + trxbarang.Qty + "'," + "total='" + trxbarang.Total + "' WHERE id_transaksi='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("DELETE FROM t_transaksi WHERE id_transaksi = '" + id + "'");

                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}