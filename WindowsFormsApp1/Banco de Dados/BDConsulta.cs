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
        public List<String> retornarListaNomeMedicos()
        {      
         
            conexao.ObjetoConexao.Open();
            MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM medico;", conexao.ObjetoConexao);
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
                    consulta.IdMedico = Convert.ToInt32(GetColumnValueAsString(dados, "idMedico"));
                    consulta.IdPaciente = Convert.ToInt32(GetColumnValueAsString(dados, "idPaciente"));
                    consulta.NomePaciente = GetString(dados, "nomePaciente");
                    consulta.HoraInicio = GetString(dados, "horaInicio");
                    consulta.HoraFim = GetString(dados, "horaFim");
                    consulta.Data = GetString(dados, "data");
                    consulta.NomeMedico = GetString(dados, "nomeMedico");
                    consulta.ValorConsulta = Convert.ToInt32(GetColumnValueAsString(dados, "valorConsulta"));

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

            objetoComando.Parameters.Add("@nomePaciente", MySqlDbType.VarChar).Value = consulta.NomePaciente;
            objetoComando.Parameters.Add("@valorConsulta", MySqlDbType.Int32).Value = consulta.ValorConsulta;
            objetoComando.Parameters.Add("@data", MySqlDbType.VarChar).Value = consulta.Data;
            objetoComando.Parameters.Add("@horaInicio", MySqlDbType.VarChar).Value = consulta.HoraInicio;
            objetoComando.Parameters.Add("@horaFim", MySqlDbType.VarChar).Value = consulta.HoraFim;
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
