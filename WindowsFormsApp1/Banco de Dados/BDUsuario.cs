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


        public List<Usuario> buscarEspecificacaoUsuario(string coluna, string busca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM usuario " +
                    "where " + coluna + " like \"%" + busca + "%\";", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Usuario> usuarios = new List<Usuario>();

                while (dados.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(GetColumnValueAsString(dados, "id")); ;
                    usuario.Funcao = GetString(dados, "funcao");
                    usuario.Login = GetString(dados, "login");
                    usuario.Senha = GetString(dados, "senha");
                    usuario.DicaSenha = GetString(dados, "dicaSenha");
                    usuario.EmailRecuperacao = GetString(dados, "emailRecuperacao");
                    usuario.Nome = GetString(dados, "nome");
                    usuarios.Add(usuario);
                }

                conexao.ObjetoConexao.Close();
                return usuarios;
            }
            catch (MySqlException x)
            {
                return null;
            }
            return null;
        }

        public static string GetString(MySqlDataReader reader, string colName)
        {
            if (reader[colName] == DBNull.Value)
                return string.Empty;
            else
                return (string)reader[colName];
        }

        public static string GetColumnValueAsString(MySqlDataReader reader, string colName)
        {
            if (reader[colName] == DBNull.Value)
                return string.Empty;
            else
                return reader[colName].ToString();
        }


        public List<Usuario> retornarListaUsuarios()
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM usuario;", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();

                while (dados.Read())
                {

                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(GetColumnValueAsString(dados, "id")); ;
                    usuario.Funcao = GetString(dados, "funcao");
                    usuario.Login = GetString(dados, "login");
                    usuario.Senha = GetString(dados, "senha");
                    usuario.DicaSenha = GetString(dados, "dicaSenha");
                    usuario.EmailRecuperacao = GetString(dados, "emailRecuperacao");
                    usuario.Nome = GetString(dados, "nome");

                    lista.Add(usuario);
                }

                conexao.ObjetoConexao.Close();

                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        public void excluirUsuario(int id)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("delete FROM usuario where id = " + Convert.ToString(id) + ";", conexao.ObjetoConexao);
                objetoComando.ExecuteReader();
                conexao.ObjetoConexao.Close();
            }
            catch
            {

            }
        }

        public int cadastrarUsuario(Usuario usuario)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("insert into " +
                    "usuario (funcao, login, senha, dicaSenha, emailRecuperacao, nome) values (?, ?, ?, ?, ?, ?);", conexao.ObjetoConexao);

                prepararCadastrarUsuario(usuario, objetoComando);

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

        public void atualizarUsuario(Usuario usuarioAtualizado)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();

                MySqlCommand objetoComando = new MySqlCommand("update usuario set funcao=?, login=?, senha=?, dicaSenha=?, " +
                    "emailRecuperacao=?, nome=? where id=?;", conexao.ObjetoConexao);

                prepararCadastrarUsuario(usuarioAtualizado, objetoComando);
                objetoComando.Parameters.Add("@id_usuario", MySqlDbType.Int32).Value = usuarioAtualizado.Id;

                objetoComando.ExecuteReader();

                conexao.ObjetoConexao.Close();
            }
            catch (MySqlException l)
            {
                Console.WriteLine(l);
            }

        }
    }
}
