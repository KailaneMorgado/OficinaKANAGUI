using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaKANAGUI.Model
{
    internal class OrdemServico
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }
        public int IdServico { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool Situacao { get; set; }
        public string Email { get; set; }
        public int Quantidade { get; set; }
        public string NomeServico { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM view_ordens";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public DataTable BuscarPorFicha()
        {
            string comando = "SELECT * FROM view_ordens WHERE email = @email";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@email", Email);

            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO ordemservico (nome_servico,id_usuario,id_servico, quantidade) VALUES " +
                "(@nome_servico, @id_usuario, @id_servico, quantidade)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_servico", NomeServico);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_servico", IdServico);

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

        public bool EncerrarComanda()
        {
            string comando = "UPDATE ordemservico SET situacao = 0 WHERE email = @email AND situacao = 1";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@email", Email);
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
