using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714220068
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeMenuItem_DoubleClick(object sender, EventArgs e)
        {
            // Tambahkan kode yang ingin Anda jalankan ketika menu "Cascade" di-double click di sini
            // Contoh: 
            // Membuka atau mengatur jendela anak dalam tata letak bertumpuk
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void TileMenuItem_DoubleClick(object sender, EventArgs e)
        {
            // Tambahkan kode yang ingin Anda jalankan ketika menu "Tile" di-double click di sini
    // Contoh:
    // Mengatur jendela anak dalam tata letak tile
    LayoutMdi(MdiLayout.TileHorizontal); // TileHorizontal akan mengatur jendela anak secara horizontal
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}