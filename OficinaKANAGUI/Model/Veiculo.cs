using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaKANAGUI.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int IdUsuario { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM veiculo";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO veiculo (placa, cor, ano, modelo, marca,id_usuario) VALUES (@placa, @cor, @ano, @modelo, @marca , @id_usuario)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@placa", Placa);
            cmd.Parameters.AddWithValue("@cor", Cor);
            cmd.Parameters.AddWithValue("@ano", Ano);
            cmd.Parameters.AddWithValue("@modelo", Modelo);
            cmd.Parameters.AddWithValue("@marca", Marca);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

            cmd.Prepare();
            // O trecho abaixo irá retornar true caso o cadastro dê certo:
            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;
            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Apagar()
        {
            string comando = "DELETE FROM veiculo WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public bool Modificar()
        {
            string comando = "UPDATE veiculo SET placa = @placa, cor = @cor, ano = @ano, modelo = @modelo, marca = @marca, id_usuario = @id_usuario WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@placa", Placa);
            cmd.Parameters.AddWithValue("@cor", Cor);
            cmd.Parameters.AddWithValue("@ano", Ano);
            cmd.Parameters.AddWithValue("@modelo", Modelo);
            cmd.Parameters.AddWithValue("@marca", Marca);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
            cmd.Parameters.AddWithValue("@id", Id);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
