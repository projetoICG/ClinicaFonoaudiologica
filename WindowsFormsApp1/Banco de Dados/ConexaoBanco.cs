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
        private MySqlConnection objetoConexao; 
        public ConexaoBanco()
        {
            objetoConexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=clinicafono;password=123456");

        }
        public MySqlConnection ObjetoConexao { get => objetoConexao; }
             
    }
}
