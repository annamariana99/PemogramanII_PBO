using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_714220038_714220068.model;
using Tubes_714220038_714220068.controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tubes_714220038_714220068.view
{
    public partial class FormSparepart : Form
    {
        Koneksi koneksi = new Koneksi();
        M_sparepart m_sprt = new M_sparepart();
        string id;
        public void Tampil()
        {
            //Query DB
            DataSparepart.DataSource = koneksi.ShowData("SELECT *FROM sparepart");

            //Mengubah Nama Kolom Tabel
            DataSparepart.Columns[0].HeaderText = "Kode Barang";
            DataSparepart.Columns[1].HeaderText = "Nama Barang";
            DataSparepart.Columns[2].HeaderText = "Harga";
            DataSparepart.Columns[3].HeaderText = "Stok";
        }
        public FormSparepart()
        {
            InitializeComponent();
        }

        private void FormSparepart_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (kode_barang.Text == "" || nama_barang.SelectedIndex == -1 ||harga.Text == "" || stok.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sparepart sprt = new Sparepart();
                m_sprt.Kode_barang = kode_barang.Text;
                m_sprt.Nama_barang = nama_barang.Text;
                m_sprt.Harga = harga.Text;
                m_sprt.Stok = stok.Text;

                sprt.Insert(m_sprt);

                kode_barang.Text = "";
                nama_barang.SelectedIndex = -1;
                harga.Text = "";
                stok.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (kode_barang.Text == "" || nama_barang.SelectedIndex == -1 || harga.Text == "" || stok.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sparepart sprt = new Sparepart();
                m_sprt.Kode_barang = kode_barang.Text;
                m_sprt.Nama_barang = nama_barang.Text;
                m_sprt.Harga = harga.Text;
                m_sprt.Stok = stok.Text;

                sprt.Update(m_sprt, id);

                kode_barang.Text = "";
                nama_barang.SelectedIndex = -1;
                harga.Text = "";
                stok.Text = "";

                Tampil();
            }
        }

        private void DataSparepart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataSparepart.Rows[e.RowIndex].Cells[0].Value.ToString();
            kode_barang.Text = DataSparepart.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_barang.Text = DataSparepart.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = DataSparepart.Rows[e.RowIndex].Cells[2].Value.ToString();
            stok.Text = DataSparepart.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            kode_barang.Text = "";
            nama_barang.SelectedIndex = -1;
            harga.Text = "";
            stok.Text = "";

            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Sparepart sprt = new Sparepart();
                sprt.Delete(id);

                kode_barang.Text = "";
                nama_barang.SelectedIndex = -1;
                harga.Text = "";
                stok.Text = "";

                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search data
            DataSparepart.DataSource = koneksi.ShowData("SELECT * FROM sparepart WHERE kode_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btMn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMx_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}