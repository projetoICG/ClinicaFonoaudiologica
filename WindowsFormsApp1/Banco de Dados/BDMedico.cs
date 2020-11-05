using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.objetos;

namespace WindowsFormsApp1.Banco_de_Dados
{
    class BDMedico
    {
        private ConexaoBanco conexaobanco;
        public BDMedico()
        {
            conexaobanco = new ConexaoBanco();
        }

        public void prepararCadastrarMedico(Medico medico, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = medico.Cpf;
            objetoComando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = medico.Rg;
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = medico.Nome;
            objetoComando.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = medico.Sexo;
            objetoComando.Parameters.Add("@rua", MySqlDbType.VarChar).Value = medico.Rua;
            objetoComando.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = medico.Bairro;
            objetoComando.Parameters.Add("@numero", MySqlDbType.VarChar).Value = medico.Numero;
            objetoComando.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = medico.Complemento;
            objetoComando.Parameters.Add("@telefone1", MySqlDbType.VarChar).Value = medico.Telefone1;
            objetoComando.Parameters.Add("@telefone2", MySqlDbType.VarChar).Value = medico.Telefone2;
            objetoComando.Parameters.Add("@email", MySqlDbType.VarChar).Value = medico.Email;
            objetoComando.Parameters.Add("@dataNascimento", MySqlDbType.VarChar).Value = medico.DataNascimento;
            objetoComando.Parameters.Add("@crm", MySqlDbType.VarChar).Value = medico.Crm;
            objetoComando.Parameters.Add("@formacao", MySqlDbType.VarChar).Value = medico.Formacao;
        }

        public int cadastrarMedico(Medico medico)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("insert into " +
                    "medico (cpf, rg, nome, sexo, " +
                    "rua, bairro, numero, complemento, telefone1, telefone2, " +
                    "email, dataNascimento, crm, formacao) values (? , ? , ?, " +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conexao.ObjetoConexao);

                prepararCadastrarMedico(medico, objetoComando);

                objetoComando.ExecuteNonQuery();

                conexao.ObjetoConexao.Close();
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 1;
        }

    }
}
