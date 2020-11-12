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

namespace WindowsFormsApp1
{

    public partial class CadastrarPaciente : Form
    {
        public void habilitarMenor(bool decisao)
        {
            campoCPFMae.Enabled = decisao;
            campoNomeMae.Enabled = decisao;
            campoRGMae.Enabled = decisao;
            labelNomeMae.Enabled = decisao;
            labelCPFMae.Enabled = decisao;
            labelRGMae.Enabled = decisao;

            campoCPFPai.Enabled = decisao;
            campoNomePai.Enabled = decisao;
            campoRGPai.Enabled = decisao;
            labelNomePai.Enabled = decisao;
            labelCPFPai.Enabled = decisao;
            labelRGPai.Enabled = decisao;

            campoCPFParente.Enabled = decisao;
            campoNomeParente.Enabled = decisao;
            campoRGParente.Enabled = decisao;
            labelNomeParente.Enabled = decisao;
            labelCPFParente.Enabled = decisao;
            labelRGParente.Enabled = decisao;
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
            catch {
                return 0;
            }
        }

        public CadastrarPaciente()
        {
            InitializeComponent();
            this.CenterToScreen();
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
                if (idade < 18)
                {
                    habilitarMenor(true);
                } else
                {
                    habilitarMenor(false);
                }

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



        }
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            if (int.Parse(campoIdade.Text) < 18)
            {
                //Cadastrando Paciente Menor idade
                try
                {
                    PacienteMenor menor = new PacienteMenor();
                    menor.Cpf = campoCPF.Text;
                    menor.Nome = campoNome.Text;
                    if (radioBotaoFeminino.Checked)
                        menor.Sexo = 'F';
                    else
                        menor.Sexo = 'M';
                    menor.Rg = campoRG.Text;
                    menor.Rua = campoRua.Text;
                    menor.Bairro = campoBairro.Text;
                    menor.Numero = campoNumero.Text;
                    menor.Complemento = campoComplemento.Text;
                    menor.Telefone1 = campoTelefone1.Text;
                    menor.Telefone2 = campoTelefone2.Text;
                    menor.Email = campoEmail.Text;
                    menor.DataNascimento = campoDataNascimento.Text;
                    menor.Observacoes = campoObservacao.Text;
                    menor.NomeMae = campoNomeMae.Text;
                    menor.NomePai = campoNomePai.Text;
                    menor.NomeParente = campoNomeParente.Text;
                    menor.CpfMae = campoCPFMae.Text;
                    menor.CpfPai = campoCPFPai.Text;
                    menor.CpfParente = campoCPFParente.Text;
                    BDPaciente bdPaciente = new BDPaciente();
                    bdPaciente.cadastrarPacienteMenorDeIdade(menor);

                    MessageBox.Show("Cadastrado com Sucesso !");
                }
                catch
                {
                    //DEU MERDA NA HORA DE CADASTRAR MENOR DE IDADE
                }
            } 
            else
            {
                //Cadastrando Paciente Maior Idade
                try
                {
                    Paciente maior = new Paciente();

                    maior.Cpf = campoCPF.Text;
                    maior.Nome = campoNome.Text;
                    if (radioBotaoFeminino.Checked)
                        maior.Sexo = 'F';
                    else
                        maior.Sexo = 'M';
                    maior.Rua = campoRua.Text;
                    maior.Rg = campoRG.Text;
                    maior.Bairro = campoBairro.Text;
                    maior.Numero = campoNumero.Text;
                    maior.Complemento = campoComplemento.Text;
                    maior.Telefone1 = campoTelefone1.Text;
                    maior.Telefone2 = campoTelefone2.Text;
                    maior.Email = campoEmail.Text;
                    maior.DataNascimento = campoDataNascimento.Text;
                    maior.Observacoes = campoObservacao.Text;

                    BDPaciente bdPaciente = new BDPaciente();
                    bdPaciente.cadastrarPacienteMaiorDeIdade(maior);

                    MessageBox.Show("Cadastrado com Sucesso !");
                }
                catch
                {
                    //DEU MERDA NA HORA DE INSERIR MAIOR DE IDADE
                }

                
            }
        }
               
        private void CadastrarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Cancelar ?","Aviso",MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                e.Cancel = false;
            else if (confirm == DialogResult.No)
                e.Cancel = true;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}