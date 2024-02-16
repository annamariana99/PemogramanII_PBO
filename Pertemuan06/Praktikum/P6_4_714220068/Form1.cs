using System;
using System.Windows.Forms;

namespace P6_4_714220068
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbjenis.Text == "PAKAIAN")
            {
                txtharga.Text = "7000";
            }
            else if (cbjenis.Text == "KARPET")
            {
                txtharga.Text = "1000";
            }
            else if (cbjenis.Text == "SELIMUT")
            {
                txtharga.Text = "12000";
            }
            else if (cbjenis.Text == "BONEKA")
            {
                txtharga.Text = "8000";
            }
        }

        private void txtproses_Click(object sender, EventArgs e)
        {
            int a, b, c = 5000;
            int hasil;
            if (int.TryParse(txtberat.Text, out a) && int.TryParse(txtharga.Text, out b))
            {
                hasil = a * b;
                txttotal.Text = hasil.ToString();
                if (radioButton2.Checked)
                {
                    txttotal.Text = (hasil + c).ToString();
                }
            }
            else
            {
                // Handle parsing error here.
                // Misalnya menampilkan pesan error atau memberikan nilai default.
            }
        }
        private void btnhitung_Click(object sender, EventArgs e)
        {
            int p, q, kembalian;
            if (int.TryParse(txtuang.Text, out p) && int.TryParse(txttotal.Text, out q))
            {
                kembalian = p - q;
                txtkembali.Text = kembalian.ToString();
            }
            else
            {
                // Handle parsing error here.
                // Misalnya, menampilkan pesan kesalahan atau memberikan nilai default.
            }
        }

        private void txtreset_Click(object sender, EventArgs e)
        {
            txtnama.Text = "";
            txtberat.Text = "";
            txtharga.Text = "";
            txttotal.Text = "";
            txtuang.Text = "";
            txtkembali.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        