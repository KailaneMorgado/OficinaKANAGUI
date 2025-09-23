using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaKANAGUI
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //Verificar se a pessoa digitou o email e a senha:
            if (txbEmail.Text.Length < 6) //o .length eu vejo quantas letras tem no text box
            {
                MessageBox.Show("Digite um e-mail válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma senha válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                //Colocar os valores dos campos nos atributos do usuario:
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                //Tabela que vai receber o resultado do SELECT (Logar)
                DataTable resultado = usuario.Logar();

                //Verificar se acertou o email e a senha:
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Armazenar as infos vindas do banco de dados no objeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    //Mudar para o MenuPrincipal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); //esconder a janela atual (que no caso é a de login)
                    menuPrincipal.ShowDialog(); //mostrar o MenuPrincipal

                    Show(); //Mostrar a tela de login caso a pessoa saia do menu principal.
                }
            }
        }

        private void txbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenha.Focus();
                e.Handled = true;
            }
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar.PerformClick();
            }
        }
    }
}
