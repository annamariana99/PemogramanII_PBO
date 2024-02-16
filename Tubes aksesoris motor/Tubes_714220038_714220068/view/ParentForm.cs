using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_714220038_714220068.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKaryawan formKaryawan = new FormKaryawan();
            formKaryawan.MdiParent = this;
            formKaryawan.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKonsumen formKonsumen = new FormKonsumen();
            formKonsumen.MdiParent = this;
            formKonsumen.Show();
        }

        private void dataSparepartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSparepart formSparepart = new FormSparepart();
            formSparepart.MdiParent = this;
            formSparepart.Show();
            formSparepart.BringToFront();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.MdiParent = this;
            formSupplier.Show();
            formSupplier.BringToFront();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormPresensi formPresensi = new FormPresensi();
            formPresensi.MdiParent = this;
            formPresensi.Show();
            formPresensi.BringToFront();
        }

        private void transaksiMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiMasuk formtransaksimasuk = new FormTransaksiMasuk();
            formtransaksimasuk.MdiParent = this;
            formtransaksimasuk.Show();
            formtransaksimasuk.BringToFront();
        }

        private void transaksiKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiKeluar formtransaksikeluar = new FormTransaksiKeluar();
            formtransaksikeluar.MdiParent = this;
            formtransaksikeluar.Show();
            formtransaksikeluar.BringToFront();
        }
    }
}
