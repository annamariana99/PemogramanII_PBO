using System;
using System.Linq;
using System.Windows.Forms;

namespace P6_3_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbllNim_Leave(object sender, EventArgs e)
        {
            string inputText = lbllNim.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                epWarning.SetError(lbllNim, "Label huruf tidak boleh kosong!");
                epWrong.SetError(lbllNim, "");
                epCorrect.SetError(lbllNim, "");
            }
            else
            {
                if (inputText.All(char.IsLetter))
                {
                    epWarning.SetError(lbllNim, "");
                    epWrong.SetError(lbllNim, "");
                    epCorrect.SetError(lbllNim, "Benar!");
                }
                else
                {
                    epWrong.SetError(lbllNim, "Inputan hanya boleh huruf!");
                    epWarning.SetError(lbllNim, "");
                    epCorrect.SetError(lbllNim, "");
                }
            }
        }

        private void lbllNama_Leave(object sender, EventArgs e)
        {
            if (lbllNama.Text == "")
            {
                epCorrect.SetError(lbllNama, "");
                epWarning.SetError(lbllNama, "Label angka tidak boleh kosong!");
                epWrong.SetError(lbllNama, "");
            }
            else
            {
                if (lbllNama.Text.All(char.IsDigit))
                {
                    epCorrect.SetError(lbllNama, "Betul!");
                    epWarning.SetError(lbllNama, "");
                    epWrong.SetError(lbllNama, "");
                }
                else
                {
                    epCorrect.SetError(lbllNama, "");
                    epWarning.SetError(lbllNama, "");
                    epWrong.SetError(lbllNama, "Inputan hanya boleh angka!");
                }
            }
        }

        private void radioButtonLaki2_Leave(object sender, EventArgs e)
        {
            if (radioButtonLaki2.Checked)
            {
                epCorrect.SetError(radioButtonLaki2, "Betul!");
                epWarning.SetError(radioButtonLaki2, "");
                epWrong.SetError(radioButtonLaki2, "");
            }
        }

        private void radioButtonPerempuan_Leave(object sender, EventArgs e)
        {
            if (radioButtonPerempuan.Checked)
            {
                epCorrect.SetError(radioButtonPerempuan, "Betul!");
                epWarning.SetError(radioButtonPerempuan, "");
                epWrong.SetError(radioButtonPerempuan, "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
