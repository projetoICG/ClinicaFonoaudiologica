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
    class BDConsulta
    {
        private ConexaoBanco conexao;
        public BDConsulta()
        {
            conexao = new ConexaoBanco();
        }
        public List<String> retornarListaNomeConsultas()
        {      
         
            conexao.ObjetoConexao.Open();
            MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM consulta;", conexao.ObjetoConexao);
            MySqlDataReader dados = objetoComando.ExecuteReader();

            List<String> lista = new List<String>();

            while (dados.Read())           
                lista.Add(dados.GetString("nome"));            

            return lista;
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


        public List<Consulta> retornarListaConsulta(){

            try
            {          
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM consulta;", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Consulta> lista = new List<Consulta>();

                while (dados.Read())
                {

                    Consulta consulta = new Consulta();
                    consulta.IdConsulta = Convert.ToInt32(GetColumnValueAsString(dados, "idConsulta"));
                    consulta.IdConsulta = Convert.ToInt32(GetColumnValueAsString(dados, "idConsulta"));
                    consulta.IdPaciente = Convert.ToInt32(GetColumnValueAsString(dados, "idPaciente"));
                    consulta.NomePaciente = GetString(dados, "nomePaciente");
                    consulta.HoraInicio = GetString(dados, "horaInicio");
                    consulta.HoraFim = GetString(dados, "horaFim");
                    consulta.Data = GetString(dados, "data");
                    consulta.ValorConsulta = float.Parse(GetColumnValueAsString(dados, "valorConsulta"));
                    consulta.NomeMedico = GetString(dados, "nomeMedico");

                    lista.Add(consulta);
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

        public void prepararCadastrarConsulta(Consulta consulta, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@idMedico", MySqlDbType.Int32).Value = consulta.IdMedico;
            objetoComando.Parameters.Add("@idPaciente", MySqlDbType.Int32).Value = consulta.IdPaciente;
            objetoComando.Parameters.Add("@nomePaciente", MySqlDbType.VarChar).Value = consulta.NomePaciente;
            objetoComando.Parameters.Add("@horaInicio", MySqlDbType.VarChar).Value = consulta.HoraInicio;
            objetoComando.Parameters.Add("@nomeFim", MySqlDbType.VarChar).Value = consulta.HoraFim;
            objetoComando.Parameters.Add("@data", MySqlDbType.VarChar).Value = consulta.Data;
            objetoComando.Parameters.Add("@nomeMedico", MySqlDbType.VarChar).Value = consulta.NomeMedico;
            objetoComando.Parameters.Add("@valorConsulta", MySqlDbType.Float).Value = consulta.ValorConsulta;
        }

        public int cadastrarConsulta(Consulta consulta)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                Console.WriteLine(consulta.NomeMedico);
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("insert into consulta (idMedico, idPaciente, nomePaciente, " +
                    "horaInicio, horaFim, data, nomeMedico, valorConsulta) " +
                    "values (?, ?, ?, ?, ?, ?, ?, ?);", conexao.ObjetoConexao);

                prepararCadastrarConsulta(consulta, objetoComando);

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

        public void atualizarConsulta(Consulta consultaAtualizada)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();

                MySqlCommand objetoComando = new MySqlCommand("update consulta set nomePaciente=?, "+
                    "valorConsulta=?, data=?, horaInicio=?, horaFim=?"+
                    " where idConsulta=?;", conexao.ObjetoConexao);

                prepararCadastrarConsulta(consultaAtualizada, objetoComando);
                objetoComando.Parameters.Add("@idConsulta", MySqlDbType.Int32).Value = consultaAtualizada.IdConsulta;

                objetoComando.ExecuteReader();

                conexao.ObjetoConexao.Close();
            }
            catch (MySqlException l)
            {
                Console.WriteLine(l);
            }

        }



        public void excluirConsulta(int id)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("delete FROM consulta where idConsulta = " + Convert.ToString(id) + ";", conexao.ObjetoConexao);
                objetoComando.ExecuteReader();
                conexao.ObjetoConexao.Close();
            }
            catch
            {

            }
        }

    }
}
