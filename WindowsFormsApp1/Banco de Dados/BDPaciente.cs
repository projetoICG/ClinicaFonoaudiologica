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

        public BDPaciente()
        {
            conexaobanco = new ConexaoBanco();
        }
        public void prepararCadastrarPacienteMaiorDeIdade(Paciente paciente, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = paciente.Cpf;
            objetoComando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = paciente.Rg;
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = paciente.Nome;
            objetoComando.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = paciente.Sexo;
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

        public void prepararCadastrarPacienteMenorDeIdade(PacienteMenor paciente, MySqlCommand objetoComando)
        {
            objetoComando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = paciente.Cpf;
            objetoComando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = paciente.Rg;
            objetoComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = paciente.Nome;
            objetoComando.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = paciente.Sexo;
            objetoComando.Parameters.Add("@rua", MySqlDbType.VarChar).Value = paciente.Rua;
            objetoComando.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = paciente.Bairro;
            objetoComando.Parameters.Add("@numero", MySqlDbType.VarChar).Value = paciente.Numero;
            objetoComando.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = paciente.Complemento;
            objetoComando.Parameters.Add("@telefone1", MySqlDbType.VarChar).Value = paciente.Telefone1;
            objetoComando.Parameters.Add("@telefone2", MySqlDbType.VarChar).Value = paciente.Telefone2;
            objetoComando.Parameters.Add("@email", MySqlDbType.VarChar).Value = paciente.Email;
            objetoComando.Parameters.Add("@dataNascimento", MySqlDbType.VarChar).Value = paciente.DataNascimento;
            objetoComando.Parameters.Add("@observacoes", MySqlDbType.VarChar).Value = paciente.Observacoes;
            objetoComando.Parameters.Add("@nomeMae", MySqlDbType.VarChar).Value = paciente.NomeMae;
            objetoComando.Parameters.Add("@nomePai", MySqlDbType.VarChar).Value = paciente.NomePai;
            objetoComando.Parameters.Add("@nomeParente", MySqlDbType.VarChar).Value = paciente.NomeParente;
            objetoComando.Parameters.Add("@cpfMae", MySqlDbType.VarChar).Value = paciente.CpfMae;
            objetoComando.Parameters.Add("@cpfPai", MySqlDbType.VarChar).Value = paciente.CpfPai;
            objetoComando.Parameters.Add("@cpfParente", MySqlDbType.VarChar).Value = paciente.CpfParente;
        }

        public List<PacienteMenor> buscarEspecificacaoPacienteMenor(string coluna, string busca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM Paciente_Menor_Idade " +
                    "where " + coluna + " like \"" + busca + "\";", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<PacienteMenor> pacientes = new List<PacienteMenor>();

                while (dados.Read())
                {
                    PacienteMenor paciente = new PacienteMenor();
                    paciente.Cpf = dados.GetString("cpf");
                    paciente.Rg = dados.GetString("rg");
                    paciente.Id = dados.GetInt32("id_paciente");
                    paciente.Nome = dados.GetString("nome");
                    paciente.Sexo = dados.GetChar("sexo");
                    paciente.Rua = dados.GetString("rua");
                    paciente.Bairro = dados.GetString("bairro");
                    paciente.Numero = dados.GetString("numero");
                    paciente.Complemento = dados.GetString("complemento");
                    paciente.Telefone1 = dados.GetString("telefone1");
                    paciente.Telefone2 = dados.GetString("telefone2");
                    paciente.Email = dados.GetString("email");
                    paciente.DataNascimento = dados.GetString("dataNascimento");
                    paciente.Observacoes = dados.GetString("observacoes");
                    paciente.NomeMae = dados.GetString("nomeMae");
                    paciente.NomePai = dados.GetString("nomePai");
                    paciente.NomeParente = dados.GetString("nomeParente");
                    paciente.CpfMae = dados.GetString("cpfMae");
                    paciente.CpfPai = dados.GetString("cpfPai");
                    paciente.CpfParente = dados.GetString("cpfParente");
                    pacientes.Add(paciente);
                }

                conexao.ObjetoConexao.Close();
                return pacientes;
            }
            catch (MySqlException x)
            {
                return null;
            }
            return null;
        }

        public List<Paciente> buscarEspecificacaoPacienteMaior(string coluna, string busca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM Paciente_Maior_Idade " +
                    "where " + coluna + " like \"" + busca + "\";", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Paciente> pacientes = new List<Paciente>();

                while (dados.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Cpf = dados.GetString("cpf");
                    paciente.Rg = dados.GetString("rg");
                    paciente.Id = dados.GetInt32("id_paciente");
                    paciente.Nome = dados.GetString("nome");
                    paciente.Sexo = dados.GetChar("sexo");
                    paciente.Rua = dados.GetString("rua");
                    paciente.Bairro = dados.GetString("bairro");
                    paciente.Numero = dados.GetString("numero");
                    paciente.Complemento = dados.GetString("complemento");
                    paciente.Telefone1 = dados.GetString("telefone1");
                    paciente.Telefone2 = dados.GetString("telefone2");
                    paciente.Email = dados.GetString("email");
                    paciente.DataNascimento = dados.GetString("dataNascimento");
                    paciente.Observacoes = dados.GetString("observacoes");

                    pacientes.Add(paciente);
                }

                conexao.ObjetoConexao.Close();
                return pacientes;
            }
            catch (MySqlException x)
            {
                return null;
            }
            return null;
        }

        public int cadastrarPacienteMenorDeIdade(PacienteMenor paciente)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();

                MySqlCommand objetoComando = new MySqlCommand("insert into " +
                    "paciente_menor_idade (cpf, rg, nome, sexo, " +
                    "rua, bairro, numero, " +
                    "complemento, telefone1, telefone2, " +
                    "email, dataNascimento, observacoes, nomeMae, nomePai, nomeParente," +
                    "cpfMae, cpfPai, cpfParente) values (? , ? , ?, " +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?," +
                    "?, ?, ?);", conexao.ObjetoConexao);
                prepararCadastrarPacienteMenorDeIdade(paciente, objetoComando);

                objetoComando.ExecuteNonQuery();

                conexao.ObjetoConexao.Close();

                return 0;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
            return 0;
        }



        public int cadastrarPacienteMaiorDeIdade(Paciente paciente)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();

                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("insert into " +
                    "paciente_maior_idade (cpf, rg, nome, sexo, " +
                    "rua, bairro, numero, complemento, telefone1, telefone2, " +
                    "email, dataNascimento, observacoes) values (? , ? , ?, " +
                    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", conexao.ObjetoConexao);

                prepararCadastrarPacienteMaiorDeIdade(paciente, objetoComando);

                objetoComando.ExecuteNonQuery();

                conexao.ObjetoConexao.Close();
                return 0;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return 1;
        }

        public List<PacienteMenor> retornarListaPacientesMenor()
        {

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM paciente_menor_idade;", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<PacienteMenor> pacientes = new List<PacienteMenor>();

                while (dados.Read())
                {

                    PacienteMenor paciente = new PacienteMenor();
                    paciente.Cpf = dados.GetString("cpf");
                    paciente.Rg = dados.GetString("rg");
                    paciente.Id = dados.GetInt32("id_paciente");
                    paciente.Nome = dados.GetString("nome");
                    paciente.Sexo = dados.GetChar("sexo");
                    paciente.Rua = dados.GetString("rua");
                    paciente.Bairro = dados.GetString("bairro");
                    paciente.Numero = dados.GetString("numero");
                    paciente.Complemento = dados.GetString("complemento");
                    paciente.Telefone1 = dados.GetString("telefone1");
                    paciente.Telefone2 = dados.GetString("telefone2");
                    paciente.Email = dados.GetString("email");
                    paciente.DataNascimento = dados.GetString("dataNascimento");
                    paciente.Observacoes = dados.GetString("observacoes");
                    paciente.NomeMae = dados.GetString("nomeMae");
                    paciente.NomePai = dados.GetString("nomePai");
                    paciente.NomeParente = dados.GetString("nomeParente");
                    paciente.CpfMae = dados.GetString("cpfMae");
                    paciente.CpfPai = dados.GetString("cpfPai");
                    paciente.CpfParente = dados.GetString("cpfParente");
                    pacientes.Add(paciente);
                }

                conexao.ObjetoConexao.Close();

                return pacientes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        public List<Paciente> retornarListaPacientesMaior()
        {

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.ObjetoConexao.Open();
                MySqlCommand objetoComando = new MySqlCommand("SELECT * FROM paciente_maior_idade;", conexao.ObjetoConexao);
                MySqlDataReader dados = objetoComando.ExecuteReader();

                List<Paciente> pacientes = new List<Paciente>();

                while (dados.Read())
                {

                    PacienteMenor paciente = new PacienteMenor();
                    paciente.Cpf = dados.GetString("cpf");
                    paciente.Rg = dados.GetString("rg");
                    paciente.Id = dados.GetInt32("id_paciente");
                    paciente.Nome = dados.GetString("nome");
                    paciente.Sexo = dados.GetChar("sexo");
                    paciente.Rua = dados.GetString("rua");
                    paciente.Bairro = dados.GetString("bairro");
                    paciente.Numero = dados.GetString("numero");
                    paciente.Complemento = dados.GetString("complemento");
                    paciente.Telefone1 = dados.GetString("telefone1");
                    paciente.Telefone2 = dados.GetString("telefone2");
                    paciente.Email = dados.GetString("email");
                    paciente.DataNascimento = dados.GetString("dataNascimento");
                    paciente.Observacoes = dados.GetString("observacoes");
                    pacientes.Add(paciente);
                }

                conexao.ObjetoConexao.Close();

                return pacientes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

    }
}
