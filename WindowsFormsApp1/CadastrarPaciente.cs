using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    

    public partial class CadastrarPaciente : Form
    {
        public int retornarIdade(string idadeSemFormatar)
        {
            int ano, mes, dia;

            try
            {
                string[] att = idadeSemFormatar.Split('/');
                dia = Convert.ToInt32(att[0]);
                mes = Convert.ToInt32(att[1]);
                ano = Convert.ToInt32(att[2]);

                DateTime birthDate = new DateTime(ano, mes, dia);
                DateTime now = DateTime.Today;

                int age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                    age--;
                return age;
            }
            catch {
                return 0;
            }
        }

        public CadastrarPaciente()
        {
            InitializeComponent();
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private void CadastrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Por favor digite apenas números");
            //    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            //}
            //if (campoCPF.Text.Length == 11)
            //{
                //long CPF = Convert.ToInt64(textBox2.Text);
                //string CPFFormatado = String.Format(@"{0:\000\.000\.000\-00}", CPF);
                //textBox2.Text = CPFFormatado;
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
         
        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void somenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campoDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (campoDataNascimento.MaskCompleted)
            {
                int idade = retornarIdade(campoDataNascimento.Text);
                if (idade != 0)
                {
                    campoIdade.Text = Convert.ToString(idade);
                }
                else
                {
                    campoIdade.Text = "7";
                }
            }
                else
            {
                campoIdade.Text = "";
            } 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void campoDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
