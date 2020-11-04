using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.objetos;

namespace WindowsFormsApp1.Banco_de_Dados
{
    class BDPaciente
    {
        private ConexaoBanco conexaobanco;

        public void ConexaoBanco()
        {
            conexaobanco = new ConexaoBanco();
        }

        public void prepararCadastrarPacienteMaiorDeIdade(Paciente paciente, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = paciente.Cpf;
            objetoComando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = paciente.Rg;
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = paciente.Nome;
            objetoComando.Parameters.Add("@sexo", MySqlDbType.Binary).Value = paciente.Sexo;
            objetoComando.Parameters.Add("@rua", MySqlDbType.VarChar).Value = paciente.Rua;
            objetoComando.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = paciente.Bairro;
            objetoComando.Parameters.Add("@numero", MySqlDbType.VarChar).Value = paciente.Numero;
            objetoComando.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = paciente.Complemento;
            objetoComando.Parameters.Add("@telefone1", MySqlDbType.VarChar).Value = paciente.Telefone1;
            objetoComando.Parameters.Add("@telefone2", MySqlDbType.VarChar).Value = paciente.Telefone2;
            objetoComando.Parameters.Add("@email", MySqlDbType.VarChar).Value = paciente.Email;
            objetoComando.Parameters.Add("@dataNascimento", MySqlDbType.VarChar).Value = paciente.DataNascimento;
            objetoComando.Parameters.Add("@observacoes", MySqlDbType.VarChar).Value = paciente.Observacoes;
        }

        public int cadastrarPacienteMaiorDeIdade(Paciente paciente)
        {

            try
            {
                conexaobanco.abrirConexao();

                MySqlCommand objetoComando = new MySqlCommand("insert into" +
                    "paciente_maior_idade (cpf, rg, nome, sexo, " +
                    "rua, bairro, numero, complemento, telefone1, telefone2, " +
                    "email, dataNascimento, observacoes) values (? , ? , ?, " +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conexaobanco.ObjetoConexao);

                prepararCadastrarPacienteMaiorDeIdade(paciente, objetoComando);

                conexaobanco.fecharConexao();
            return 0;
            }
            catch
            {
                Console.WriteLine("Deu merda na hora de inserir paciente maior de idade");
            }
            return 1;
        }
            


    }
}
