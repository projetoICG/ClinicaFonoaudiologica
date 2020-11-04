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
            objetoComando.Parameters.Add("@id_paciente",MySqlDbType.Int32).Value = 1 ; //controlador
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = paciente.Cpf;
        }
        public int cadastrarPacienteMaiorDeIdade(Paciente paciente)
        {
            conexaobanco.abrirConexao();

            MySqlCommand objetoComando = new MySqlCommand("insert into" +
                "paciente_maior_idade (cpf, rg, id_paciente, nome, sexo, " +
                "rua, bairro, numero, complemento, telefone1, telefone2, " +
                "email, dataNascimento, observacoes) values (? , ? , ?, " +
                "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conexaobanco.ObjetoConexao);

            prepararCadastrarPacienteMaiorDeIdade(paciente, objetoComando);

            conexaobanco.fecharConexao();

            return 0;
        }
            


    }
}
