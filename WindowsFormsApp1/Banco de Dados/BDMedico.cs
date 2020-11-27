using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            objetoComando.Parameters.Add("@conselho", MySqlDbType.VarChar).Value = medico.Conselho;
            objetoComando.Parameters.Add("@numeroConselho", MySqlDbType.VarChar).Value = medico.NConselho;
            objetoComando.Parameters.Add("@funcao", MySqlDbType.VarChar).Value = medico.Funcao;
            objetoComando.Parameters.Add("@formacao", MySqlDbType.VarChar).Value = medico.Formacao;
        }

        public List<Medico> buscarEspecificacaoMedico(string coluna, string busca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando;
                if (coluna == "id_medico")
                {
                    objetoComando = new MySqlCommand("SELECT * FROM medico " +
                        "where " + coluna + " = " + Convert.ToInt32(busca) + ";", conexao.ObjetoConexao);
                }
                else
                {
                     objetoComando = new MySqlCommand("SELECT * FROM medico " +
                        "where " + coluna + " like \"%" + busca + "%\";", conexao.ObjetoConexao);
                }
                MySqlDataReader dados = objetoComando.ExecuteReader();
                
                List<Medico> medicos = new List<Medico>();

                while (dados.Read())
                {
                    Medico medico = new Medico();
                    medico.Cpf = GetString(dados, "cpf");
                    medico.Rg = GetString(dados, "rg");
                    medico.Id = Convert.ToInt32(GetColumnValueAsString(dados, "id_medico"));
                    medico.Nome = GetString(dados, "nome");
                    medico.Sexo = Convert.ToChar(GetString(dados, "sexo"));
                    medico.Rua = GetString(dados, "rua");
                    medico.Bairro = GetString(dados, "bairro");
                    medico.Numero = GetString(dados, "numero");
                    medico.Complemento = GetString(dados, "complemento");
                    medico.Telefone1 = GetString(dados, "telefone1");
                    medico.Telefone2 = GetString(dados, "telefone2");
                    medico.Email = GetString(dados, "email");
                    medico.DataNascimento = GetString(dados, "dataNascimento");
                    medico.Conselho = GetString(dados, "conselho");
                    medico.NumeroConselho = GetString(dados, "numeroConselho");
                    medico.Funcao = GetString(dados, "funcao");
                    medico.Formacao = GetString(dados, "formacao");
                    medicos.Add(medico);
                }

                conexao.ObjetoConexao.Close();
                return medicos;
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


        public List<Medico> retornarListaMedicos()
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM medico;",conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Medico> lista = new List<Medico>();
                
                while (dados.Read())
                {

                    Medico medico = new Medico();
                    medico.Cpf = GetString(dados,"cpf");
                    medico.Rg = GetString(dados,"rg");
                    medico.Id = Convert.ToInt32(GetColumnValueAsString(dados,"id_medico"));
                    medico.Nome = GetString(dados,"nome");
                    medico.Sexo = Convert.ToChar(GetString(dados,"sexo"));
                    medico.Rua = GetString(dados,"rua");
                    medico.Bairro = GetString(dados,"bairro");
                    medico.Numero = GetString(dados,"numero");
                    medico.Complemento = GetString(dados,"complemento");
                    medico.Telefone1 = GetString(dados,"telefone1");
                    medico.Telefone2 = GetString(dados,"telefone2");
                    medico.Email = GetString(dados,"email");
                    medico.DataNascimento = GetString(dados,"dataNascimento");
                    medico.Conselho = GetString(dados,"conselho");
                    medico.NumeroConselho = GetString(dados,"numeroConselho");
                    medico.Funcao = GetString(dados,"funcao");
                    medico.Formacao = GetString(dados,"formacao");
                    
                    lista.Add(medico);
                }
                
                conexao.ObjetoConexao.Close();
                
                return lista;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
                return null;
        }

        public void excluirMedico(int id)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("delete FROM medico where id_medico = "+Convert.ToString(id)+";", conexao.ObjetoConexao);
                objetoComando.ExecuteReader();
                conexao.ObjetoConexao.Close();
            }
            catch
            {

            }
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

        public void atualizarMedico(Medico medicoAtualizado)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();

                MySqlCommand objetoComando = new MySqlCommand("update medico set cpf=?, rg=?, nome=?,sexo=?," +
                    " rua=?, bairro=?, numero=?, complemento=?, telefone1=?, telefone2=?," +
                    " email=?, dataNascimento=?, conselho=?, numeroConselho=?, funcao=?, formacao=?" +
                    " where id_medico=?;", conexao.ObjetoConexao);

                prepararCadastrarMedico(medicoAtualizado, objetoComando);
                objetoComando.Parameters.Add("@id_medico", MySqlDbType.Int32).Value = medicoAtualizado.Id;

                objetoComando.ExecuteReader();

                conexao.ObjetoConexao.Close();
            }
            catch(MySqlException l)
            {
                Console.WriteLine(l);
            }
           
        }


    }
}
