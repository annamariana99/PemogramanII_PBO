using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220068
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";

            if (rb_Android.Checked)
            {
                os = "Android";
            }
            else if (rb_iOS.Checked)
            {
                os = "iOS";
            }

            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text,
                "Informasi HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rb_iOS_CheckedChanged(object sender, EventArgs e)
        {
            // Anda bisa menambahkan fungsionalitas di sini jika diperlukan
        }
    }
}
