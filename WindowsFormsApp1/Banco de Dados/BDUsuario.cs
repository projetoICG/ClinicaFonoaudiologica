using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.objetos;

namespace WindowsFormsApp1.Banco_de_Dados
{
    class BDUsuario
    {
        private ConexaoBanco conexaobanco;
        public BDUsuario()
        {
            conexaobanco = new ConexaoBanco();
        }

        public void prepararCadastrarUsuario(Usuario usuario, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@funcao", MySqlDbType.VarChar).Value = usuario.Funcao;
            objetoComando.Parameters.Add("@login", MySqlDbType.VarChar).Value = usuario.Login;
            objetoComando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
            objetoComando.Parameters.Add("@dicaSenha", MySqlDbType.VarChar).Value = usuario.DicaSenha;
            objetoComando.Parameters.Add("@emailRecuperacao", MySqlDbType.VarChar).Value = usuario.EmailRecuperacao;
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
        }

        public Usuario procurarUsuario(string login, string senha)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM usuario " +
                    "where login like \""+login+"\" and senha like \""+senha+"\";", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();


                Usuario usuario = new Usuario();

                
                while (dados.Read())
                {
                    usuario.Funcao = dados.GetString("funcao");
                    usuario.Id = dados.GetInt32("id");
                    usuario.Login = dados.GetString("login");
                    usuario.Senha = dados.GetString("senha");
                    usuario.DicaSenha = dados.GetString("dicaSenha");
                    usuario.EmailRecuperacao = dados.GetString("emailRecuperacao");
                    usuario.Nome = dados.GetString("nome");
                }

                conexao.ObjetoConexao.Close();
                return usuario;
            }
            catch (MySqlException x)
            {
                return null;
            }
            return null;
        }

        /*
        public int cadastrarMedico(Medico medico)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("insert into " +
                    "medico (cpf, rg, nome, sexo, " +
                    "rua, bairro, numero, complemento, telefone1, telefone2, " +
                    "email, dataNascimento, conselho, numeroConselho, funcao, formacao) values (? , ? , ?, " +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conexao.ObjetoConexao);

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
        */
    }
}
