using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaKANAGUI
{
    public partial class FormUsuario : Form
    {
        //Objetos globais
        Model.Usuario usuario;

        int idSelecionado = 0; //armazenar o id do usuário selecionado p/ apagar ou editar

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public void AtualizarDgv()
        {
            //Mostrar as informações do bd no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastrar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastrar.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastrar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();

                //Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNomeCadastrar.Text;
                usuarioCadastro.Email = txbEmailCadastrar.Text;
                usuarioCadastro.Senha = txbSenhaCadastrar.Text;

                //Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    //Apagar os campos de cadastro (após cadastrar):
                    txbNomeCadastrar.Clear();
                    txbEmailCadastrar.Clear();
                    txbSenhaCadastrar.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar usuário", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            //Colocar os valores das células nos txb's de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            //Ativar o grbEditar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Ajustes no grbApagar:
            lblSelecioneApagar.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value.ToString()}";

            //Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                //Prosseguir com a exclusão
                Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;

                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar usuário", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {
            //Atualizar o dgv:
            AtualizarDgv();

            //Limpar campos de edição:
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            //Retornar o idSelecionado para 0
            idSelecionado = 0;

            //Retornar o texto padrão do "apagar":
            lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar usuário", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbNomeCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbEmailCadastrar.Focus();
                e.Handled = true;
            }
        }

        private void txbEmailCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenhaCadastrar.Focus();
                e.Handled = true;
            }
        }

        private void txbSenhaCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void txbNomeEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbEmailEditar.Focus();
                e.Handled = true;
            }
        }

        private void txbEmailEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenhaEditar.Focus();
                e.Handled = true;
            }
        }

        private void txbSenhaEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEditar.PerformClick();
            }
        }
    }
}
