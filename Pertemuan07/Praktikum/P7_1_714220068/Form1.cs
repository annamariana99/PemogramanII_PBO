using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size= new Size(459, 250);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(LblNim.Text))
            {
                errorMessage += "Nim belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(LblNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            else if (!Regex.IsMatch(LblProgramStudi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Program Studi harus berformat [Strata]-[Prodi]";
            }

            if (string.IsNullOrWhiteSpace(LblAlamat.Text))
            {
                errorMessage += "P belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(459, 500);
            }
            else
            {
                MessageBox.Show(
                     errorMessage,
                     "Informasi Data Submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                     );
            }
        }

        private void radioButtonKurkum2006_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurkum2006.Checked)
            {
                checkBoxFisika.Enabled = true; checkBoxFisika.Checked = true;
                checkBoxMatematika.Enabled = false; checkBoxMatematika.Checked = false;
                checkBoxPemograman1.Enabled = true; checkBoxPemograman1.Checked = false;
            }
        }

        private void radioButtonKurkum2013_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurkum2013.Checked)
            {
                checkBoxFisika.Enabled = false;
                checkBoxMatematika.Enabled = true;
                checkBoxPemograman1.Enabled = true;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //LblNama.Text = null;
            //LblProdi.Text = null;
            //LblKelas.Text = null;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(459, 250);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string pilihHari = "";
            string pilihKegiatan = "";

            if (radioButtonKurkum2006.Checked)
            {
                pilihHari = "Fisika";
                pilihKegiatan = GetSelectedActivities();
            }
            else if (radioButtonKurkum2013.Checked)
            {
                pilihHari = "Matematika";
                pilihKegiatan = GetSelectedActivities();
            }

            string errorMsg = ValidateInputs();

            if (string.IsNullOrEmpty(errorMsg))
            {
                string hasilPrint = $"Nama: {LblNama.Text}\nProdi: {LblNim.Text}\nKelas: {LblNama.Text}\nHari: {pilihHari}\nKegiatan: {pilihKegiatan}";

                MessageBox.Show(hasilPrint, "Cetak Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMsg, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetSelectedActivities()
        {
            List<string> selectedActivitiesList = new List<string>();

            if (checkBoxFisika.Checked)
            {
                selectedActivitiesList.Add(checkBoxFisika.Text);
            }
            if (checkBoxMatematika.Checked)
            {
                selectedActivitiesList.Add(checkBoxMatematika.Text);
            }
            if (checkBoxPemograman1.Checked)
            {
                selectedActivitiesList.Add(checkBoxPemograman1.Text);
            }

            return string.Join(", ", selectedActivitiesList);
        }

        private string ValidateInputs()
        {
            StringBuilder errorMsgBuilder = new StringBuilder();

            if (string.IsNullOrWhiteSpace(LblNim.Text))
            {
                errorMsgBuilder.AppendLine("Nim belum diisi");
            }
            if (string.IsNullOrWhiteSpace(LblNama.Text))
            {
                errorMsgBuilder.AppendLine("Nama belum diisi");
            }
            else if (!Regex.IsMatch(LblProgramStudi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMsgBuilder.AppendLine("Program Studi harus berformat [Strata]-[Prodi]");
            }
            if (string.IsNullOrWhiteSpace(LblAlamat.Text))
            {
                errorMsgBuilder.AppendLine("Alamat belum diisi");
            }

            return errorMsgBuilder.ToString().Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}