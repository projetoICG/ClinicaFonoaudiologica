using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class ConexaoBanco
    {
        private MySqlConnection objetoConexao = new MySqlConnection();
        public MySqlConnection ObjetoConexao { get => objetoConexao; set => objetoConexao = value; }
        
        
        public ConexaoBanco()
        {
            ObjetoConexao.ConnectionString = "server=localhost;port=3306;User Id=root;database=clinicafono;password=123456";
        }


        public MySqlConnection abrirConexao()
        {
            ObjetoConexao.Open();
            return ObjetoConexao;
        }

        public void fecharConexao()
        {
            ObjetoConexao.Close();
        }

        public MySqlCommand PacienteMaiorIdade()
        {
            
            
           

            return objetoComando;
        }


    }
}
