﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Banco_de_Dados;
using WindowsFormsApp1.objetos;
using WindowsFormsApp1.view.Medico;

namespace WindowsFormsApp1
{
    

    public partial class CadastrarMedico : Form
    {
        public CadastrarMedico()
        {

            InitializeComponent();
            this.CenterToScreen();
            this.BringToFront();
            this.Focus();
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }
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
            catch
            {
                return 0;
            }
        }



        private void CadastrarMedico_Load(object sender, EventArgs e)
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
                    campoIdade.Text = "";
                }
            }
            else
            {
                campoIdade.Text = "";
            }

        }

        private void cadastrarMedico()
        {
            try
            {
                Medico medico = new Medico();
                medico.Cpf = campoCPF.Text;
                medico.Nome = campoNome.Text;
                if (radioBotaoFeminino.Checked)
                    medico.Sexo = 'F';
                else
                    medico.Sexo = 'M';
                medico.Rg = campoRG.Text;
                medico.Rua = campoRua.Text;
                medico.Bairro = campoBairro.Text;
                medico.Numero = campoNumero.Text;
                medico.Complemento = campoComplemento.Text;
                medico.Telefone1 = campoTelefone1.Text;
                medico.Telefone2 = campoTelefone2.Text;
                medico.Email = campoEmail.Text;
                medico.DataNascimento = campoDataNascimento.Text;
                medico.Conselho = comboConselho.Text;
                medico.Formacao = campoFormacao.Text;
                medico.NConselho = campoNConselho.Text;
                medico.Funcao = comboFuncao.Text;

                BDMedico bdMedico = new BDMedico();
                bdMedico.cadastrarMedico(medico);

                MessageBox.Show("Cadastrado com Sucesso !");
               
            }
            catch
            {
                ///DEU MERDA NA HORA DE CADASTRAR O MEDICO!!!
            }
        }
        private void limparDados()
        {           
                campoNome.Clear();
                campoCPF.Clear();
                campoRG.Clear();
                campoRua.Clear();
                campoBairro.Clear();
                campoComplemento.Clear();
                campoNumero.Clear();
                campoDataNascimento.Clear();
                campoEmail.Clear();
                campoNConselho.Clear();
                campoFormacao.Clear();
                campoTelefone1.Clear();
                campoTelefone2.Clear();
                radioBotaoFeminino.Checked = false;
                radioBotaoMasculino.Checked = false;
                comboFuncao.SelectedIndex = 0;
                comboConselho.SelectedIndex = 0;
                campoNConselho.Clear();
            
        }
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarMedico();


            if (MessageBox.Show("Deseja Cadastrar outro médico?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                limparDados();
            else
                this.Close();

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Cancelar ?", "Aviso", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                this.Close();
            //else if (confirm == DialogResult.No)
            //    e.Cancel = true;
        }

        private void comboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoNConselho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboConselho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoFormacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void campoTelefone1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void campoTelefone2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void campoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void campoRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void campoRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void campoIdade_Click(object sender, EventArgs e)
        {

        }

        private void campoBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBotaoFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
